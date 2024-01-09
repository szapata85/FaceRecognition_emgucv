namespace FaceDetectionAndRecognition
{
    partial class Form2
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
            this.Camerabox = new System.Windows.Forms.PictureBox();
            this.btnRecognition = new System.Windows.Forms.Button();
            this.Camerabox2 = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Camerabox
            // 
            this.Camerabox.Location = new System.Drawing.Point(35, 28);
            this.Camerabox.Name = "Camerabox";
            this.Camerabox.Size = new System.Drawing.Size(146, 83);
            this.Camerabox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Camerabox.TabIndex = 2;
            this.Camerabox.TabStop = false;
            // 
            // btnRecognition
            // 
            this.btnRecognition.Location = new System.Drawing.Point(621, 12);
            this.btnRecognition.Name = "btnRecognition";
            this.btnRecognition.Size = new System.Drawing.Size(75, 23);
            this.btnRecognition.TabIndex = 3;
            this.btnRecognition.Text = "Detectar";
            this.btnRecognition.UseVisualStyleBackColor = true;
            this.btnRecognition.Click += new System.EventHandler(this.btnRecognition_Click);
            // 
            // Camerabox2
            // 
            this.Camerabox2.Location = new System.Drawing.Point(989, 28);
            this.Camerabox2.Name = "Camerabox2";
            this.Camerabox2.Size = new System.Drawing.Size(146, 83);
            this.Camerabox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Camerabox2.TabIndex = 9;
            this.Camerabox2.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(702, 12);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(87, 23);
            this.btnCapturar.TabIndex = 10;
            this.btnCapturar.Text = "Capturar Foto";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(807, 13);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 11;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 530);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.Camerabox2);
            this.Controls.Add(this.btnRecognition);
            this.Controls.Add(this.Camerabox);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camerabox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Camerabox;
        private System.Windows.Forms.Button btnRecognition;
        private System.Windows.Forms.PictureBox Camerabox2;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.TextBox txtCedula;
    }
}