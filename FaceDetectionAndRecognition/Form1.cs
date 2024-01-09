using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace FaceDetectionAndRecognition
{
    public partial class Form1 : Form
    {
        //Declare Variables
        CascadeClassifier faceDetected;

        Image<Bgr,byte> frame;
        Image<Bgr, byte> frame2;
        VideoCapture camera;
        Image<Gray, byte> grayFace = null;
        List<string> Users = new List<string>();
        int Count; 
        int Count_max = 300;
        bool savebool = false, validatebool = false;
        string path = string.Empty;
        FaceRecognizer faceRecognition;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresa un numero de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                savebool = false;
            }
            savebool = true;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresa un numero de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validatebool = false;
            }
            validatebool = true;
        }

        public Form1()
        {
            InitializeComponent();
            faceDetected = new CascadeClassifier("../../Classifier/haarcascade_frontalface_default.xml");
            path = "../../Data/Faces/" + txtCedula.Text + "/";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            camera = new VideoCapture();
            Application.Idle += new EventHandler(FrameProcedure);

        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Users.Add(string.Empty);
            Mat Frame = camera.QueryFrame();
            
            if (Frame != null)
            {
                frame = Frame.ToImage<Bgr, byte>().Resize(320,240,Inter.LinearExact);
                frame2 = frame.Convert<Bgr, byte>();
                grayFace = frame.Convert<Gray, byte>();

                Rectangle[] faceDetectedNow = faceDetected.DetectMultiScale(grayFace, 1.1, 4);
                
                foreach (Rectangle face in faceDetectedNow)
                {
                    frame.Draw(face, new Bgr(Color.Green),2);

                    frame2.ROI = face;
                    grayFace.ROI = face;
                }

                Camerabox.Image = frame.Flip(FlipType.Horizontal).ToBitmap();
                Camerabox2.Image = frame2.Flip(FlipType.Horizontal).ToBitmap();
                CameraGraybox.Image = (faceDetectedNow.Count<Rectangle>() == 1)? grayFace.Flip(FlipType.Horizontal).ToBitmap():null;
                
                if (savebool)
                {
                    if (Count <= Count_max && CameraGraybox.Image != null)
                    {
                        path = "../../Data/Faces/" + txtCedula.Text + "/";
                        if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);
                         Camerabox2.Image.Save(path + Count.ToString() + "_" + txtCedula.Text + ".bmp", ImageFormat.Bmp);

                        if (Count == Count_max)
                        {
                            savebool = false;
                            Count = 0;

                            

                            //Listo las imagenes guardadas
                            List<string> Paths = Directory.GetFiles(path,"*.bmp").ToList();

                            List<Mat> TrainingFaces = new List<Mat>();
                            List<int> FaceIDs = new List<int>();

                            foreach (string Path in Paths)
                            {
                                TrainingFaces.Add(new Mat(Path,ImreadModes.Grayscale));
                                FaceIDs.Add(int.Parse(txtCedula.Text));
                            }

                            //Entrenamos el modelo
                            faceRecognition = new LBPHFaceRecognizer(threshold:100);

                            
                            faceRecognition.Train(new VectorOfMat(TrainingFaces.ToArray()), new VectorOfInt( FaceIDs.ToArray()));
                            faceRecognition.Write(path + txtCedula.Text + ".xml");
                        }
                           
                    }
                        Count += 1;



                }


                if (validatebool)
                {
                    path = "../../Data/Faces/" + txtCedula.Text + "/";
                    if (Directory.Exists(path))
                    {
                        List<string> Paths = Directory.GetFiles(path, "*.xml").ToList();

                        faceRecognition = new LBPHFaceRecognizer(threshold: 100);
                        faceRecognition.Read(Paths[0]);

                        FaceRecognizer.PredictionResult prediccion = faceRecognition.Predict(grayFace);

                        lblNombre.Text = (prediccion.Label == int.Parse(txtCedula.Text)) ? txtCedula.Text : "No Valido";
                    }
                }
                
            }
        }
    }
}
