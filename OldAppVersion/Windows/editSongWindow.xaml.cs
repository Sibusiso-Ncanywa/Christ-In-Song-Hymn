//using System.Collections.Generic;
//using System.Windows;
//using System.Windows.Controls;

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for editSongWindow.xaml
//    /// </summary>
//    public partial class editSongWindow : Window
//    {
//        // song to edit
//        //public SongClass songToEdit;

//        /// <summary>
//        /// constructor
//        /// </summary>
//        /// <param name="songToEdit"> song to edit </param>
//        public editSongWindow()
//        {
//            InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }
        
//        /// <summary>
//        /// Goes back to the choose song window.
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GoToChooseSong_Click(object sender, RoutedEventArgs e)
//        {
//            // check if the textblocks are not empty!
//            //if(!GeneralMethods.checkEmptytxtBox(new List<TextBox> { editsongLyricsTextBox }))
//            //{
//            //    // etract the data from the textbox and window
//            //    // save it to the songClass
//            //    // show the choose a song window
//            //    // close this window
//            //    chooseAsong_window chooseAsong = new chooseAsong_window();
//            //    chooseAsong.Selectedsong = songToEdit;
//            //    this.Hide();
//            //    chooseAsong.Show();
                
//            //}
//            //else
//            //{
//            //    // show this error if all fails
//            //    MessageBox.Show("Eish San! The song is gone. Sorry!", "Error", MessageBoxButton.OK,MessageBoxImage.Error);
//            //}
//        }

//        /// <summary>
//        /// when loaded it display the content straight away
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void EditSongWin_Loaded(object sender, RoutedEventArgs e)
//        {
//            // get the name key and number of the song
//            //List<string> tempSong = songToEdit.getNameKeyNumber();
            
//            //// display the comtent of the song
//            //editSongName.Text = tempSong[0];
//            //editDisplayKey.Text = tempSong[1];
//            //editSongNumber.Text = tempSong[2];
            
//            //// display the lyric of the song
//            //editsongLyricsTextBox.Text = songToEdit.ToString();

//            //MessageBox.Show("You are allowed to change the lyrics and the key of the song.", "Need to know", MessageBoxButton.OK, MessageBoxImage.Information);
//        }

//        /// <summary>
//        /// Saves the song
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void SaveSongbtn_Click(object sender, RoutedEventArgs e)
//        {
//            //if(!GeneralMethods.checkEmptytxtBox(new List<TextBox> { editsongLyricsTextBox, editDisplayKey }))
//            //{
//            //    // check if the is not 
//            //    if (editDisplayKey.Text.ToLower() != "unknown" || editDisplayKey.Text.ToLower() != "to be added")
//            //        songToEdit.NewKey(editDisplayKey.Text);

//            //    // check if the hymn is a Christ in song hymn
//            //    int answer = (int)MessageBox.Show("Is this Hymn a Christ in song Hymn?", "Attention", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);

//            //    string hymnNum = songToEdit.getSongNumber();
//            //    string HymnLyrics = editsongLyricsTextBox.Text;

//            //    if (answer != 6)
//            //    {
//            //        // if the hymn is not a Christ in song hymn
//            //        AdventHymnMethods.UpdateAdventSongLyrics(hymnNum, HymnLyrics);
//            //        songToEdit.changeLyrics(HymnLyrics);
//            //    }
//            //    else
//            //    {
//            //        // save the lyrics in Christ in song cache file
//            //        FindTheDetails.UpdateSongLyrics(hymnNum, HymnLyrics);
//            //        songToEdit.changeLyrics(HymnLyrics);
//            //    }

//            //    // show when done
//            //    MessageBox.Show("Song saved", "Done!", MessageBoxButton.OK, MessageBoxImage.Information);
//            //}
//            //else
//            //{
//            //    MessageBox.Show("Please make sure the lyrics are there and then save again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
//            //}
                
//        }

//        /// <summary>
//        /// Goes back t the home sreen
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GotoHomeScreen_Click(object sender, RoutedEventArgs e)
//        {
//            HomeChristInSongWindow homeChristInSongWindow = new HomeChristInSongWindow();
//            this.Hide();
//            homeChristInSongWindow.Show();
            
//        }

//        /// <summary>
//        /// Remove the cache and show saved lyrics
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void RecoverSongbtn_Click(object sender, RoutedEventArgs e)
//        {
//        //    if (!GeneralMethods.checkEmptytxtBox(new List<TextBox> { editsongLyricsTextBox, editDisplayKey }))
//        //    {
//        //        // check if the hymn is a Christ in song hymn
//        //        int answer = (int)MessageBox.Show("Is this Hymn a Christ in song Hymn?", "Attention", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);

//        //        string hymnNum = songToEdit.getSongNumber();

//        //        // change the content of the textbox to empty
//        //        editsongLyricsTextBox.Text = "";

//        //        if (answer != 6)
//        //        {
//        //            // if the hymn is not a Christ in song hymn
//        //            editsongLyricsTextBox.Text = AdventHymnMethods.RemoveAdventSongCache(hymnNum);
//        //        }
//        //        else
//        //        {
//        //            // save the lyrics in Christ in song cache file
//        //            editsongLyricsTextBox.Text = FindTheDetails.RemoveChristInSongCache(songToEdit.getSongNumber());
//        //        }

//        //        // show when done
//        //        MessageBox.Show("Song saved", "Done!", MessageBoxButton.OK, MessageBoxImage.Information);
//        //    }
//        //    else
//        //    {
//        //        MessageBox.Show("Please make sure the lyrics are there and then save again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
//        //    }
//        }
//    }
//}
