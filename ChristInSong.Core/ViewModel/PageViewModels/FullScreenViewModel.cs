using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    public class FullScreenViewModel : BaseViewModel
    {
        #region private members

        /// <summary>
        /// Flag for showing or hiding
        /// </summary>
        protected bool mMIndicator = true;

        protected string mImagePath;

        #endregion

        #region Public Properties

        /// <summary>
        /// The name/title of the song
        /// </summary>
        public string FullScreenNameOfTheEvent { get; set; }

        /// <summary>
        /// The key signature of the song
        /// </summary>
        public string FullScreenFullPathToPoster { get; set; }

        /// <summary>
        /// Flag used to show or hide buttons
        /// </summary>
        public bool ShowButtons
        {
            get => mMIndicator;
            set => mMIndicator = value;
        }

        /// <summary>
        /// Flag used to show instructions
        /// </summary>
        public bool IsLoading { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Goes to the edit song page
        /// </summary>
        public ICommand HideShowButtons { get; set; }
        
        /// <summary>
        /// Goes to the edit song page
        /// </summary>
        public ICommand GoToEventPage { get; set; }

        /// <summary>
        /// Goes to the home page
        /// </summary>
        public ICommand GoToHome { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public FullScreenViewModel()
        {
            // get the favourite songlist from the cache file
            // This task waits for ten seconds before showing the message
            Task.Run(async () =>
            {
                // instead use this:
                var EventToView = CoreDi.VM_Application_Dna.GetFullScreenEvent();

                // if the event to view is null go back to the events page
                if(EventToView is null)
                {
                    CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Events);

                    GUI_RelatedMethodsCore.InformTheUser("The poster could not be shown.");
                }

                // get event details
                FullScreenNameOfTheEvent = EventToView.NameOfEvent;
                FullScreenFullPathToPoster = EventToView.FullPathOfPoster;

                // fire off the property changed event
                ChangedTheProperty();
                
                // used to show the instructions menu
                IsLoading = true;

                // wait for 1 milisecond
                await Task.Delay(TimeSpan.FromSeconds(10));

                // reset is loading to false
                IsLoading = false;
            });
            

            //  generate methods
            GenerateCommands();
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Goes to the edit song page
        /// </summary>
        /// <returns></returns>
        public void GoToEventPageVoidMethod()
        {
            //Go to the Edit song Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Events);
        }
        
        /// <summary>
        /// Hides/show buttons
        /// </summary>
        /// <returns></returns>
        public void HideShowButtonsVoidMethod()
        {
            ShowButtons ^= true;
        }

        /// <summary>
        /// Goes to the home page
        /// </summary>
        /// <returns></returns>
        public void GoToHomeVoidMethod()
        {
            //Go to the Home Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);
        }

        #endregion

        #region Helper methods


        /// <summary>
        /// Fires off the property changed event
        /// </summary>
        private void ChangedTheProperty()
        {
            OnPropertyChanged(nameof(FullScreenFullPathToPoster));
            OnPropertyChanged(nameof(FullScreenNameOfTheEvent));
            OnPropertyChanged(nameof(ShowButtons));
            OnPropertyChanged(nameof(IsLoading));
        }

        /// <summary>
        /// generates the commands of this view model
        /// </summary>
        private void GenerateCommands()
        {
            GoToHome = new RelayCommand(GoToHomeVoidMethod);
            HideShowButtons = new RelayCommand(HideShowButtonsVoidMethod);
            GoToEventPage = new RelayCommand(GoToEventPageVoidMethod);
        }

        #endregion

    }
}
