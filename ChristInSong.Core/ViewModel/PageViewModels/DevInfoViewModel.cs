using System.Threading.Tasks;
using System.Windows.Input;

namespace ChristInSong.Core
{
       /// <summary>
       /// The view model for a welcome page window
       /// </summary>
       public class DevInfoViewModel : BaseViewModel
       {
              #region private members

              /// <summary>
              /// Developers info
              /// </summary>
              private readonly string mDevelopersDetails = $"I'm Sibusiso Ncanywa, but I prefer LizHack. LizHack is a combination of my second name 'Lizalise' and my 'sort-of' passion for hacking." +
                                                                     $"\n" +
                                                                     $"I enjoy GOOD music hence the development of this application. " +
                                                                     $"My current favorite songs in Christ In Song is number 47 and number 152. " +
                                                                     $"Sing me these songs and you'll make my day." +
                                                                     $"\n" +
                                                                     $"\n" +
                                                                     $"Academics @Rhodes University..." +
                                                                     $"In 2019 I will be doing my academic third year in Computer Science and Music Theory And Analysis. I know it's a rare combinantion but I like it.";
             
              /// <summary>
              /// The developers message
              /// </summary>
              private readonly string mDevelopersMessage = "If you like this version please give feedback so that I can make more and nicer applications.";

              /// <summary>
              /// The  header text
              /// </summary>
              private readonly string mAboutHeader = "About the developer.";

              #endregion

              #region Public members

              /// <summary>
              /// The info to show
              /// </summary>
              public string DevelopersBackgroundInfo { get; private set; }
              
              /// <summary>
              /// The message from the developer.
              /// </summary>
              public string DevelopersMessage { get; private set; }

              /// <summary>
              /// About the developer header text
              /// </summary>
              public string AboutTheDeveloper { get; private set; }

              public string DeveloperImage { get; private set; } = "DeveloperImage";
              #region Contact info

              /// <summary>
              /// Facebook Info
              /// </summary>
              public string Facebook { get; set; } = "LizHack SA";
              public string TheFacebook { get; private set; } = "Facebook";

              /// <summary>
              /// Twitter Info
              /// </summary>
              public string Twitter { get; set; } = "Lizalise_sbudar";
              public string TheTwitter { get; private set; } = "Twitter";

              /// <summary>
              /// Instagrm Info
              /// </summary>
              public string Instagrm { get; set; } = "Lizalise_sbudar";
              public string TheInstagram { get; private set; } = "Instagram";

              /// <summary>
              /// Email Info
              /// </summary>
              public string Email { get; set; } = "Lizhacksa@gmail.com";
              public string TheEmail { get; private set; } = "Gmail";
              #endregion

              #endregion

              #region Commands

              /// <summary>
              /// Go to the next page
              /// </summary>
              public ICommand GoToHomePage { get; set; }
              
              #endregion

              #region constructor

              /// <summary>
              /// Default contructor
              /// </summary>
              public DevInfoViewModel()
              {
                     // change the property
                     DevelopersBackgroundInfo = mDevelopersDetails;
                     DevelopersMessage = mDevelopersMessage;
                     AboutTheDeveloper = mAboutHeader;

                     // fire  the proprty changed event
                     ChangedTheProperty();
                     
                     // create the commands
                     GoToHomePage = new RelayCommand(async () => await GoToHomePageAsync());
              }

              #endregion

              #region Helper methods

              /// <summary>
              /// Fires off the property changed event
              /// </summary>
              private void ChangedTheProperty()
              {
                     OnPropertyChanged(nameof(DevelopersBackgroundInfo));
                     OnPropertyChanged(nameof(DevelopersMessage));
                     OnPropertyChanged(nameof(AboutTheDeveloper));
              }

              /// <summary>
              /// Goes to the next page in the application
              /// </summary>
              private async Task GoToHomePageAsync()
              {
                     //Go to the Home Page
                     CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);
                     
                     // wait for one milisecond and continue
                     await Task.Delay(1);
              }
              
              #endregion
       }
}
