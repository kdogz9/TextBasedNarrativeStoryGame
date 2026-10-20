
using System;
using System.Collections.Generic;


//  ---    DIALOGUE LINES   ---    // 

        DialogueLine line0 = new DialogueLine();
        // creates dialogue line 
        line0.StoreInfo("You", "Sarah is late.Where is she?");
        // allows you to set and store the info put in the variables 
        DialogueLine line1 = new DialogueLine();
        line1.StoreInfo("Chloe", "Ugh I dont know Madison she does this all the time. I told you not to invite her. I'm going to sleep.");
         DialogueLine line2 = new DialogueLine();
         line2.OptionInfo("Do you stay up or go to sleep?");
         DialogueLine line3 = new DialogueLine();
         line3.StoreInfo("You", "I'm waiting for Sarah. I wanted to have a girly night in.");
         DialogueLine line4 = new DialogueLine();
         line4.DescriptionInfo("* 2 hours pass and Sarah finally arrives *");
         DialogueLine line5 = new DialogueLine();
         line5.StoreInfo("You", "Where have you been Sarah ??");
         DialogueLine line6 = new DialogueLine();
         line6.StoreInfo("Sarah", "Oh my god I'm sooooo sorry !! Josh kept arguing with me and I couldn't leave ! I'm here now though you wanna play truth or dare?");
        DialogueLine line7 = new DialogueLine();
        line7.StoreInfo("You", "Sure.");
        DialogueLine line8 = new DialogueLine();
        line8.StoreInfo("Sarah", "Truth or dare...?");
       DialogueLine line9 = new DialogueLine();
        line9.StoreInfo("Sarah", "Do you remember the pact we made as kids ?");
        DialogueLine line10 = new DialogueLine();
        line10.StoreInfo("Sarah", "Turn off all of the lights and stare into the mirror.");
DialogueLine line11 = new DialogueLine();
        line11.StoreInfo("You", "No Sarah that was years ago haha.");
DialogueLine line12 = new DialogueLine();
        line12.StoreInfo("You", "Of course I do ! We promised to stay by eachothers sides no matter what.");
DialogueLine line13 = new DialogueLine();
        line13.StoreInfo("Sarah", "Then why are you not with me now ?");
DialogueLine line14 = new DialogueLine();
        line14.StoreInfo("You", "Sarah what do you mean I am here with you ?");
DialogueLine line15 = new DialogueLine();
        line15.StoreInfo("Sarah", "No you're not Madison... I'm dead.");
DialogueLine line16 = new DialogueLine();
        line16.StoreInfo("You", "I don't really want to do that Sarah. Pick another one.");
DialogueLine line17 = new DialogueLine();
        line17.StoreInfo("Sarah", "Stop being a spoilt brat and just do it for gods sake Madison !");
DialogueLine line18 = new DialogueLine();
        line18.StoreInfo("You", "Sarah that really hurt. I'm not playing anymore.Goodnight.");
//  ---    LIST FOR DIALOGUE   ---    //             
    
        List<DialogueLine> Dialogue = new List<DialogueLine>();
        // Sets a list of all the dialogue options to then call later on.
        Dialogue.Add(line0);
        // lines to call from in the list 
        Dialogue.Add(line1);
        Dialogue.Add(line2);
        Dialogue.Add(line3);
        Dialogue.Add(line4);
        Dialogue.Add(line5);
        Dialogue.Add(line6);
        Dialogue.Add(line7);
        Dialogue.Add(line8);
        Dialogue.Add(line9);
        Dialogue.Add(line10);
        Dialogue.Add(line11);
        Dialogue.Add(line12);
        Dialogue.Add(line13);
        Dialogue.Add(line14);
        Dialogue.Add(line15);
        Dialogue.Add(line16);
        Dialogue.Add(line17);
        Dialogue.Add(line18);
//  ---    PRINTING DIALOGUE FROM LIST   ---    //  

        Dialogue[0].PrintSpeech();
        // First line of dialogue is called 
        Dialogue[1].PrintSpeech();
        Dialogue[2].PrintOption();
        
//  ---    CREATING OPTION DICTIONARY   ---    // 

Dictionary<string, List<DialogueLine>> OptionDictionary = new Dictionary<string, List<DialogueLine>>();

            OptionDictionary.Add("OptionDialogue", Dialogue);
// Finds the "option dictionary" and adds the key to the dialogue 
             
            List<DialogueLine> TheNewList = new List<DialogueLine>();
            TheNewList = OptionDictionary["OptionDialogue"];
// Creates new list within this dictionary so we can call the options/answers
                  
                        string answer1 = Console.ReadLine();
// Allows for input from the player

            if(answer1 == "sleep")
                // If and else statements to determine what dialogue they recieve
            {
                Console.WriteLine("You decided to go to sleep.");
                return;
                // produces dialogue 
            }

           else if(answer1 == "stay up")
                // If and else statements to determine what dialogue they recieve
            {
                Dialogue[3].PrintSpeech();
                Dialogue[4].PrintDescription();
                Dialogue[5].PrintSpeech();
                Dialogue[6].PrintSpeech();
                Dialogue[7].PrintSpeech();
                Dialogue[8].PrintSpeech();
                // produces dialogue 
            }

string answer2 = Console.ReadLine();
// Allows for input from the player

            if(answer2 == "truth")
                // If and else statements to determine what dialogue they recieve
            {
                Dialogue[9].PrintSpeech();

                string answer3 = Console.ReadLine();

                if(answer3 == "yes")
                {
                    Dialogue[12].PrintSpeech();
                    Dialogue[13].PrintSpeech();
                    Dialogue[14].PrintSpeech();
                    Dialogue[15].PrintSpeech();
                    return;
                }

                else if(answer3 == "no")
                {
                    Dialogue[11].PrintSpeech();
                    return;
                }
                // produces dialogue 
            }

           else if(answer2 == "dare")
                // If and else statements to determine what dialogue they recieve
            {
                
               Dialogue[10].PrintSpeech();
               Dialogue[16].PrintSpeech();
               Dialogue[17].PrintSpeech();
               Dialogue[18].PrintSpeech();
               return;
                // produces dialogue 
            }

// Dialogue[1].PrintSpeech();
// Prints dialogue after the option is called 

public class DialogueLine
{
    public string SpeakerName;
    // Variables for the speaker name and the speech
    public string Speech;

        public void PrintSpeech()
        {
                Console.WriteLine(SpeakerName + ": " + Speech);
            
   // allows us to set the name and text when this function is called. Stops the repetition of declaring it everytime.
            
        }

     public void PrintOption()
        {
                Console.WriteLine(Speech);
   // allows us to set the name and text when this function is called. Stops the repetition of declaring it everytime.
         
        }

     public void PrintDescription()
        {
                Console.WriteLine(Speech);
   // allows us to set the name and text when this function is called. Stops the repetition of declaring it everytime.
         
        }
    
        public void StoreInfo(string name, string lineToSay)
        {
                SpeakerName = name;
                Speech = lineToSay;
            // Stores this information. 
        }

      public void OptionInfo(string optionToSay)
        {
                Speech = optionToSay;
            // Stores this information. 
        }

     public void DescriptionInfo(string description)
        {
                Speech = description;
            // Stores this information. 
        }

}




