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
//    /// Interaction logic for DoxologyWindow.xaml
//    /// </summary>
//    public partial class DoxologyWindow : Window
//    {
//        public DoxologyWindow()
//        {
//            InitializeComponent();
//            //this.DataContext = new WindowViewModel(this);
//        }

//        /// <summary>
//        /// It goes back to the home window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void Homebtn_Click(object sender, RoutedEventArgs e)
//        {
//            HomeChristInSongWindow homeChristIn = new HomeChristInSongWindow();
//            homeChristIn.Show();
//            this.Hide();
//        }

//        /// <summary>
//        /// Load the doxology
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void DoxologyWin_Loaded(object sender, RoutedEventArgs e)
//        {
//           // editsongLyricsTextBlock.Text = TheSongList.Doxology.getLyrics();
//        }
//    }
//}
