using MobileApps3_Project.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace MobileApps3_Project
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            ViewLevels = new ViewModels.DifficultyViewModel();
        }//- End of MainPage

        public DifficultyViewModel ViewLevels { get; set; }

        //- Button_Click event that checks the nav url for the selected level and then navigates to that xaml page.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ViewLevels.SelectedLevel.navString.Equals("chaosLevel"))
                Frame.Navigate(typeof(chaosLevel));
            else if (ViewLevels.SelectedLevel.navString.Equals("roomLevel"))
                Frame.Navigate(typeof(roomLevel));
            else if (ViewLevels.SelectedLevel.navString.Equals("graveLevel"))
                Frame.Navigate(typeof(graveLevel));
        }//- End of Button_Click

    }//- End of MainPage
}//- End of MobileApps3_Project
