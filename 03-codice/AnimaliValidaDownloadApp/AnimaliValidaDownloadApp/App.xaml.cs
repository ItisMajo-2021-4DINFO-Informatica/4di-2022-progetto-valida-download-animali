using System;
using System.Diagnostics;
using System.Threading;
using System.Windows;

namespace AnimaliValidaDownloadApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const int MINIMUM_SPLASH_TIME = 3500; // Miliseconds
        private const int SPLASH_FADE_TIME = 300;     // Miliseconds

        protected override void OnStartup(StartupEventArgs e)
        {
            // Step 1 - Load the splash screen
            SplashScreen splash = new SplashScreen("splash.jpg");
            splash.Show(false, true);

            // Step 2 - Start a stop watch
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Step 3 - Load your windows but don't show it yet
            base.OnStartup(e);
            MainWindow main = new MainWindow();

            // Step 4 - Make sure that the splash screen lasts at least two seconds
            timer.Stop();
            int remainingTimeToShowSplash = MINIMUM_SPLASH_TIME - (int)timer.ElapsedMilliseconds;
            if (remainingTimeToShowSplash > 0)
                Thread.Sleep(remainingTimeToShowSplash);

            // Step 5 - show the page
            splash.Close(TimeSpan.FromMilliseconds(SPLASH_FADE_TIME));
            main.Show();
        }
    }
}

//COPYRIGHT (R) ANIMALI 2022