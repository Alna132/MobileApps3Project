using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MobileApps3_Project
{
    public sealed partial class chaosLevel : Page
    {
        public chaosLevel()
        {
            this.InitializeComponent();

        }//- End of chaosLevel

        //- This overiden method makes sure that all the buttons and the item list is visible when the page opens.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            btnRat.Visibility = Visibility.Visible;
            txtRat.Visibility = Visibility.Visible;
            btnBaseball.Visibility = Visibility.Visible;
            txtBaseball.Visibility = Visibility.Visible;
            btnDice.Visibility = Visibility.Visible;
            txtDice.Visibility = Visibility.Visible;
            btnSpider.Visibility = Visibility.Visible;
            txtSpider.Visibility = Visibility.Visible;
            btnRadio.Visibility = Visibility.Visible;
            txtRadio.Visibility = Visibility.Visible;
            btnLock.Visibility = Visibility.Visible;
            txtLock.Visibility = Visibility.Visible;
            btnUmbrella.Visibility = Visibility.Visible;
            txtUmbrella.Visibility = Visibility.Visible;
            btnBike.Visibility = Visibility.Visible;
            txtBike.Visibility = Visibility.Visible;
            btnCandles.Visibility = Visibility.Visible;
            txtCandles.Visibility = Visibility.Visible;
            btnMantis.Visibility = Visibility.Visible;
            txtMantis.Visibility = Visibility.Visible;
        }//- End of OnNavigatedTo

        //- Each button when clicked collapses the visibility of their associated textbox and themselves.
        //- Then an if statement checks whether all the textboxes have been collaped.
        //- If they are then a dialog box is displayed and then the back button is pressed,
        //- the user is navigated back to the MainPage.
        private void btnRat_Click(object sender, RoutedEventArgs e)
        {
            btnRat.Visibility = Visibility.Collapsed;
            txtRat.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed && 
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnRat_Click

        private void btnBaseball_Click(object sender, RoutedEventArgs e)
        {
            btnBaseball.Visibility = Visibility.Collapsed;
            txtBaseball.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnBaseball_Click

        private void btnDice_Click(object sender, RoutedEventArgs e)
        {
            btnDice.Visibility = Visibility.Collapsed;
            txtDice.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnDice_Click

        private void btnSpider_Click(object sender, RoutedEventArgs e)
        {
            btnSpider.Visibility = Visibility.Collapsed;
            txtSpider.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnSpider_Click

        private void btnRadio_Click(object sender, RoutedEventArgs e)
        {
            btnRadio.Visibility = Visibility.Collapsed;
            txtRadio.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnRadio_Click

        private void btnLock_Click(object sender, RoutedEventArgs e)
        {
            btnLock.Visibility = Visibility.Collapsed;
            txtLock.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnLock_Click

        private void btnUmbrella_Click(object sender, RoutedEventArgs e)
        {
            btnUmbrella.Visibility = Visibility.Collapsed;
            txtUmbrella.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnUmbrella_Click

        private void btnBike_Click(object sender, RoutedEventArgs e)
        {
            btnBike.Visibility = Visibility.Collapsed;
            txtBike.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnBike_Click

        private void btnCandles_Click(object sender, RoutedEventArgs e)
        {
            btnCandles.Visibility = Visibility.Collapsed;
            txtCandles.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnCandles_Click

        private void btnMantis_Click(object sender, RoutedEventArgs e)
        {
            btnMantis.Visibility = Visibility.Collapsed;
            txtMantis.Visibility = Visibility.Collapsed;

            if (txtRat.Visibility == Visibility.Collapsed && txtBaseball.Visibility == Visibility.Collapsed &&
                txtDice.Visibility == Visibility.Collapsed && txtSpider.Visibility == Visibility.Collapsed &&
                txtRadio.Visibility == Visibility.Collapsed && txtLock.Visibility == Visibility.Collapsed &&
                txtUmbrella.Visibility == Visibility.Collapsed && txtBike.Visibility == Visibility.Collapsed &&
                txtCandles.Visibility == Visibility.Collapsed && txtMantis.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnMantis_Click

        //- This handler handles the command for the dialogue box's back button
        private void CommandInvokedHandler(IUICommand command)
        {
            Frame.Navigate(typeof(MainPage));
        }//- End of CommandInvokedHandler
    }//- End of chaosLevel
}//- End of MobileApps3_Project
