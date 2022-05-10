using Microsoft.Win32;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows;
using System.Threading;




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
            LabelIndicaConfronto.Visibility = Visibility.Hidden;
        }


        private void OpenFile_Click(object sender, RoutedEventArgs e)                      //CODICE OPENFILEDIALOG (NAVIGAZIONE NEL FILESYSTEM PER RICERCA FILE)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.iso)|*.iso| All files(*.*)|*.*";                  //FILTRI PER LA RICERCA NEL FYLESYSTEM

            if (openFileDialog.ShowDialog() == true)
            {

                TextBlock1.Text = SHA256.SHA256CheckSum(openFileDialog.FileName);
                RedLabelSha.Visibility = Visibility.Visible;
                 GreenLabelSha.Visibility = Visibility.Hidden;
            

            }

                                                                                           //FINE CODICE OPENFILEDIALOG
        }

        private void OpenFileVerifica_Click(object sender, RoutedEventArgs e)             //CODICE OPENFILEDIALOG (NAVIGAZIONE NEL FILESYSTEM PER RICERCA FILE)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.sha256)|*.sha256| All files(*.*)| *.*";           //FILTRI PER LA RICERCA NEL FYLESYSTEM

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

                                                                                           //FINE CODICE OPENFILEDIALOG (FILE DI VERIFICA)


        private void ConfrontaDueTextBlock_Click(object sender, RoutedEventArgs e)         //INIZIO CONFRONTO TRA I DUE FILE
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
                MessageBox.Show("Il File Scaricato è sicuro, non ha subito manomissioni");
                return;
            }
            else
            {
                MessageBox.Show("ATTENZIONE!! Il File Scaricato potrebbe aver subito manomissioni");
                return;
            }
        }                                                                                 //FINE CONFRONTO TRA I DUE FILE

        private void EliminaContenutoTextBlock_Click(object sender, RoutedEventArgs e)    //CODICE DEL BOTTONE CHE ELIMINA TUTTI I FILE IMPORTATI
        {
            TextBlock1.Text = "";
            TextBlock2.Text = "";
            LabelCambio.Content = "Importa i Due File Richiesti";
            GreenLabelSha.Visibility = Visibility.Visible;
            GreenLabelVerifica.Visibility = Visibility.Visible;
            RedLabelSha.Visibility = Visibility.Hidden;
            RedLabelVerifica.Visibility = Visibility.Hidden;
            LabelCambio.Visibility = Visibility.Visible;
            LabelIndicaConfronto.Visibility = Visibility.Hidden;
        }                                                                                 //FINE CODICE DEL BOTTONE CHE ELIMINA TUTTI I FILE IMPORTATI

        private void EliminaSha1_Click(object sender, RoutedEventArgs e)                  //CODICE DEL BOTTONE CHE ELIMINA IL FILE SCARICATO IMPORTATO
        {
            
            GreenLabelSha.Visibility = Visibility.Visible;
            TextBlock1.Text = "";
            RedLabelSha.Visibility = Visibility.Hidden;


        }                                                                                 //FINE CODICE DEL BOTTONE CHE ELIMINA IL FILE SCARICATO IMPORTATO

        private void EliminaSha2_Click(object sender, RoutedEventArgs e)                  //CODICE DEL BOTTONE CHE ELIMINA IL FILE DI VERIFICA IMPORTATO
        {
            
            GreenLabelVerifica.Visibility = Visibility.Visible;
            TextBlock2.Text = "";
            RedLabelVerifica.Visibility = Visibility.Hidden;

        }                                                                                  //FINE CODICE DEL BOTTONE CHE ELIMINA IL FILE DI VERIFICA IMPORTATO

        private void CloseProgram_Click(object sender, RoutedEventArgs e)                  //INIZIO BOTTONE CHE CHIUDE IL PROGRAMMA
        {
            Close();
        }                                                                                  //FINE BOTTONE CHE CHIUDE IL PROGRAMMA

        private void MettiTendinaProgramma_Click(object sender, RoutedEventArgs e)         //INIZIO BOTTONE CHE METTE A TENDINA IL PROGRAMMA
        {
            this.WindowState = WindowState.Minimized;
        }                                                                                  //FINE BOTTONE CHE METTE A TENDINA  IL PROGRAMMA

        private void BottoneAvanti_Click(object sender, RoutedEventArgs e)                //INIZIO BOTTONE CHE FA ANDARE AVANTI LE  ISTRUZIONI PER L'UTENTE
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

                LabelCambio.Visibility = Visibility.Hidden;
                LabelIndicaConfronto.Visibility = Visibility.Visible;
                ConfrontaDueTextBlock.Visibility = Visibility.Visible;

            }

        }                                                                                //FINE BOTTONE CHE FA ANDARE AVANTI LE  ISTRUZIONI PER L'UTENTE

        private void DragWithHeader(object sender, System.Windows.Input.MouseButtonEventArgs e)  //INIZIO CODICE DEL DRAG WINDOW
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
                DragMove();
        }                                                                                         //FINE CODICE DEL DRAG WINDOW
    }
} 
//TERMINE DEL PROGRAMMA




//COPYRIGHT (R) ANIMALI 2022


