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
            if (ViewLevels.SelectedIndex == 2){
                Frame.Navigate(typeof(chaosLevel)); }
            else if (ViewLevels.SelectedIndex == 1){
                Frame.Navigate(typeof(roomLevel)); }
            else if (ViewLevels.SelectedIndex == 0){
                Frame.Navigate(typeof(graveLevel)); }
        }//- End of Button_Click

    }//- End of MainPage
}//- End of MobileApps3_Project
