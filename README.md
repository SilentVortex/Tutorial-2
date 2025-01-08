# How to make a UI element that show your health as text

Today we are going to make a Health UI in unity 2D, this tutorial includes a death menu that can take you back to the main menu as well as handling the player's death. The version I will be using for this is 2022.3.46f1.

The first thing that we are going to do is make the required items in the hierarchy. We need to first make an empty game object. We will use this to keep our scene organised and hold our two canvases. You can find both of these in the image below.

![alt text](image.png)

Name the empty gameobject something such as Menu, I will use MenuStuff for this tutorial

Name 1 of the canvases you will male DeathMenu and then another one called

The death menu will be used for the menu that shows up then when you die while the game UI is simply what will hold the UI that will show things such as the Health.

We want these to be child objects of the empty gameobject we made earlier. You can select both of these by holding the left control key while you are selecting both the canvases you just made. once done you should end up with something like this.

![alt text](image-4.png)

once you have done that we want to now make the UI that will come up when the death menu is activated, for this tutorial I will add some text and also a button that can later be coded to take you to the main menu. 

I did this by simply adding some text that tells you that you died as well as a button that could be used to take you back to the main menu, you can use this button to do anything you want given that you have the code for it. I also used a panel that gives the menu a background. All of these can be found in the the same place that you created the canvases from.

Once you have made your DeathMenu you then want to set it as inactive by making sure that the checkbox in the inspector is off. You can do this by selecting it in the hierarchy and then going to the inspector and then next to the name of the object yo will find the checkbox. Here is an image of what it looks like.
![alt text](image-3.png)
You can see the checkbox that we need to toggle off in the top left of this screenshot above.





