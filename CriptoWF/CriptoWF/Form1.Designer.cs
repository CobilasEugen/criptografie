
namespace CriptoWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.select_btn = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BtnUpload = new System.Windows.Forms.Button();
            this.AlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.OperatingComboBox = new System.Windows.Forms.ComboBox();
            this.PaddingComboBox = new System.Windows.Forms.ComboBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.DecryptBtn = new System.Windows.Forms.Button();
            this.IVTextBox = new System.Windows.Forms.TextBox();
            this.EncryptedTextBox = new System.Windows.Forms.TextBox();
            this.DecryptedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // select_btn
            // 
            this.select_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.select_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.select_btn.Location = new System.Drawing.Point(977, 47);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(123, 61);
            this.select_btn.TabIndex = 0;
            this.select_btn.Text = "Select file";
            this.select_btn.UseVisualStyleBackColor = false;
            this.select_btn.Click += new System.EventHandler(this.Select_btn_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // BtnUpload
            // 
            this.BtnUpload.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnUpload.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.BtnUpload.Location = new System.Drawing.Point(975, 124);
            this.BtnUpload.Name = "BtnUpload";
            this.BtnUpload.Size = new System.Drawing.Size(123, 59);
            this.BtnUpload.TabIndex = 1;
            this.BtnUpload.Text = "Write file";
            this.BtnUpload.UseVisualStyleBackColor = false;
            this.BtnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // AlgorithmComboBox
            // 
            this.AlgorithmComboBox.FormattingEnabled = true;
            this.AlgorithmComboBox.Items.AddRange(new object[] {
            "Aes",
            "DES",
            "RC2",
            "Rijnadel",
            "TripleDES"});
            this.AlgorithmComboBox.Location = new System.Drawing.Point(975, 189);
            this.AlgorithmComboBox.Name = "AlgorithmComboBox";
            this.AlgorithmComboBox.Size = new System.Drawing.Size(125, 33);
            this.AlgorithmComboBox.TabIndex = 2;
            this.AlgorithmComboBox.Text = "Algorithm";
            this.AlgorithmComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.AlgorithmComboBox_Validating);
            // 
            // OperatingComboBox
            // 
            this.OperatingComboBox.FormattingEnabled = true;
            this.OperatingComboBox.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.OperatingComboBox.Location = new System.Drawing.Point(977, 228);
            this.OperatingComboBox.Name = "OperatingComboBox";
            this.OperatingComboBox.Size = new System.Drawing.Size(125, 33);
            this.OperatingComboBox.TabIndex = 3;
            this.OperatingComboBox.Text = "CipherMode";
            this.OperatingComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.OperatingComboBox_Validating);
            // 
            // PaddingComboBox
            // 
            this.PaddingComboBox.FormattingEnabled = true;
            this.PaddingComboBox.Items.AddRange(new object[] {
            "None",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.PaddingComboBox.Location = new System.Drawing.Point(977, 267);
            this.PaddingComboBox.Name = "PaddingComboBox";
            this.PaddingComboBox.Size = new System.Drawing.Size(125, 33);
            this.PaddingComboBox.TabIndex = 4;
            this.PaddingComboBox.Text = "Padding";
            this.PaddingComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.PaddingComboBox_Validating);
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(43, 223);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(656, 31);
            this.KeyTextBox.TabIndex = 5;
            this.KeyTextBox.Text = "Key";
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.EncryptBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EncryptBtn.Location = new System.Drawing.Point(705, 213);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(123, 87);
            this.EncryptBtn.TabIndex = 7;
            this.EncryptBtn.Text = "Encrypt";
            this.EncryptBtn.UseVisualStyleBackColor = false;
            this.EncryptBtn.Click += new System.EventHandler(this.EncryptBtn_Click);
            // 
            // DecryptBtn
            // 
            this.DecryptBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.DecryptBtn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.DecryptBtn.Location = new System.Drawing.Point(834, 213);
            this.DecryptBtn.Name = "DecryptBtn";
            this.DecryptBtn.Size = new System.Drawing.Size(123, 87);
            this.DecryptBtn.TabIndex = 8;
            this.DecryptBtn.Text = "Decrypt";
            this.DecryptBtn.UseVisualStyleBackColor = false;
            this.DecryptBtn.Click += new System.EventHandler(this.DecryptBtn_Click);
            // 
            // IVTextBox
            // 
            this.IVTextBox.Location = new System.Drawing.Point(43, 269);
            this.IVTextBox.Name = "IVTextBox";
            this.IVTextBox.Size = new System.Drawing.Size(656, 31);
            this.IVTextBox.TabIndex = 9;
            this.IVTextBox.Text = "IV array";
            // 
            // EncryptedTextBox
            // 
            this.EncryptedTextBox.Location = new System.Drawing.Point(43, 47);
            this.EncryptedTextBox.Multiline = true;
            this.EncryptedTextBox.Name = "EncryptedTextBox";
            this.EncryptedTextBox.Size = new System.Drawing.Size(914, 160);
            this.EncryptedTextBox.TabIndex = 10;
            this.EncryptedTextBox.Text = "Please place here your text to encrypt";
            // 
            // DecryptedTextBox
            // 
            this.DecryptedTextBox.Location = new System.Drawing.Point(43, 326);
            this.DecryptedTextBox.Multiline = true;
            this.DecryptedTextBox.Name = "DecryptedTextBox";
            this.DecryptedTextBox.ReadOnly = true;
            this.DecryptedTextBox.Size = new System.Drawing.Size(914, 160);
            this.DecryptedTextBox.TabIndex = 11;
            this.DecryptedTextBox.Text = "Decrypted\\Encrypted text ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 567);
            this.Controls.Add(this.DecryptedTextBox);
            this.Controls.Add(this.EncryptedTextBox);
            this.Controls.Add(this.IVTextBox);
            this.Controls.Add(this.DecryptBtn);
            this.Controls.Add(this.EncryptBtn);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.PaddingComboBox);
            this.Controls.Add(this.OperatingComboBox);
            this.Controls.Add(this.AlgorithmComboBox);
            this.Controls.Add(this.BtnUpload);
            this.Controls.Add(this.select_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button BtnUpload;
        private System.Windows.Forms.ComboBox AlgorithmComboBox;
        private System.Windows.Forms.ComboBox OperatingComboBox;
        private System.Windows.Forms.ComboBox PaddingComboBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button DecryptBtn;
        private System.Windows.Forms.TextBox IVTextBox;
        private System.Windows.Forms.TextBox EncryptedTextBox;
        private System.Windows.Forms.TextBox DecryptedTextBox;
    }
}

