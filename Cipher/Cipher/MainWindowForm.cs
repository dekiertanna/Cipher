﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cipher
{
    public partial class cipherMainWindow : Form
    {
        public cipherMainWindow()
        {
            InitializeComponent();
            Encoder enc = new Encoder();
            enc.ReadFileContents("tekst.txt");
            enc.SetKey("lacina");
            enc.DivideIntoBlocks();
            enc.Permutate();
            enc.setASCIIblocks();
            enc.Replace();
            enc.ConverToString();
            enc.WriteOutputToFile("output.txt");

            Decoder dec = new Decoder();
            dec.ReadFileContents("test.cry");
            dec.SetKey("lacina");
            dec.DivideIntoBlocks();
            dec.Replace();
            dec.Depermutate();
            dec.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fileToCipherBtn_Click(object sender, EventArgs e)
        {
            int size = -1;
            
            DialogResult result = openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    fileToCipherPath.Text = openFileDialog.FileName;
                }
                catch(IOException) { }
            }

            Console.WriteLine(size);
            Console.WriteLine(result);
        }

        private void saveLocationBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "";
            saveFileDialog.Title = "Gdzie chcesz zapisać plik?";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName!="")
            {
                saveLocationPath.Text = saveFileDialog.FileName;

            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            InfoForm info = new InfoForm();
            info.ShowDialog();
        }

        private void startCipherBtn_Click(object sender, EventArgs e)
        {
            Encoder enc = new Encoder();
            enc.Encode(fileToCipherPath.Text, saveLocationPath.Text, keyTextBox.Text);
        }

        private void startDecoderBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "text(*.txt)| *.txt";
            Decoder dec = new Decoder();
            dec.Decode(fileToCipherPath.Text, saveLocationPath.Text, keyTextBox.Text);
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
