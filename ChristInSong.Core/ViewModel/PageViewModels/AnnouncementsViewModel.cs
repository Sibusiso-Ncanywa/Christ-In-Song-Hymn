using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The view model for a welcome page window
    /// </summary>
    public class AnnouncementsViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// Flag to indicate if ready for execution
        /// </summary>
        public bool GetDocIsRunning { get; set; }

        #endregion

        #region Public members

        /// <summary>
        /// The file name of the document
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Full path to the file
        /// </summary>
        public string PathToDoc { get; set; }
        
        #endregion

        #region Commands

        /// <summary>
        /// Go to the Developer page
        /// </summary>
        public ICommand GoHome { get; set; }

        /// <summary>
        /// Go to the Display song page
        /// </summary>
        public ICommand LookForDoc { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public AnnouncementsViewModel()
        {
            // get the file from the cache folder
            var fileDetails = GeneralMethods.ViewTempFile();

            // view the file
            FileName = fileDetails[0];
            PathToDoc = fileDetails[1];

            // Generate the commands
            GenerateCommands();
        }
        
        #endregion

        #region Command Methods

        /// <summary>
        /// Look for the document and view it
        /// </summary>
        /// <returns></returns>
        private async Task LookForDocAsync()
        {
            await RunCommandAsync(() => GetDocIsRunning, async () =>
            {
                 // Look file name and the path
                 var TheFileNameAndPath = GUI_RelatedMethodsCore.GetTheFile(LizHackMethods.Enums.FileFilters.Document);

                 // If File was not found do nothing
                 if (TheFileNameAndPath.Length < 0) return;

                 // Change the properties
                 FileName = TheFileNameAndPath[0];
                 PathToDoc = TheFileNameAndPath[1];

                 // Fire  the property changed event
                 ChangedTheProperty();
                 
                 // wait for 2 second
                 await Task.Delay(TimeSpan.FromSeconds(2));

            });

        }

        /// <summary>
        /// Go to the home page
        /// </summary>
        /// <returns></returns>
        private async Task GoHomeAsync()
        {
            //Go to the Home Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);

            // wait for one milisecond and continue
            await Task.Delay(1);
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Fires off the property changed event to inform the GUI that we have changed the propeties
        /// </summary>
        private void ChangedTheProperty()
        {
            OnPropertyChanged(nameof(FileName));
            OnPropertyChanged(nameof(PathToDoc));
        }

        /// <summary>
        /// Generates commands for the view model
        /// </summary>
        private void GenerateCommands()
        {
            GoHome = new RelayCommand(async () => await GoHomeAsync());
            LookForDoc = new RelayCommand(async () => await LookForDocAsync());
        }

        #endregion

    }
}
