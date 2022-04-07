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
                    TextBlock1.Text = SHA256.SHA256CheckSum(openFileDialog.FileName);
                {
                    // l'utente fa qualcosa
                }
            }                                                                            //FINE CODICE FILESYSTEM




        }
        private void OpenFileVerifica_Click(object sender, RoutedEventArgs e)                //CODICE FILESYSTEM VERIFICA
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            { //] } ;
                if (MessageBox.Show("Vuoi Importare Questo File?",
                       "Save file",
                       MessageBoxButton.YesNo,
                       MessageBoxImage.Question) == MessageBoxResult.Yes)
                    TextBlock2.Text = SHA256.LetturaInterna(openFileDialog.FileName);
                {
                    // l'utente fa qualcosa
                }
            }
        }                                                                                       //FINE FILESYSTEM VERIFICA


                                                                                

        private void ConfrontaDueTextBlock_Click(object sender, RoutedEventArgs e)          //INIZIO CONFRONTA
        {
            if (TextBlock1.Text.Trim() == TextBlock2.Text.Trim())
            {
                MessageBox.Show("Lo SHA256 è uguale");
            }
            else
            {
                MessageBox.Show("Lo SHA256 non è uguale");
                return;
            }
        }                                                                               //FINE CONFORNTA






    }
}



