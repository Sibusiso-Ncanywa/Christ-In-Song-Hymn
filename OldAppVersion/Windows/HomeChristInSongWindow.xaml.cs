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

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for HomeWindow.xaml
//    /// </summary>
//    public partial class HomeChristInSongWindow : Window
//    {
//        // Global Variable
//        //public List<SongClass> FavoriteSongs;

//        /// <summary>
//        /// Default Constructor
//        /// </summary>
//        public HomeChristInSongWindow()
//        {
//            InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }


//        #region Check for errors

//        /// <summary>
//        /// check if the number entered is valid
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void SongToBeSungTxtBox_TextChanged(object sender, TextChangedEventArgs e)
//        {
//            // call the check amount function
//            //GeneralMethods.checkAmountTyped(sender);
//        }

//        #endregion

//        #region Loading Elements

//        /// <summary>
//        /// First time loading the window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void HomeWin_Loaded(object sender, RoutedEventArgs e)
//        {
//            //// 0. load the songs
//            //// 1. Check if the songs were added
//            //// 2. Update the listbox
//            //FavoriteSongs = GeneralMethods.FavoriteSongList();
            
//            //// update the listbox with the favorite song list
//            //listOfFavorites = GeneralMethods.updateListBox(FavoriteSongs,listOfFavorites);
//        }

//        #endregion

//        #region Window Changes

//        /// <summary>
//        /// Goes to the choose a song window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void SelectSongBtn_Click(object sender, RoutedEventArgs e)
//        {
//            // cut the sender object to a button
//            Button buttonClicked = (Button)sender;

//            //check if the textbox is empty
//            //if(!GeneralMethods.checkEmptytxtBox(new List<TextBox> { selected }))
//            //{
//            //    try
//            //    {
//            //        // create an instance of the new window
//            //        chooseAsong_window chooseAsong_ = new chooseAsong_window();

//            //        // create the song
//            //        SongClass song = null;

//            //        // check which button was pressed
//            //        if ( "AdventHymn" == (string)buttonClicked.Tag)
//            //        {
//            //            // if advent hymn
//            //            song = GeneralMethods.FindSong(selected.Text,false);
//            //        }
//            //        else
//            //        {
//            //            // if Christ in song
//            //            song = GeneralMethods.FindSong(selected.Text,true);
//            //        }
//            //        // Assing the song to the song class in the choose song window
//            //        chooseAsong_.Selectedsong = song;

//            //        // hide this window
//            //        this.Hide();
//            //        // show the choose song window
//            //        chooseAsong_.Show();
//            //    }
//            //    catch(Exception ex)
//            //    {
//            //        // if the song was not found
//            //        MessageBox.Show(ex.Message, "Song Not Found, Sorry!", MessageBoxButton.OK, MessageBoxImage.Error);
//            //    }
//            //    // clear the text box
//            //    GeneralMethods.clearTextBoxes(new List<TextBox> { selected });
//        }
        

//        /// <summary>
//        /// Goes to the Doxology Window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GoToDoxology_Click(object sender, RoutedEventArgs e)
//        {

//            //// goes to the doxology window and then closes the current window
//            //DoxologyWindow doxology = new DoxologyWindow();
//            //this.Hide();
//            //doxology.Show();
            
//        }

//        /// <summary>
//        /// Goes to the Announcements window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GoToAnnouncements_Click(object sender, RoutedEventArgs e)
//        {
            
//            //// goes to the announcement window and closes the current window
//            //Announcements anou = new Announcements();
//            //this.Hide();
//            //anou.Show();
            
//        }

//        /// <summary>
//        /// Goes to the Event Window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GoToEvents_Click(object sender, RoutedEventArgs e)
//        {
//            //// goes to the event details window and close the current window
//            //eventDetailsWindow eventDetails = new eventDetailsWindow();
//            //this.Hide();
//            //eventDetails.Show();
            
//        }

//        /// <summary>
//        /// choose a song fom the favorites
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ListOfFavorites_SelectionChanged(object sender, SelectionChangedEventArgs e)
//        {
//            // split the chosen item
//            string[] songChosen = (listOfFavorites.SelectedItem.ToString()).Split('|');
            
//            // get song num
//            string songNum = songChosen[0].Trim();

//            // change the text value of the index
//            selected.Text = songNum;

//            //Attach to the tag of the new button the type of the song.
//            Button senderButton = new Button();
//            senderButton.Tag = songChosen[1].Trim();

//            // call the method to choose the song
//            SelectSongBtn_Click(senderButton, null);
//        }
        
//        #endregion

//        /// <summary>
//        /// Adds a song to the favorite list box
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void AddToFavorites_Click(object sender, RoutedEventArgs e)
//        {
//            //check if the textbox is empty
//            //if (!GeneralMethods.checkEmptytxtBox(new List<TextBox> { selected }))
//            //{
//            //    try
//            //    {
//            //        SongClass song = null;
//            //        int answer = (int)MessageBox.Show("Do you want to add the hymn from Christ in song?", 
//            //            "Attention", MessageBoxButton.YesNo, MessageBoxImage.Question,MessageBoxResult.Yes);

//            //        // if it's not yes
//            //        if(answer != 6)
//            //        {
//            //            // use the advent hymn
//            //            song = GeneralMethods.FindSong(selected.Text, false);
//            //            song.ChristInSong = SongType.AdventHymn;
//            //        }
//            //        else
//            //        {
//            //            // By default use Christ in song
//            //            song = GeneralMethods.FindSong(selected.Text, true);
//            //            song.ChristInSong = SongType.ChristInSong;
//            //        }
                    
//            //        // check if the song is not already in the list
//            //        if (!FavoriteSongs.Contains(song))
//            //        {
//            //            // add the song 
//            //            FavoriteSongs.Add(song);

//            //            // write it to the fav list cache
//            //            GeneralMethods.FavSongListCache(FavoriteSongs);

//            //            // update the listbox
//            //            GeneralMethods.updateListBox(FavoriteSongs, listOfFavorites);
//            //        }
//            //        else
//            //        {
//            //            MessageBox.Show("The song is already a favorite.", "Attention", MessageBoxButton.OK, MessageBoxImage.Information);
//            //        }
//            //    }
//            //    catch (Exception ex)
//            //    {
//            //        MessageBox.Show(ex.Message, "Song Not Found, Sorry!", MessageBoxButton.OK, MessageBoxImage.Error);
//            //    }
//            //    GeneralMethods.clearTextBoxes(new List<TextBox> { selected });
//            //}
//        }

//        /// <summary>
//        /// before closing the window, save the fav list first
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void HomeWin_Closing(object sender, System.ComponentModel.CancelEventArgs e)
//        {
//            //if(FavoriteSongs.Count() > 0)
//            //{
//            //    GeneralMethods.closeAndSave(FavoriteSongs);
//            //}
//        }
//    }
//}
