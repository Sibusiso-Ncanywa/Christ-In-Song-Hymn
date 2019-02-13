using Dna;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ChristInSong.Core
{
    /// <summary>
    /// View model for a favorite song item
    /// </summary>
    public class EventItemVM : BaseViewModel
    {
        #region Public members

        /// <summary>
        /// The display name of the event item
        /// </summary>
        public string NameOfEvent { get; set; }

        /// <summary>
        /// The number and type of the song
        /// </summary>
        public string FullPathOfPoster { get; set; }

        /// <summary>
        /// True if this Item is currently selected
        /// </summary>
        public bool IsNewEvent { get; set; }

        /// <summary>
        /// Flag indicating that the event was successfully saved
        /// </summary>
        public bool DoneSaving { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Command to view the poster of the current event
        /// </summary>
        public ICommand ViewEventCommand { get; set; }

        /// <summary>
        /// Command to remove the poster of the current event
        /// </summary>
        public ICommand RemoveEventCommand { get; set; }

        #endregion
       
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public EventItemVM()
        {
            ViewEventCommand = new RelayCommand(ViewEventCommandVoidMethod);
            RemoveEventCommand = new RelayCommand(RemoveEventCommandVoidMethod);
        }

        #endregion

        #region Command methods

        /// <summary>
        /// Views the poster
        /// </summary>
        public void ViewEventCommandVoidMethod()
        {
            if (this is null) return;
            //Go to the Events Page
            CoreDi.VM_Application_Dna.GoToViewFullScreenPageVoid(ApplicationPageType.FullscreenView,this);
        }

        /// <summary>
        /// Removes the poster
        /// </summary>
        public void RemoveEventCommandVoidMethod()
        {
            // get the events
            var eventsStored = CoreDi.VM_Application_Dna.SavedEvents;

            // create a new list that doesn't have the event to remove
            ObservableCollection<EventItemVM> itemVMs;

            // populate the new list with the events that will not be removed.
            itemVMs = new ObservableCollection<EventItemVM>(
                eventsStored.Where(TheEventToRemove => !TheEventToRemove.Equals(this)));

            // Remove the event from the list
            GeneralMethods.RemoveEventCached(NameOfEvent, FullPathOfPoster);
         
            // set the new list of the events
            // update the list
            CoreDi.VM_Application_Dna.SavedEvents = itemVMs;

            // inform the user
            CoreDi.VM_Event_Dna.EventAdded();
        }

        #endregion

    }
}
