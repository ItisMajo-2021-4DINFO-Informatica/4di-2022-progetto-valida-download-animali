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
            ConfrontaDueTextBlock.Visibility = Visibility.Hidden;
            RedLabelSha.Visibility = Visibility.Hidden;
            GreenLabelSha.Visibility = Visibility.Visible;
            RedLabelVerifica.Visibility = Visibility.Hidden;
            GreenLabelVerifica.Visibility = Visibility.Visible;
        }


        private void OpenFile_Click(object sender, RoutedEventArgs e)                      //CODICE FILESYSTEM
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.iso)|*.iso| All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {

                TextBlock1.Text = SHA256.SHA256CheckSum(openFileDialog.FileName);
                RedLabelSha.Visibility = Visibility.Visible;
                 GreenLabelSha.Visibility = Visibility.Hidden;
            

            }

                                                                                           //FINE CODICE FILESYSTEm
        }

        private void OpenFileVerifica_Click(object sender, RoutedEventArgs e)              //CODICE FILESYSTEM VERIFICA
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.sha256)|*.sha256| All files(*.*)| *.*";

            if (openFileDialog.ShowDialog() == true)
            {

                TextBlock2.Text = SHA256.LetturaInterna(openFileDialog.FileName);
                GreenLabelVerifica.Visibility = Visibility.Hidden;
                RedLabelVerifica.Visibility = Visibility.Visible;

            }
            {
                // l'utente compie un azione
            }

        }

                                                                                            //FINE FILESYSTEM VERIFICA
                                                                  

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
            GreenLabelSha.Visibility = Visibility.Visible;
            GreenLabelVerifica.Visibility = Visibility.Visible;
            RedLabelSha.Visibility = Visibility.Hidden;
            RedLabelVerifica.Visibility = Visibility.Hidden;
        }                                                                                 //FINE ELIMINAZIONE CONTENUTI ALL'INTERNO DELLE TEXTBLOCK

        private void EliminaSha1_Click(object sender, RoutedEventArgs e)                  //INIZIO ELIMINAZIONE CONTENUTO PRIMO SHA
        {
            
            GreenLabelSha.Visibility = Visibility.Visible;
            TextBlock1.Text = "";
            RedLabelSha.Visibility = Visibility.Hidden;
           

        }                                                                                 //FINE ELIMINAZIONE CONTENUTO PRIMO SHA

        private void EliminaSha2_Click(object sender, RoutedEventArgs e)                   //INIZIO ELIMINAZIONE CONTENUTO SECONDO SHA
        {
            
            GreenLabelVerifica.Visibility = Visibility.Visible;
            TextBlock2.Text = "";
            RedLabelVerifica.Visibility = Visibility.Hidden;

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
            if (String.IsNullOrWhiteSpace(TextBlock1.Text))
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
                ConfrontaDueTextBlock.Visibility = Visibility.Visible;
             
            }

        }                                                                                //FINE BOTTONE CHE FA ANDARE AVANTI LE  ISTRUZIONI
       
    }
} 



