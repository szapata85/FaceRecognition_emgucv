using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Drawing.Imaging;
using System.IO;

namespace FaceDetectionAndRecognition
{
    public partial class Form2 : Form
    {
        VideoCapture camera;

        Image<Bgr, byte> frame;
        Image<Bgr, byte> frame2;
        int cuadro = 100;
        string path;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            camera = new VideoCapture();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            Mat Frame = camera.QueryFrame();

            if (Frame != null)
            {
                frame = Frame.ToImage<Bgr, byte>().Resize(800, 600, Inter.LinearExact);//.Flip(FlipType.Horizontal);


                Rectangle border = new Rectangle(50, 50, 600, 400);

                frame.Draw(border, new Bgr(Color.Blue),2);

                CvInvoke.PutText(frame, "Ubique el documento de identidad", new Point(150, 45), FontFace.HersheySimplex,0.7, new Bgr(Color.Blue).MCvScalar);

                Camerabox.Image = frame.ToBitmap();

                frame2 = frame.Copy();
                frame2.ROI = border;

                Camerabox2.Image = frame2.ToBitmap();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            path = "../../Data/Faces/" + txtCedula.Text + "/";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            Camerabox2.Image.Save(path + "_" + txtCedula.Text + ".jpg", ImageFormat.Jpeg);
        }
    }
}
