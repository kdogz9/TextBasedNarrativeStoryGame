# Text Based Narrative Story Game Dev log 

## Planning 
I started by creating a flowchart to explore my ideas and see how I would structure them in the code. My idea consisted of a short thriller-based storyline with different choice options for the player. I chose this idea so that the player could experience various outcomes depending on the direction they chose. I also wanted to keep the game relatively short by leaving some of the story paths on cliffhangers. Creating the flowchart helped me understand how the different choices would connect and allowed me to plan the narrative before starting the code.

![Image of flowchart](https://raw.githubusercontent.com/kdogz9/TextBasedNarrativeStoryGame/refs/heads/main/NarrativeStorytelling.png)

[Link to flowchart](https://app.diagrams.net/#G1DwQBrQ77xuAvrQ2mqWfkggKJj-2mKzX_#%7B%22pageId%22%3A%22ej93tNamHamwUbjjH4Xr%22%7D)

## Development 
My first approach when creating the code for the game was to set up a class called DialogueLine, which allowed me to define variables and methods that I could use later when needed. Once I had this in place, I could begin creating the dialogue lines with the necessary information for my storyline. Once these lines were set, I created a list to store my dialogue objects so that I could access them when needed throughout the story. I chose to use a list because it allowed me to store the dialogue objects together and access them using their index positions. (List Class in C#, 00:00:50+00:00) This helped keep my code organised and made it easier to call specific dialogue lines throughout the game without having to write out the dialogue repeatedly.

``` 
DialogueLine line0 = new DialogueLine();
        // creates dialogue line 
        line0.StoreInfo("You", "Sarah is late.Where is she?");
        // allows you to set and store the info put in the variables 
```

```
List<DialogueLine> Dialogue = new List<DialogueLine>();
        // Sets a list of all the dialogue options to then call later on.
        Dialogue.Add(line0);
        // lines to call from in the list 
```

```
Dialogue[0].PrintSpeech();
        // First line of dialogue is called 
```

```
 string answer1 = Console.ReadLine();
// Allows for input from the player

            if(answer1 == "sleep")
                // If and else statements to determine what dialogue they recieve
            {
                Console.WriteLine("You decided to go to sleep.");
                return;
                // produces dialogue and ends game
            }
```
    
The player choices and narrative paths were controlled using `if/else statements`, with `Console.ReadLine()` (C# User Input, s.d.) allowing the player to type their input. The if/else statements then checked the player's choice and controlled which part of the story would run next (C# Adventure 08: Branching Narrative • Programming is Fun, s.d.). This allowed me to create different scenarios depending on the player's decisions.

However, when implementing the narrative logic, I came across a couple of challenges. One challenge was understanding how C# organises top-level statements and class declarations. Initially I placed my class at the top of the code which caused a compiler error. I had to research the error and discovered that I needed to move the class below my top-level statements for the code to run correctly. ((8,5): error CS8803: Top-level statements must precede namespace and type declarations - Scripting, 2023) This helped me understand more about how C# code needs to be structured. Another challenge I faced was when the player reached a choice that led to further decisions. To solve this I had to embed another if/else statement inside an existing one. (C# Nested If Else Statements with Examples - Tutlane, s.d.) This allowed me to create additional narrative branches depending on the player's previous choice. Although this worked, I found that having multiple choices made the code more complicated to follow.


## Final outcome 
The final outcome was a working text-based thriller game that allowed the player to read dialogue and make choices that influenced the direction of the storyline. By using different narrative paths I was able to create multiple possible outcomes and cliffhangers. 

[Video of it working](https://youtu.be/yvuzWBZgWz0)

## Skills gained 
This experience allowed me to gain various valuable skills and knowledge. I now have a better understanding of the importance of data structures, classes, variables and the Console.ReadLine() and Console.WriteLine() methods. I found that using a list was beneficial because it allowed me to keep my dialogue objects organised and access them when needed. It also helped me understand how data structures can make code easier to manage, especially when working with multiple pieces of information.Learning how to use classes and objects was another valuable skill because I could create a reusable structure for my dialogue lines.I also developed my understanding of if/else statements and how they can be used to control the flow of a game. Finally, using Console.ReadLine() and Console.WriteLine() taught me how to display text on the screen and allow the player to interact with the game through their own input. This was particularly useful because player interaction was one of the main features of my game. 

## Sources 

C# Nested If Else Statements with Examples - Tutlane (s.d.) At: https://www.tutlane.com/tutorial/csharp/csharp-nested-if-else-statements-with-examples (Accessed  20/10/2026).

(8,5): error CS8803: Top-level statements must precede namespace and type declarations - Scripting (2023) At: https://discussions.unity.com/t/8-5-error-cs8803-top-level-statements-must-precede-namespace-and-type-declarations/924083 (Accessed  20/10/2026).

C# Adventure 08: Branching Narrative • Programming is Fun (s.d.) At: https://programmingisfun.com/learn/c-sharp-adventure-game/c_sharp_08_branching_narrative/ (Accessed  20/10/2026).

BillWagner (s.d.) Jump statements - break, continue, return, and goto - C# reference. At: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/jump-statements (Accessed  20/10/2026).

List Class in C# (00:00:50+00:00) At: https://www.geeksforgeeks.org/c-sharp/list-class-in-c-sharp/ (Accessed  20/10/2026).

C# User Input (s.d.) At: https://www.w3schools.com/cs/cs_user_input.php (Accessed  20/10/2026).

