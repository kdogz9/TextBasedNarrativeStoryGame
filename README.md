# Text Based Narrative Story Game Dev log 

## Planning 
I started by creating a flowchart to explore my ideas and see how I would structure them in the code. My idea consisted of a short thriller-based storyline with different choice options for the player. I chose this idea so that the player could experience various outcomes depending on the direction they chose. I also wanted to keep the game relatively short by leaving some of the story paths on cliffhangers. Creating the flowchart helped me understand how the different choices would connect and allowed me to plan the narrative before starting the code.

(image of flowchart)

## Development 
My first approach when creating the code for the game was to set up a class called DialogueLine, which allowed me to define variables and methods that I could use later when needed. Once I had this in place, I could begin creating the dialogue lines with the necessary information for my storyline. Once these lines were set, I created a list to store my dialogue objects so that I could access them when needed throughout the story. I chose to use a list because it allowed me to store the dialogue objects together and access them using their index positions. This helped keep my code organised and made it easier to call specific dialogue lines throughout the game without having to write out the dialogue repeatedly.

The player choices and narrative paths were controlled using if/else statements, with Console.ReadLine() allowing the player to type their input. The if/else statements then checked the player's choice and controlled which part of the story would run next. This allowed me to create different scenarios depending on the player's decisions.

However, when implementing the narrative logic, I came across a couple of challenges. One challenge was understanding how C# organises top-level statements and class declarations. Initially I placed my class at the top of the code which caused a compiler error. I had to research the error and discovered that I needed to move the class below my top-level statements for the code to run correctly. This helped me understand more about how C# code needs to be structured. Another challenge I faced was when the player reached a choice that led to further decisions. To solve this I had to embed another if/else statement inside an existing one. This allowed me to create additional narrative branches depending on the player's previous choice. Although this worked, I found that having multiple choices made the code more complicated to follow.

(Insert screenshot of code here)

## Final outcome 
The final outcome was a working text-based thriller game that allowed the player to read dialogue and make choices that influenced the direction of the storyline. By using different narrative paths I was able to create multiple possible outcomes and cliffhangers. 

(video of it working)

## Skills gained 
This experience allowed me to gain various valuable skills and knowledge. I now have a better understanding of the importance of data structures, classes, variables and the Console.ReadLine() and Console.WriteLine() methods. I found that using a list was beneficial because it allowed me to keep my dialogue objects organised and access them when needed. It also helped me understand how data structures can make code easier to manage, especially when working with multiple pieces of information.Learning how to use classes and objects was another valuable skill because I could create a reusable structure for my dialogue lines.I also developed my understanding of if/else statements and how they can be used to control the flow of a game. Finally, using Console.ReadLine() and Console.WriteLine() taught me how to display text on the screen and allow the player to interact with the game through their own input. This was particularly useful because player interaction was one of the main features of my game. 

## Sources 