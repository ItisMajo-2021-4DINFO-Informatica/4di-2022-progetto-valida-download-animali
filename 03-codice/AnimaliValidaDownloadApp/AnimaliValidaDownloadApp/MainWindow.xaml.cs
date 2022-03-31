using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows;

namespace AnimaliValidaDownloadApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClasseDelloSha256 SHA256 = new();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OpenFile_Click(object sender, RoutedEventArgs e)               //CODICE FILESYSTEM
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            { //] } ;
                if (MessageBox.Show("Vuoi Importare Questo File?",
                       "Save file",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Question) == MessageBoxResult.Yes)
                    txtFile.Text = SHA256.SHA256CheckSum(openFileDialog.FileName);
                {
                    // l'utente fa qualcosa
                }
            }                                                                            //FINE CODICE FILESYSTEM




        }
    }
}



