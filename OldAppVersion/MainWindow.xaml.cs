//using System;
//using System.Windows;
//using System.Windows.Input;
//using System.Windows.Threading;

//namespace Christ_in_song
//{
//    /// <summary>
//    /// Interaction logic for MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        // this is used to time the number of seconds the windows will be dipsplayed
//        DispatcherTimer theLoadingTime;

//        /// <summary>
//        /// Default constructor
//        /// </summary>
//        public MainWindow()
//        {
//            InitializeComponent();

//            // time to help load the program fully
//            //this.DataContext = new WindowViewModel(this);
//            theLoadingTime = new DispatcherTimer();
//            theLoadingTime.Interval = TimeSpan.FromSeconds(5);
//            theLoadingTime.IsEnabled = true;
//            theLoadingTime.Tick += TheLoadingTime_Tick;
//        }

//        /// <summary>
//        /// It helps load the program fully
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void TheLoadingTime_Tick(object sender, EventArgs e)
//        {
//            // show this text to the user
//            // and stop the time
//            pressAnyKey.Text = "Press any key to continue.";
//            theLoadingTime.IsEnabled = false;
//        }

//        /// <summary>
//        /// Goes to the Home Christ In song window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void Button_Click(object sender, RoutedEventArgs e)
//        {
//            HomeChristInSongWindow songWindow = new HomeChristInSongWindow();
//            this.Hide();
//            songWindow.Show();
//        }

//        /// <summary>
//        /// Goes to the contact developer window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void ContactDev(object sender, RoutedEventArgs e)
//        {
//            ContactDeveloper contactDeveloper = new ContactDeveloper();
//            this.Hide();
//            contactDeveloper.Show();
//        }

//        /// <summary>
//        /// Press any key to go to the next window
//        /// </summary>
//        /// <param name="sender"></param>
//        /// <param name="e"></param>
//        private void LoadingWindow_KeyDown(object sender, KeyEventArgs e)
//        {
//            // clear the text and close the window
//            pressAnyKey.Text = "";
//            HomeChristInSongWindow homeChristInSong = new HomeChristInSongWindow();
//            this.Hide();
//            homeChristInSong.Show();
//        }
//    }
//}
