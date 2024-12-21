# How to make a UI element that show your health as text

Today we are going to make a Health UI in unity 2D, this tutorial includes a death menu that can take you back to the main menu as well as handling the player's death. The version I will be using for this is 2022.3.46f1.

The first thing that we are going to do is make the required items in the hierarchy. We need to first make a canvas, this will also give us an event system, you can find it here by right clicking on the hierarchy.

![alt text](image.png)



Then you want to create 2 canvases that we will use as a way to hold each part of the menu. Once you have done that rename one of the canvases "DeathMenu" and the other "GameUI".

The death menu will be used for the menu that shows up then when you die while the game UI is simply what will hold the UI that will show things such as the Health.

We want these to be child objects of the canvas we made earlier. You can select both of these by holding the left control key while you are selecting vbobth the canvases you just made. once done you should end up with something like this.

![alt text](image-2.png)

once you have done that we want to now make the UI that will come up when the death menu is activated, for this tutorial I will add some text and also a button that can later be coded to take you to the main menu. 

I did this by simply adding some text that tells you that you died as well as a button that could be used to take you back to the main menu, you can use this button to do anything you want given that you have the code for it. I also used a panel that gives the menu a background. All of these can be found in the UI section that you can see in a screenshot above.

~~~
changing it to inactive goes here then things for after it 
~~~





