using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography; 

namespace HashGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                switch (cmb.SelectedItem)
                {
                    case HMACSHA1:
                        hash1(openFileDialog.FileName);
                        break;

                    case HMACSHA256:
                        hash256(openFileDialog.FileName);
                        break;

                    case HMACSHA384:
                        hash384(openFileDialog.FileName);
                        break;

                    case HMACSHA512:
                        hash512(openFileDialog.FileName);
                        break;
                    default:
                        MessageBox.Show("No option was selected.");
                        txtBox.Text = File.ReadAllText(openFileDialog.FileName);
                        break;
                }
                hash256(openFileDialog.FileName);
            }
        }

        public void hash256(string path)
        {
            using (SHA256 mySHA256 = SHA256.Create())
            {
                try
                {
                    FileStream fileStream = new FileStream(path,FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashvale = mySHA256.ComputeHash(fileStream);
                    txtBox.Text = $"{fileStream.Name}: " + "\n";
                    
                    PrintByteArray(hashvale);
                }
                catch (IOException e)
                {
                    MessageBox.Show($"I/O Exception: {e.Message}");
                }
            }
        }
        public void hash1(string path)
        {
            using (SHA1 mySHA1 = SHA1.Create())
            {
                try
                {
                    FileStream fileStream = new FileStream(path, FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashvale = mySHA1.ComputeHash(fileStream);
                    txtBox.Text = $"{fileStream.Name}: " + "\n";

                    PrintByteArray(hashvale);
                }
                catch (IOException e)
                {
                    MessageBox.Show($"I/O Exception: {e.Message}");
                }
            }
        }
        public void hash384(string path)
        {
            using (SHA384 mySHA384 = SHA384.Create())
            {
                try
                {
                    FileStream fileStream = new FileStream(path, FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashvale = mySHA384.ComputeHash(fileStream);
                    txtBox.Text = $"{fileStream.Name}: " + "\n";

                    PrintByteArray(hashvale);
                }
                catch (IOException e)
                {
                    MessageBox.Show($"I/O Exception: {e.Message}");
                }
            }
        }
        public void hash512(string path)
        {
            using (SHA512 mySHA512 = SHA512.Create())
            {
                try
                {
                    FileStream fileStream = new FileStream(path, FileMode.Open);
                    fileStream.Position = 0;
                    byte[] hashvale = mySHA512.ComputeHash(fileStream);
                    txtBox.Text = $"{fileStream.Name}: " + "\n";

                    PrintByteArray(hashvale);
                }
                catch (IOException e)
                {
                    MessageBox.Show($"I/O Exception: {e.Message}");
                }
            }
        }
        public void PrintByteArray(byte[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                txtBox.Text += $"{array[i]:X2}";
                if ((i % 4) == 3) txtBox.Text += " ";
            }
        }
    }

}
