using LizHackMethods.Enums;
using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// The view model for a welcome page window
    /// </summary>
    public class EventViewModel : BaseViewModel
    {
        #region Public members

        /// <summary>
        /// The name of the event
        /// </summary>
        public string EventName { get; set; }

        /// <summary>
        /// Has the full path of the poster
        /// </summary>
        public string FullPathToPoster { get; set; }

        /// <summary>
        /// Flag indicating poster has been found
        /// </summary>
        public bool FoundThePoster { get; set; }

        /// <summary>
        /// Flag indicating that the event was successfully saved
        /// </summary>
        public bool DoneSaving { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Gets the image from the openfile dialog and saves the path to the Poster.
        /// </summary>
        public ICommand LookForPoster { get; set; }

        /// <summary>
        /// Adds an event to the list of events and also to the event cache file
        /// </summary>
        public ICommand AddTheEvent { get; set; }
        
        /// <summary>
        /// Goes to the home page
        /// </summary>
        public ICommand GoToHomePage { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default contructor
        /// </summary>
        public EventViewModel()
        {
            // generate the methods
            GenerateCommands();
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Go to the home page
        /// </summary>
        /// <returns></returns>
        private void GoToHomePageNow()
        {
            //Go to the home Page
            CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);
            
        }

        /// <summary>
        /// Add event to event list
        /// </summary>
        /// <returns></returns>
        private void AddThisEvent()
        {
            // check if the values are not null
            if (string.IsNullOrEmpty(EventName) || string.IsNullOrEmpty(FullPathToPoster))
            {
                // if one of the conditions are true,then...
                if (string.IsNullOrEmpty(EventName))
                {
                    GUI_RelatedMethodsCore.InformTheUser("Please type in the name of the event.");
                }
                else if(string.IsNullOrEmpty(FullPathToPoster))
                {
                    GUI_RelatedMethodsCore.InformTheUser("Please select the poster of the event.");
                }

                // do nothing
                return;
            }

            // save locally first
            // save the current event in the cache file
            if(!GeneralMethods.SaveEventDetails(EventName, FullPathToPoster))
            {
                GUI_RelatedMethodsCore.InformTheUser("The poster is already in use, please use a different poster.");
                return;
            }
            
            // add the current event
            var eventToSave = new EventItemVM
            {
                NameOfEvent = EventName,
                FullPathOfPoster = FullPathToPoster,
                IsNewEvent = true
            };

            // add the event
            CoreDi.VM_Application_Dna.SavedEvents.Insert(0, eventToSave);

            // done working
            EventAdded();
        }

        /// <summary>
        /// informs the user 
        /// </summary>
        public async void EventAdded()
        {
            // used to show the instructions menu
            DoneSaving = true;

            // wait for 1 millisecond
            await Task.Delay(TimeSpan.FromSeconds(5));

            // reset is loading to false
            DoneSaving = false;
        }

        /// <summary>
        /// Look for the poster
        /// </summary>
        /// <returns></returns>
        public void LookForThisPoster()
        {
            // get the event poster
            var fileDetails = GUI_RelatedMethodsCore.GetTheFile(FileFilters.Picture);
            EventName = fileDetails[0];
            FullPathToPoster = fileDetails[1];

            // check if the event poster was selected
            if(string.IsNullOrEmpty(EventName) || string.IsNullOrEmpty(FullPathToPoster))
            {
                GUI_RelatedMethodsCore.InformTheUser("No poster was selected.");
                return;
            }

            // if it was show the image
            FoundThePoster = true;
        }

        #endregion

        #region Helper methods

        /// <summary>
        /// Fires off the property changed event
        /// </summary>
        private void ChangedTheProperty()
        {
            OnPropertyChanged(nameof(EventName));
            OnPropertyChanged(nameof(FullPathToPoster));

        }

        /// <summary>
        /// Generates commands used by this view model
        /// </summary>
        private void GenerateCommands()
        {
            LookForPoster = new RelayCommand(LookForThisPoster);
            AddTheEvent = new RelayCommand(AddThisEvent);
            GoToHomePage = new RelayCommand(GoToHomePageNow);
        }
        
        #endregion

    }
}
