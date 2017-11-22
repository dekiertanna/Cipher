namespace Cipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.YesBtn = new System.Windows.Forms.Button();
            this.NoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 88);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Wybrany klucz jest słaby. Zaleca się, aby klucz zawierał przynajmniej jedną dużą " +
    "i małą literę, cyfrę i znak specjalny. Czy mimo to chcesz kontynuować?";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // YesBtn
            // 
            this.YesBtn.Location = new System.Drawing.Point(40, 115);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(75, 23);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.Text = "Tak";
            this.YesBtn.UseVisualStyleBackColor = true;
            // 
            // NoBtn
            // 
            this.NoBtn.Location = new System.Drawing.Point(139, 115);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(75, 23);
            this.NoBtn.TabIndex = 3;
            this.NoBtn.Text = "Nie";
            this.NoBtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.ControlBox = false;
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Uwaga!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button NoBtn;
    }
}