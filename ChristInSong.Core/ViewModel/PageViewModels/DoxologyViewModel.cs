using LizHackMethods.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using LizHackMethods.LogicMethods;

namespace ChristInSong.Core
{
       public class DoxologyViewModel: BaseViewModel
       {
              #region private members


              #endregion

              #region Public properties

              /// <summary>
              /// The lyrics of the doxology
              /// </summary>
              public string DoxologyLyrics { get; set; }

              /// <summary>
              /// The Type of hymnal to be used
              /// </summary>
              public HymnType TypeOfHymn { get; set; } = HymnType.ChristInSong;
              
              #endregion

              #region Commands

              /// <summary>
              /// Go to the Developer page
              /// </summary>
              public ICommand GoToHomePage { get; set; }
              
              #endregion

              #region constructor

              /// <summary>
              /// Default contructor
              /// </summary>
              public DoxologyViewModel()
              {
                     // Look for the Doxology chosen
                     Task.Run(async () =>
                     {
                            // change the property
                            DoxologyLyrics = CIS_LogicMethods.CisDoxlogy();

                            // fire  the proprty changed event
                            ChangedTheProperty();

                            // wait
                            await Task.Delay(1);
                     });

                     // generate the view model commands
                     GenerateCommands();
              }

              #endregion

              #region Command Methods

              /// <summary>
              /// Go to the home page
              /// </summary>
              /// <returns></returns>
              private async Task GoHomeAsync()
              {
                     //Go to the Home Page
                     CoreDi.VM_Application_Dna.GoToPage(ApplicationPageType.Home);

                     // wait for one milisecond and continue
                     await Task.Delay(1);
              }
              
              #endregion


              #region Helper methods

              /// <summary>
              /// Fires off the property changed event to inform the GUI that we have changed the propeties
              /// </summary>
              private void ChangedTheProperty()
              {
                     OnPropertyChanged(nameof(DoxologyLyrics));
                     //OnPropertyChanged(nameof(PathToDoc));
              }

              /// <summary>
              /// Generates commands for the view model
              /// </summary>
              private void GenerateCommands()
              {
                     GoToHomePage = new RelayCommand(async () => await GoHomeAsync());
              }

              #endregion

       }
}
