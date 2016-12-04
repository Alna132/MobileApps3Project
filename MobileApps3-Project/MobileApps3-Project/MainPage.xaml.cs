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
        }
        public DifficultyViewModel ViewLevels { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ViewLevels.SelectedLevel.navString.Equals("chaosLevel"))
                Frame.Navigate(typeof(chaosLevel));
            else if (ViewLevels.SelectedLevel.navString.Equals("roomLevel"))
                Frame.Navigate(typeof(roomLevel));
            else if (ViewLevels.SelectedLevel.navString.Equals("graveLevel"))
                Frame.Navigate(typeof(graveLevel));
            
            
            //navStringText.text;
            //Frame.Navigate(typeof(graveLevel));
        }

        //Create button click event that takes the nav url for the selected level and then navigates to that xaml page.
    }
}
