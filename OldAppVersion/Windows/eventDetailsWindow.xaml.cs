//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Shapes;
//using System.IO;
//using Microsoft.Win32;
//using System.Collections;

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for eventDetailsWindow.xaml
//    /// </summary>
//    public partial class eventDetailsWindow : Window
//    {

//        /// <summary>
//        /// Default constructor
//        /// </summary>
//        public eventDetailsWindow()
//        {
//            InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }

//        /// <summary>
//        /// goes back to the home window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void Homebtn_Click(object sender, RoutedEventArgs e)
//        {
//            HomeChristInSongWindow homeWindow = new HomeChristInSongWindow();
//            this.Hide();
//            homeWindow.Show();
//        }
        
//        /// <summary>
//        /// Adds an evet to the combo box
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void AddEvent_Click(object sender, RoutedEventArgs e)
//        {
//            //if(!GeneralMethods.checkEmptytxtBox(new List<TextBox> { EventName }))
//            //{
//            //    Grid grid = GeneralMethods.AddEvent(EventName.Text, EventPosterNameImgbox.Source,true);

//            //    if(grid.Children.Count > 0)
//            //    {
//            //        ListOfEventsStored.Items.Add(grid);
//            //        ListOfEventsStored.Items.Refresh();
//            //    }

//            //    GeneralMethods.clearTextBoxes(new List<TextBox> { EventName });
//            //    EventPosterNameImgbox.Source = null;
//            //}
//        }

//        /// <summary>
//        /// Look for the file in the local machine
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void EventPosterBtn_Click(object sender, RoutedEventArgs e)
//        {
//            // open the file dialog
//            OpenFileDialog openFile = new OpenFileDialog()
//            {
//                // do not allow multi selection
//                Multiselect = false,
//                // accept only these extensions
//                Filter = "Image | *.png; *.jpg"
//            };

//            // if the dialog window is not show do nothing
//            if (!(bool)openFile.ShowDialog(this)) return;

//            // store the path to the file
//            string filePath = openFile.FileName;
            
//            // display the image to the image in the gui
//            // use the BitmapImage to convert the path to the image
//            // uri to locate the file wanted
//            EventPosterNameImgbox.Source = new BitmapImage(new Uri(filePath));
//        }
        
//        /// <summary>
//        /// View the poster in this window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ViewImage_Click(object sender, RoutedEventArgs e)
//        {
//            // index of the chosen event
//            int index = ListOfEventsStored.SelectedIndex;

//            // if no event chosen 
//            if(index >= 0)
//            {
//                // find the children and return them
//                Image image = findChildren(ListOfEventsStored);
//                // Get the name of the event
//                EventName.Text = (string)image.Tag;
//                // get the event poster
//                if (image.Source != null) EventPosterNameImgbox.Source = image.Source;
//            }
//            else
//            {
//                MessageBox.Show("Please choose an event you want to remove.", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
//            }

//        }
        
//        #region Helper methods

//        /// <summary>
//        /// It finds the children of the listbox.
//        /// </summary>
//        /// <param name="listBox"></param>
//        /// <returns> It returns the poster of the event and attaches the name of event to the Tag of the Image </returns>
//        public Image findChildren(ListBox listBox)
//        {
//            // create local variables
//            BitmapImage defaulImage = null;
//            ImageSource sourceOfImage = defaulImage;
//            string Text = "";
//            int path = listBox.SelectedIndex;

//            // get the combo box item
//            object comboItem = ListOfEventsStored.Items[path];

//            ListBoxItem comboBoxItem;
//            Grid grigInCombite;

//            // get the grid
//            if (comboItem is Grid theGrid)
//            {
//                grigInCombite = theGrid;
//            }
//            else
//            {
//                comboBoxItem = (ListBoxItem)comboItem;
//                grigInCombite = (Grid)comboBoxItem.Content;
//            }
            

//            // get the children of the grid;
//            foreach (object item in grigInCombite.Children)
//            {
//                // if the item is an image 
//                if (item is Image thisImage) sourceOfImage = thisImage.Source;

//                // if an item is a textblock
//                if (item is TextBlock thisText) Text = thisText.Text;
//            }

//            Image myImage = new Image();
//            myImage.Tag = Text;
//            myImage.Source = sourceOfImage;

//            return myImage;
//        }

//        #endregion

//        /// <summary>
//        /// Add the cached files to the listbox
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void EventDetailsWin_Loaded(object sender, RoutedEventArgs e)
//        {
//            //List<Grid> grids = GeneralMethods.LoadCacheEvents();
//            //foreach(Grid item in grids)
//            //{
//            //    ListOfEventsStored.Items.Add(item);
//            //}
//            //ListOfEventsStored.Items.Refresh();
//        }

//        /// <summary>
//        /// Finds the selected even and views it to the view screen
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ListOfEventsStored_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            ViewAsFullScreen.IsEnabled = true;
//            RemoveEvent.IsEnabled = true;
//            ViewImage.IsEnabled = true;
//        }

//        /// <summary>
//        /// view poster fullscreen
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ViewAsFullScreen_Click(object sender, RoutedEventArgs e)
//        {
//            // index of the chosen event
//            int index = ListOfEventsStored.SelectedIndex;

//            // if no event chosen 
//            if (index >= 0)
//            {
//                // find the children and return them
//                Image image = findChildren(ListOfEventsStored);

//                viewEventFullscreen viewEvent = new viewEventFullscreen();
//                viewEvent.viewPoster.Source = image.Source;
//                this.Hide();
//                viewEvent.Show();
//            }
//            else
//            {
//                MessageBox.Show("Please choose an event you want to view.", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
//            }
//        }

//        /// <summary>
//        /// Remove the selected event
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void RemoveEvent_Click(object sender, RoutedEventArgs e)
//        {
//            // index of the chosen event
//            int index = ListOfEventsStored.SelectedIndex;

//            // if no event chosen 
//            if (index >= 0)
//            {
//                // find the children and return them
//                Image image = findChildren(ListOfEventsStored);

//                // find the index of the image to remove
//                int indx = ListOfEventsStored.SelectedIndex;

//                // remove from the list box
//                ListOfEventsStored.Items.RemoveAt(indx);

//                // removes the image
//                //GeneralMethods.RemoveEventCached(image);

//                // refreshes the listbox
//                ListOfEventsStored.Items.Refresh();
//            }
//            else
//            {
//                MessageBox.Show("Please choose an event you want to remove.", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
//            }
//        }
//    }
//}
