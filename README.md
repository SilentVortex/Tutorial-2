# How to make a UI element that show your health as text

Today we are going to make a Health UI in unity 2D, this tutorial includes a death menu that can be coded to take you back to the main menu as well as handling the player's death. This tutorial does not show you how to code the death screen to take you back to the main menu, only the UI for it. 

The version I will be using for this is 2022.3.46f1.

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

Now we will need to make a capsule to use as our object for the player, you can find this by right clicking on the hierachy and then 2D object, sprite and then you can find the capsule there.

![alt text](image-2.png)

Once we have made our capsule we then want to create a new script. We will call this script PlayerHealth. To add a new script go to your project window then right click and go to create, then c# script. You can find it via the screenshot below. 

![alt text](image-5.png)

Once you have done that remember to name the script to PlayerHealth.

We then want to add all the code that is seen below, I will explain each part as well.

![alt text](image-7.png)

The first thing we need to do is declare our variables. We need 4 variable for this script. For the maxHealth we use [SerializeField] here to expose this value to unity, we then need to declare that it is a float which is a number that can have decimals as well. We will then set this variable's value to 100.0f, without the f at the end unity won't know that it is supposed to be a float. We then need the variable for our currentHealth which will also be a float, we want this variable to be public so it can be accessed by any script in our project. Once that is done we then will make 2 more public variables using GameObject and then the name for both the DeathScreen and GameUI. THis will allow us to set which game object it needs to point to within unity. 

We can now move into the start method, here we simply want to set the current health to the max health. This will happen each time the scene is loaded.

We then are going to make our own method, we will make this a public method and then void so that it does not return a value. we also want to put a variable for damage, which is a float, into the brackets for the method. 

Inside the method we then want to write the logic for taking away the player's health, we do this by using -+. This the same as doing currentHealth = currentHealth - damage. We then want to make an if statement that checks if the currentHealth Variable is 0 or below, if so it will activate the Die method.

The die method doesnt need to have public in front of it as we do not need it to be, as such we can just put void instead since unity will assume that you want it private. We then want to disable the game onject that we have the script on, this will be the capsule that represents the player, and then turn off the gameUI and set the time scale to 0f which will freeze time in the game. We then turn on the deathScreen then close off our method and then we are done with this script.

~~~
This will be where you go and talk about how to add the actual text part of it now, you can say how to make a button that damages you to test it.
~~~
