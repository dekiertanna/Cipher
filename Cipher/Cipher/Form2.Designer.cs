namespace Cipher
{
    partial class TooShortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TooShortForm));
            this.errorPic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).BeginInit();
            this.SuspendLayout();
            // 
            // errorPic
            // 
            this.errorPic.Image = ((System.Drawing.Image)(resources.GetObject("errorPic.Image")));
            this.errorPic.Location = new System.Drawing.Point(12, 12);
            this.errorPic.Name = "errorPic";
            this.errorPic.Size = new System.Drawing.Size(32, 32);
            this.errorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorPic.TabIndex = 0;
            this.errorPic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Klucz musi zawierać minimum 6 znaków!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(71, 78);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 2;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // TooShortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 113);
            this.ControlBox = false;
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorPic);
            this.Name = "TooShortForm";
            this.Text = "Uwaga!";
            ((System.ComponentModel.ISupportInitialize)(this.errorPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox errorPic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OkBtn;
    }
}