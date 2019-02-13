using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The view model for a welcome page window
    /// </summary>
    public class WelcomeViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// message to be shown
        /// </summary>
        private readonly string mGoToHome = "Home";

        /// <summary>
        /// Contents to show.
        /// </summary>
        private static string MDeveloper = "Developer's Details";

        /// <summary>
        /// Feedback message
        /// </summary>
        public readonly string mFeedBack = $"Please don't forget to give your feedback on the application. " +
                                                         $"Constructive criticism would be appreciated. " +
                                                         $"Click '{MDeveloper}' to get hold of the developer's contacts details";

        /// <summary>
        /// The welcome note
        /// </summary>
        public readonly string mWelcomeNote = "Welcome! \nPlease enjoy the singing.";

        /// <summary>
        /// The developers name
        /// </summary>
        public readonly string mDevelopersName = "Developed by Sibusiso 'LizHack' Ncanywa";

        #endregion

        #region Public members

        /// <summary>
        /// The name of the developer
        /// </summary>
        public string Developer { get; set; }

        /// <summary>
        /// The property that holds the message
        /// </summary>
        public string HomeButtonContent { get; set; }

        /// <summary>
        /// The info to show
        /// </summary>
        public string TheDevPageInfo { get; set; }

        /// <summary>
        /// Message for the user
        /// </summary>
        public string MessageToUser { get; set; }

        /// <summary>
        /// Welcome message to the user
        /// </summary>
        public string WelcomeMessage { get; set; }

        /// <summary>
        /// Feedback message to the user
        /// </summary>
        public string FeedBackMessage { get; set; }

        /// <summary>
        /// The verse of the day.
        /// </summary>
        public string VerseOfTheDay { get; set; }

        /// <summary>
        /// Sets the default setting
        /// </summary>
        public bool IsItDefault { get; set; } = false;

        #endregion

        #region Public singleton

        /// <summary>
        /// Pop up menu
        /// </summary>
        public static WelcomePopupViewModel MessagesPopup = new WelcomePopupViewModel();
        
        #endregion

        #region Commands

        /// <summary>
        /// Go to the next page
        /// </summary>
        public ICommand GoToHomePage { get; set; }

        /// <summary>
        /// Go to the Developer page
        /// </summary>
        public ICommand GoToDevDetails { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public WelcomeViewModel()
        {
            // update the properties
            Developer = mDevelopersName;
            WelcomeMessage = mWelcomeNote;
            FeedBackMessage = mFeedBack;

            // This task waits for ten seconds before showing the message
            Task.Run(async () =>
            {
                // wait for ten second
                await Task.Delay(TimeSpan.FromSeconds(10));

                // change the property
                HomeButtonContent = mGoToHome;
                TheDevPageInfo = MDeveloper;
                IsItDefault = true;

                // fire  the property changed event
                ChangedTheProperty();

            });

            // create the commands
            GoToHomePage = new RelayCommand(async () => await GoToHomePageAsync());
            GoToDevDetails = new RelayCommand(async () => await GoToDevPageAsync());
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Goes to the next page in the application
        /// </summary>
        private async Task GoToHomePageAsync()
        {
            //Go to the Home Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }

        /// <summary>
        /// Goes to the developer info page
        /// </summary>
        private async Task GoToDevPageAsync()
        {
            //To-do, go to the DevPage
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.DeveloperInfo);

            // wait for one millisecond and continue
            await Task.Delay(1);
        }
        
        #endregion

        #region Helper methods

        /// <summary>
        /// Fires off the property changed event
        /// </summary>
        private void ChangedTheProperty()
        {
            OnPropertyChanged(nameof(Developer));
            OnPropertyChanged(nameof(WelcomeMessage));
            OnPropertyChanged(nameof(FeedBackMessage));
            OnPropertyChanged(nameof(HomeButtonContent));
            OnPropertyChanged(nameof(TheDevPageInfo));
            OnPropertyChanged(nameof(IsItDefault));
        }


        #endregion

    }
}
