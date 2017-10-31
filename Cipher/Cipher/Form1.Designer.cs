namespace Cipher
{
    partial class cipherMainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fileToCipherPath = new System.Windows.Forms.TextBox();
            this.fileToCipherBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.saveLocationPath = new System.Windows.Forms.TextBox();
            this.saveLocationBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.infoBtn = new System.Windows.Forms.Button();
            this.startCipherBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plik do zaszyfrowania:";
            // 
            // fileToCipherPath
            // 
            this.fileToCipherPath.Location = new System.Drawing.Point(15, 58);
            this.fileToCipherPath.Name = "fileToCipherPath";
            this.fileToCipherPath.ReadOnly = true;
            this.fileToCipherPath.Size = new System.Drawing.Size(430, 20);
            this.fileToCipherPath.TabIndex = 1;
            // 
            // fileToCipherBtn
            // 
            this.fileToCipherBtn.Location = new System.Drawing.Point(451, 58);
            this.fileToCipherBtn.Name = "fileToCipherBtn";
            this.fileToCipherBtn.Size = new System.Drawing.Size(75, 23);
            this.fileToCipherBtn.TabIndex = 2;
            this.fileToCipherBtn.Text = "Przeglądaj...";
            this.fileToCipherBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Miejsce zapisu zaszyfrowanego pliku";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // saveLocationPath
            // 
            this.saveLocationPath.Location = new System.Drawing.Point(15, 149);
            this.saveLocationPath.Name = "saveLocationPath";
            this.saveLocationPath.ReadOnly = true;
            this.saveLocationPath.Size = new System.Drawing.Size(430, 20);
            this.saveLocationPath.TabIndex = 4;
            // 
            // saveLocationBtn
            // 
            this.saveLocationBtn.Location = new System.Drawing.Point(451, 146);
            this.saveLocationBtn.Name = "saveLocationBtn";
            this.saveLocationBtn.Size = new System.Drawing.Size(75, 23);
            this.saveLocationBtn.TabIndex = 5;
            this.saveLocationBtn.Text = "Przeglądaj...";
            this.saveLocationBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Klucz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(15, 225);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(430, 20);
            this.keyTextBox.TabIndex = 7;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(624, 300);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 23);
            this.infoBtn.TabIndex = 8;
            this.infoBtn.Text = "Info...";
            this.infoBtn.UseVisualStyleBackColor = true;
            // 
            // startCipherBtn
            // 
            this.startCipherBtn.Location = new System.Drawing.Point(15, 279);
            this.startCipherBtn.Name = "startCipherBtn";
            this.startCipherBtn.Size = new System.Drawing.Size(75, 23);
            this.startCipherBtn.TabIndex = 9;
            this.startCipherBtn.Text = "Szyfruj!";
            this.startCipherBtn.UseVisualStyleBackColor = true;
            // 
            // cipherMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 335);
            this.Controls.Add(this.startCipherBtn);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveLocationBtn);
            this.Controls.Add(this.saveLocationPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileToCipherBtn);
            this.Controls.Add(this.fileToCipherPath);
            this.Controls.Add(this.label1);
            this.Name = "cipherMainWindow";
            this.Text = "Cipher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileToCipherPath;
        private System.Windows.Forms.Button fileToCipherBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox saveLocationPath;
        private System.Windows.Forms.Button saveLocationBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Button startCipherBtn;
    }
}

