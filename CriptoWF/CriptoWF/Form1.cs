using System;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CriptoWF
{

    public partial class Form1 : Form
    {
        private string textToCript;
        private string fileNameToWrite;
        private string IV;
        private string key;
        private string Algorithm;
        private PaddingMode padding;
        private CipherMode mode;
        private byte[] encrypted;
        private string decrypted;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Select_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = fileDialog.FileName;
                try
                {
                    textToCript = File.ReadAllText(file);

                    MessageBox.Show(textToCript);
                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
        }

        private void BtnUpload_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    fileNameToWrite = fileDialog.FileName;
                    MessageBox.Show("You chose : " + fileNameToWrite);
                }
                catch (IOException ex)
                {
                    throw ex;
                }
            }
        }
        private void EncryptedTextBox_OnValidating(object sender, EventArgs e)
        {
            if (this.Text != null)
                select_btn.Enabled = false;
            else
                select_btn.Enabled = true;
        }


        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (EncryptedTextBox.Text != "")
            {
                textToCript = EncryptedTextBox.Text;
            }
            try
            {
                if (textToCript == null)
                    throw new Exception("Text to cript isn't selected");
                if (IVTextBox.Text != "")
                    IV = IVTextBox.Text;
                if (KeyTextBox.Text != "")
                    key = KeyTextBox.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            switch (Algorithm)
            {
                case "Aes":
                    {
                        Aes aes = new Aes(mode, padding);
                        encrypted = aes.EncryptToByte(textToCript);
                        WriteFile();
                        WriteOnTextBox();
                        break;
                    }
                case "DES":
                    {
                        MessageBox.Show("s");
                        break;
                    }
                case "RC2":
                    {
                        MessageBox.Show("");
                        break;
                    }
                case "Rijnadel":
                    {

                        Rijndael aes = new Rijndael(Encoding.ASCII.GetBytes(key), Encoding.ASCII.GetBytes(IV), mode, padding);
                        encrypted = aes.EncryptToByte(textToCript);
                        WriteFile();
                        WriteOnTextBox();
                        break;
                    }
                case "TripleDES":
                    {
                        MessageBox.Show("");
                        break;
                    }
            }


        }
        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (EncryptedTextBox.Text != "")
            {
                textToCript = EncryptedTextBox.Text;
            }
            encrypted = Encoding.ASCII.GetBytes(textToCript);

            try
            {
                if (textToCript == "")
                    throw new Exception("Text to decrypt isn't selected");

                if (IVTextBox.Text != "")
                    IV = IVTextBox.Text;
                else
                    throw new Exception("IV isn't selected");
                if (KeyTextBox.Text != "")
                    key = KeyTextBox.Text;
                else
                    throw new Exception("key isn't selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            switch (Algorithm)
            {
                case "Aes":
                    {
                        Aes aes = new Aes( mode, padding);
                        decrypted = aes.Decrypt(encrypted);
                        WriteFile(false);
                        WriteOnTextBox(false);
                        break;
                    }
                case "DES":
                    {
                        MessageBox.Show("");
                        break;
                    }
                case "RC2":
                    {
                        MessageBox.Show("");
                        break;
                    }
                case "Rijnadel":
                    {
                        Rijndael aes = new Rijndael( mode, padding);
                        decrypted = aes.Decrypt(encrypted);
                        WriteFile(false);
                        WriteOnTextBox(false);
                        break;
                    }
                case "TripleDES":
                    {
                        MessageBox.Show("");
                        break;
                    }
            }
        }
        private void WriteFile(bool EncryptDecript = true)
        {
            // true writes the encrypted message to file
            // false writes the decripted message to file
            if (fileNameToWrite != null)
                using (StreamWriter sw = new StreamWriter(fileNameToWrite))
                {
                    if (EncryptDecript)
                        foreach (var item in encrypted)
                        {
                            sw.Write(item.ToString());
                            sw.WriteLine();
                        }
                    else
                        sw.WriteLine(decrypted);
                }
        }
        private void WriteOnTextBox(bool EncryptDecript = true)
        {
            // true writes the encrypted message to textbox
            // false writes the decripted message to textbox
            if (EncryptDecript)
            {
                string temp = "";
                foreach (var item in encrypted)
                {
                    temp += item.ToString();
                }
                DecryptedTextBox.Text = temp;
            }
            else
                DecryptedTextBox.Text = decrypted;
        }
        private void PaddingComboBox_Validating(object sender, CancelEventArgs e)
        {
            string tmp = PaddingComboBox.SelectedItem.ToString();
            switch (tmp)
            {
                case "None":
                    {
                        padding = PaddingMode.None;
                        break;
                    }
                case "PKCS7":
                    {
                        padding = PaddingMode.PKCS7;
                        break;
                    }
                case "Zeros":
                    {
                        padding = PaddingMode.Zeros;
                        break;
                    }
                case "ANSIX923":
                    {
                        padding = PaddingMode.ANSIX923;
                        break;
                    }
                case "ISO10126":
                    {
                        padding = PaddingMode.ISO10126;
                        break;
                    }
            }
        }
        private void AlgorithmComboBox_Validating(object sender, CancelEventArgs e)
        {
            Algorithm = AlgorithmComboBox.SelectedItem.ToString();
        }

        private void OperatingComboBox_Validating(object sender, CancelEventArgs e)
        {
            string temp = OperatingComboBox.SelectedItem.ToString();
            switch (temp)
            {
                case "CBC":
                    {
                        mode = CipherMode.CBC;
                        break;
                    }
                case "ECB":
                    {
                        mode = CipherMode.ECB;
                        break;
                    }
                case "OFB":
                    {
                        mode = CipherMode.OFB;
                        break;
                    }
                case "CFB":
                    {
                        mode = CipherMode.CFB;
                        break;
                    }
                case "CTS":
                    {
                        mode = CipherMode.CTS;
                        break;
                    }
            }
        }
    }
}
