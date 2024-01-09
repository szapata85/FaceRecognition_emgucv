namespace FaceDetectionAndRecognition
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecognition = new System.Windows.Forms.Button();
            this.Camerabox = new System.Windows.Forms.PictureBox();
            this.CameraGraybox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.Camerabox2 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraGraybox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecognition
            // 
            this.btnRecognition.Location = new System.Drawing.Point(629, 25);
            this.btnRecognition.Name = "btnRecognition";
            this.btnRecognition.Size = new System.Drawing.Size(75, 23);
            this.btnRecognition.TabIndex = 0;
            this.btnRecognition.Text = "Detectar";
            this.btnRecognition.UseVisualStyleBackColor = true;
            this.btnRecognition.Click += new System.EventHandler(this.button1_Click);
            // 
            // Camerabox
            // 
            this.Camerabox.Location = new System.Drawing.Point(32, 25);
            this.Camerabox.Name = "Camerabox";
            this.Camerabox.Size = new System.Drawing.Size(146, 83);
            this.Camerabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Camerabox.TabIndex = 1;
            this.Camerabox.TabStop = false;
            // 
            // CameraGraybox
            // 
            this.CameraGraybox.Location = new System.Drawing.Point(433, 25);
            this.CameraGraybox.Name = "CameraGraybox";
            this.CameraGraybox.Size = new System.Drawing.Size(146, 83);
            this.CameraGraybox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CameraGraybox.TabIndex = 2;
            this.CameraGraybox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(666, 94);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(629, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(629, 185);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // Camerabox2
            // 
            this.Camerabox2.Location = new System.Drawing.Point(433, 125);
            this.Camerabox2.Name = "Camerabox2";
            this.Camerabox2.Size = new System.Drawing.Size(146, 83);
            this.Camerabox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Camerabox2.TabIndex = 8;
            this.Camerabox2.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(586, 274);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.Camerabox2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CameraGraybox);
            this.Controls.Add(this.Camerabox);
            this.Controls.Add(this.btnRecognition);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CameraGraybox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecognition;
        private System.Windows.Forms.PictureBox Camerabox;
        private System.Windows.Forms.PictureBox CameraGraybox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.PictureBox Camerabox2;
        private System.Windows.Forms.Label lblNombre;
    }
}

