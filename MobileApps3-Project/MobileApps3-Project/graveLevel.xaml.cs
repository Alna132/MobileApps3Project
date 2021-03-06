﻿using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace MobileApps3_Project
{
    public sealed partial class graveLevel : Page
    {
        public graveLevel()
        {
            this.InitializeComponent();
            btnHat.Visibility = Visibility.Visible;

        }//- End of graveLevel

        //- This overiden method makes sure that all the buttons and the item list is visible when the page opens.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            btnHat.Visibility = Visibility.Visible;
            txtHat.Visibility = Visibility.Visible;
            btnTeddy.Visibility = Visibility.Visible;
            txtTeddy.Visibility = Visibility.Visible;
            btnEggplant.Visibility = Visibility.Visible;
            txtEggplant.Visibility = Visibility.Visible;
            btnCherry.Visibility = Visibility.Visible;
            txtCherry.Visibility = Visibility.Visible;
            btnLamp.Visibility = Visibility.Visible;
            txtLamp.Visibility = Visibility.Visible;
        }//- End of OnNavigatedTo

        //- Each button when clicked collapses the visibility of their associated textbox and themselves.
        //- Then an if statement checks whether all the textboxes have been collaped.
        //- If they are then a dialog box is displayed and then the back button is pressed,
        //- the user is navigated back to the MainPage.
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

        //- This handler handles the command for the dialogue box's back button
        private void CommandInvokedHandler(IUICommand command)
        {
            Frame.Navigate(typeof(MainPage));
        }//- End of CommandInvokedHandler

    }//- End of graveLevel

}//- End of MobileApps3_Project
