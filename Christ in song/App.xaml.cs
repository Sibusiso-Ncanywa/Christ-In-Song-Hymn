using ChristInSong.Core;
using System.Windows;
using Dna;
using static Dna.FrameworkDI;

namespace Christ_in_song
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // let the base application do what it need to do
            base.OnStartup(e);
            
            // Set up the application
            ApplicationSetUp();

            // DELETE FILES THAT SHOULD BE DELETED
            GeneralMethods.DeleteThePosters();

            // Show the main window
            Current.MainWindow = new TheHomeWindow();
            Current.MainWindow.Show();
        }

        /// <summary>
        /// Configures the application ready for use.
        /// </summary>
        private void ApplicationSetUp()
        {
            // Construct the application using the DNA dependency injection tool.
            Framework.Construct<DefaultFrameworkConstruction>()
                .AddDefaultLogger()
                .AddCsIViewModels()
                .AddCsIClientServices()
                .Build();

            // Log That the application is starting
           // Logger.LogDebugSource("Application is Starting...");
           
        }
    }
}
