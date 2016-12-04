# MobileApps3Project

A C# hidden object game with levels organised and shown via MVVM.

A hidden object game (sometimes called hidden picture) is a genre of puzzle video game in which the player must find items from a list that are hidden within a picture. 
Hidden object games are a popular trend in casual gaming, and are generally suitable for all ages.

## About the App Mainpage.
In this app, the MainPage displays a list of the available levels, this can be very easily edited to hold more or less levels via the levels.json file.

When a level is selected, information about that level is displayed on the right-hand side.
To play a level just click the play button below the level info.

## About the App Levels.
When a level is accessed there will be an image of a scene on the left and a list of objects on the right.
The user can search for the objects in the sceen and tap them when they find an item.
When all the items in the list have been found a dialogue box will pop-up to congradulate the user.
When the back button is pressed on the dialogue box the user is navigated back to the main page. 

## About the level types.
I chose a simple and universal Easy, Medium and Hard level differentation.
Each type has a different number of items to find and the items vary in their obviousness in the scene.

## Things that didn't go into the app.
I thought about applying Azure Authentication into the app, but it didn't really make much sense to do so. If a casual gamer uses the app, they are not going to want to have to log-in everytime they use the app.

## Reuse and adaptibility of the App.
This app is very versitile as it can have limitless capabilities.
A near infinite number of levels can be designed with different scenes, or scenes can be reused and adapted for other level types.
A timer could be implemented to time a users run through a level.
Login capabilities could be incorporated to allow users to save their scores.

# References:
(Dialogue Boxes)[https://msdn.microsoft.com/library/windows/apps/br208674]
(Tapped Location Co-Ordinates)[http://stackoverflow.com/questions/13674162/setting-position-of-a-uielement-for-a-windows-8-xaml-app]
(CS1056  C# Unexpected ' character Compiler Error)[https://msdn.microsoft.com/en-us/library/59k0x971.aspx]
(MVVM Tutorial from moodle)[https://learnonline.gmit.ie/pluginfile.php/177769/mod_resource/content/0/LAB2b-Problems.pdf]
(Add authentication to your Windows app)[https://docs.microsoft.com/en-us/azure/app-service-mobile/app-service-mobile-windows-store-dotnet-get-started-users]
