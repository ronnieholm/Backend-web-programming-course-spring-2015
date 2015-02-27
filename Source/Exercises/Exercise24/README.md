# Exercise 24: Beast battle

In this exercise we'll see how several classes can work together 
for a more complex task. The exercise is supposed to model a
simple game where a hero can battle a beast until either beast 
or hero is dead.

The exercise contains four classes which are described in general 
terms here. See the code for more details:

  - The NumberGenerator class with the GetRandomNumberInInterval method 
    is a helper class for generating random numbers.
  - The BattleLog class where individual strings can be "saved" and later 
    on printed to the screen.
  - The Hero class which models a game character. It represents a 
    simple character with an initial number of hit points. If damaged 
	the character loses	hit points. When all hit points are 
	lost, the character dies.
  - The Beast class which also models a game character. Actually, the 
    class is very similar to the Hero class.

It's a simple setup but resembles the mechanics of popular role-
playing games (RPG).

  1. Study the classes in details until you're sure what each does and how. 
     Note in particular how the Hero and Beast classes make use of the 
	 NumberGenerator and BattleLog classes.
  2. See if you can figure out how to code a battle between a Hero and a 
     Beast (until the death). It's should be done in the Runner class,
	 which has existing code to create an object of each classes. 
	 
	 It's your job to add code which makes the Hero object battle the 
	 Beast object. This'll require some thinking so before starting to code, 
	 try to sketch out how a battle proceeds in detail. You'll probably need a 
	 while-loop in your code.
  3. When two objects/game characters battle each other, a number of things
     need to be considered:

     a. It seems like the Hero wins most of the time. Why is that? How 
	    could we make the battle more fair?
     b. It looks like the damage dealt by the Hero is always within the 
	    interval 10 to 30 points. How could we change that? Could we even 
		let the creator of the Hero object decide this interval? Could this 
		also be done for the number of hit points?
     c. Do we really need separate classes for Hero and Beast? What would 
	    we need to add to obtain a more general Character class?
     d. How could you implement weapons and armor, healing abilities, etc?

