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
            TextBlock1.Visibility = Visibility.Collapsed;
            TextBlock2.Visibility = Visibility.Collapsed;
        }


        private void OpenFile_Click(object sender, RoutedEventArgs e)                      //CODICE FILESYSTEM
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
            }                                                                              //FINE CODICE FILESYSTEM




        }
        private void OpenFileVerifica_Click(object sender, RoutedEventArgs e)              //CODICE FILESYSTEM VERIFICA
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
        }                                                                                  //FINE FILESYSTEM VERIFICA


                                                                                

        private void ConfrontaDueTextBlock_Click(object sender, RoutedEventArgs e)         //INIZIO CONFRONTA
        {
            if (String.IsNullOrWhiteSpace(TextBlock1.Text))
            {
                MessageBox.Show("File Scaricato non Importato");
                return;
            }
            if (String.IsNullOrWhiteSpace(TextBlock2.Text))
            {
                MessageBox.Show("File di Verifica non Importato");
                return;
            }
            if (TextBlock1.Text.Trim() == TextBlock2.Text.Trim())
            {
                MessageBox.Show("Lo SHA256 è uguale");
                return;
            }
            else
            {
                MessageBox.Show("Lo SHA256 non è uguale");
                return;
            }
           

        }                                                                                 //FINE CONFORNTA

        private void EliminaContenutoTextBlock_Click(object sender, RoutedEventArgs e)    //INIZIO ELIMINAZIONE CONTENUTI ALL'INTERNO DELLE TEXTBLOCK
        {
            TextBlock1.Text = "";
            TextBlock2.Text = "";
            LabelCambio.Content = "Importa i Due File Richiesti";
        }                                                                                 //FINE ELIMINAZIONE CONTENUTI ALL'INTERNO DELLE TEXTBLOCK

        private void EliminaSha1_Click(object sender, RoutedEventArgs e)                  //INIZIO ELIMINAZIONE CONTENUTO PRIMO SHA
        {
            TextBlock1.Text = "";
        }                                                                                 //FINE ELIMINAZIONE CONTENUTO PRIMO SHA

        private void EliminaSha2_Click(object sender, RoutedEventArgs e)                   //INIZIO ELIMINAZIONE CONTENUTO SECONDO SHA
        {
            TextBlock2.Text = "";
        }                                                                                  //FINE ELIMINAZIONE CONTENUTO SECONDO SHA

        private void CloseProgram_Click(object sender, RoutedEventArgs e)                  //INIZIO BOTTONE CHE CHIUDE IL PROGRAMMA
        {
            Close();
        }                                                                                  //FINE BOTTONE CHE CHIUDE IL PROGRAMMA


        private void MettiTendinaProgramma_Click(object sender, RoutedEventArgs e)         //INIZIO BOTTONE CHE CHIUDE IL PROGRAMMA
        {
            this.WindowState = WindowState.Minimized;
        }                                                                                  //FINE BOTTONE CHE CHIUDE IL PROGRAMMA

        private void BottoneAvanti_Click(object sender, RoutedEventArgs e)                //INIZIO BOTTONE CHE FA ANDARE AVANTI LE  ISTRUZIONI
        {
            if (String.IsNullOrWhiteSpace(TextBlock1.Text ))
            {
                MessageBox.Show("File Scaricato non Importato");
                return;
            }
            if (String.IsNullOrWhiteSpace(TextBlock2.Text))
            {
                MessageBox.Show("File Di Verifica non Importato");
                return;
            }
            else
            {
                LabelCambio.Content = "Confronta i Due File";
            }



        }                                                                                //FINE BOTTONE CHE FA ANDARE AVANTI LE  ISTRUZIONI
    } 
}



