using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MobileApps3_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class graveLevel : Page
    {
        public graveLevel()
        {
            this.InitializeComponent();
            btnHat.Visibility = Visibility.Visible;

        }//- End of graveLevel

        //private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    Point tappedPoint = e.GetPosition(graveScene);

        //    //if (tappedPoint.X == )

        //}

        private void btnHat_Click(object sender, RoutedEventArgs e)
        {
            btnHat.Visibility = Visibility.Collapsed;
            txtHat.Visibility = Visibility.Collapsed;

            if(txtHat.Visibility == Visibility.Collapsed && txtTeddy.Visibility == Visibility.Collapsed && 
                txtEggplant.Visibility == Visibility.Collapsed && txtCherry.Visibility == Visibility.Collapsed && 
                txtLamp.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnHat_Clicked

        private void btnTeddy_Click(object sender, RoutedEventArgs e)
        {
            btnTeddy.Visibility = Visibility.Collapsed;
            txtTeddy.Visibility = Visibility.Collapsed;

            if (txtHat.Visibility == Visibility.Collapsed && txtTeddy.Visibility == Visibility.Collapsed &&
                    txtEggplant.Visibility == Visibility.Collapsed && txtCherry.Visibility == Visibility.Collapsed &&
                    txtLamp.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if

        }//- End of btnTeddy_Clicked

        private void btnEggplant_Click(object sender, RoutedEventArgs e)
        {
            btnEggplant.Visibility = Visibility.Collapsed;
            txtEggplant.Visibility = Visibility.Collapsed;

            if (txtHat.Visibility == Visibility.Collapsed && txtTeddy.Visibility == Visibility.Collapsed &&
                    txtEggplant.Visibility == Visibility.Collapsed && txtCherry.Visibility == Visibility.Collapsed &&
                    txtLamp.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if

        }//- End of btnEggplant_Click

        private void btnCherry_Click(object sender, RoutedEventArgs e)
        {
            btnCherry.Visibility = Visibility.Collapsed;
            txtCherry.Visibility = Visibility.Collapsed;

            if (txtHat.Visibility == Visibility.Collapsed && txtTeddy.Visibility == Visibility.Collapsed &&
                    txtEggplant.Visibility == Visibility.Collapsed && txtCherry.Visibility == Visibility.Collapsed &&
                    txtLamp.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if

        }//- End of btnCherry_Click

        private void btnLamp_Click(object sender, RoutedEventArgs e)
        {
            btnLamp.Visibility = Visibility.Collapsed;
            txtLamp.Visibility = Visibility.Collapsed;

            if (txtHat.Visibility == Visibility.Collapsed && txtTeddy.Visibility == Visibility.Collapsed &&
                    txtEggplant.Visibility == Visibility.Collapsed && txtCherry.Visibility == Visibility.Collapsed &&
                    txtLamp.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if

        }//- End of btnLamp_Click

        private void CommandInvokedHandler(IUICommand command)
        {
            Frame.Navigate(typeof(MainPage));
        }//- End of CommandInvokedHandler

    }//- End of graveLevel

}//- End of MobileApps3_Project
