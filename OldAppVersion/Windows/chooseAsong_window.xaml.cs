//using System;
//using System.Collections.Generic;
//using System.Windows;

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for chooseAsong_window.xaml
//    /// </summary>
//    public partial class chooseAsong_window : Window
//    {
//        // create an instance of the song class
//        //public SongClass Selectedsong;

//        /// <summary>
//        /// Constructor of the choose song window
//        /// </summary>
//        /// <param name="Selectedsong"> chosen song </param>
//        public chooseAsong_window()
//        {
//            InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }

//        /// <summary>
//        /// Load the choose a song window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ChooseAsongWin_Loaded(object sender, RoutedEventArgs e)
//        {
//            //// get the info of the song before dispplaying it
//            //List<string> sondToShow = Selectedsong.getNameKeyNumber();
//            //songName.Text = sondToShow[0];
//            //DisplayKey.Text = sondToShow[1];
//            //songNumber.Text = sondToShow[2];
            
//            //// lyrics to be displayed here
//            //songLyricsTextBlock.Text = Selectedsong.ToString();
//        }

//        /// <summary>
//        /// Edit a song. Goes to the edit song window.
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void EditSongbtn_Click(object sender, RoutedEventArgs e)
//        {
//            // check if the textboxex are not empty
//            if(!string.IsNullOrEmpty(songLyricsTextBlock.Text) && 
//                !string.IsNullOrEmpty(DisplayKey.Text) && !string.IsNullOrEmpty(songNumber.Text) &&
//                !string.IsNullOrEmpty(songName.Text))
//            {
//                // create an instance of the edit song window
//                //editSongWindow editSongNow = new editSongWindow();

//                //// pass the song to be edited
//                //editSongNow.songToEdit = Selectedsong;

//                //// hide the current window
//                //this.Hide();

//                //// show the edit song window
//                //editSongNow.Show();
                
//            }
//        }

//        /// <summary>
//        /// Goes to the home screen, which is the Christ in song window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void GoToHome_Click(object sender, RoutedEventArgs e)
//        {
//            HomeChristInSongWindow homeChristIn = new HomeChristInSongWindow();
//            this.Hide();
//            homeChristIn.Show();
            
//        }
//    }
//}
