using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MobileApps3_Project
{
    public sealed partial class roomLevel : Page
    {
        public roomLevel()
        {
            this.InitializeComponent();
        }//- End of roomLevel

        //- This overiden method makes sure that all the buttons and the item list is visible when the page opens.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            btnChess.Visibility = Visibility.Visible;
            txtChess.Visibility = Visibility.Visible;
            btnBellows.Visibility = Visibility.Visible;
            txtBellows.Visibility = Visibility.Visible;
            btnFan.Visibility = Visibility.Visible;
            txtFan.Visibility = Visibility.Visible;
            btnBone.Visibility = Visibility.Visible;
            txtBone.Visibility = Visibility.Visible;
            btnSpoon.Visibility = Visibility.Visible;
            txtSpoon.Visibility = Visibility.Visible;
            btnTack.Visibility = Visibility.Visible;
            txtTack.Visibility = Visibility.Visible;
            btnLighter.Visibility = Visibility.Visible;
            txtLighter.Visibility = Visibility.Visible;
        }//- End of OnNavigatedTo

        //- Each button when clicked collapses the visibility of their associated textbox and themselves.
        //- Then an if statement checks whether all the textboxes have been collaped.
        //- If they are then a dialog box is displayed and then the back button is pressed,
        //- the user is navigated back to the MainPage.
        private void btnChess_Click(object sender, RoutedEventArgs e)
        {
            btnChess.Visibility = Visibility.Collapsed;
            txtChess.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed && 
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if

        }//- End of btnChess_Clicked

        private void btnBellows_Click(object sender, RoutedEventArgs e)
        {
            btnBellows.Visibility = Visibility.Collapsed;
            txtBellows.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnBellows_Click

        private void btnFan_Click(object sender, RoutedEventArgs e)
        {
            btnFan.Visibility = Visibility.Collapsed;
            txtFan.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnFan_Click

        private void btnBone_Click(object sender, RoutedEventArgs e)
        {
            btnBone.Visibility = Visibility.Collapsed;
            txtBone.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnBone_Click

        private void btnSpoon_Click(object sender, RoutedEventArgs e)
        {
            btnSpoon.Visibility = Visibility.Collapsed;
            txtSpoon.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnSpoon_Click

        private void btnTack_Click(object sender, RoutedEventArgs e)
        {
            btnTack.Visibility = Visibility.Collapsed;
            txtTack.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnTack_Click

        private void btnLighter_Click(object sender, RoutedEventArgs e)
        {
            btnLighter.Visibility = Visibility.Collapsed;
            txtLighter.Visibility = Visibility.Collapsed;

            if (txtChess.Visibility == Visibility.Collapsed && txtBellows.Visibility == Visibility.Collapsed &&
                txtFan.Visibility == Visibility.Collapsed && txtBone.Visibility == Visibility.Collapsed &&
                txtSpoon.Visibility == Visibility.Collapsed && txtTack.Visibility == Visibility.Collapsed &&
                txtLighter.Visibility == Visibility.Collapsed)
            {
                var messageDialog = new MessageDialog("Congratulations! You found all the items in this level!");
                messageDialog.Commands.Add(new UICommand("Back", new UICommandInvokedHandler(this.CommandInvokedHandler)));

            }//- End of if
        }//- End of btnLighter_Click

        //- This handler handles the command for the dialogue box's back button
        private void CommandInvokedHandler(IUICommand command)
        {
            Frame.Navigate(typeof(MainPage));
        }//- End of CommandInvokedHandler
    }//- End of roomLevel
}//- End of MobileApps3_Project
