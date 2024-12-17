# How to make a UI element that show your health as text

Today we are going to make a Health UI in unity 2D, this tutorial includes a death menu that can take you back to the main menu as well as handling the player's death. The version I will be using for this is 2022.3.46f1.

The first thing that we are going to do is make the required items in the hierarchy. We need to first make a canvas, this will also give us an event system, you can find it here by right clicking on the hierarchy.

![alt text](image.png)

~~~~
After you have made that you then need to 2 more canvases that are children of the first canvas you made, you can do this holding the left control key on your keyboard and then clicking on both of them then dragging them on top of the first canvas you made. You should end up with something like this.

Then you want to create 2 canvases that we will use as a way to hold each part of the menu. Once you have done that rename one of the canvases "DeathMenu" and the other "GameUI".

The death menu will be used for the menu that shows up then when you die while the game UI is simply what will hold the UI that will show things such as the Health.

We want these to be child objects of the canvas we made earlier, once done you should end up with something like this.
~~~~

![alt text](image-2.png)

once you have done that we want to now make the UI that will come up when the death menu is activated, for this tutorial I will add some text and also a button that can later be coded to take you to the main menu. 



