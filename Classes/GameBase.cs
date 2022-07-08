using System;
using System.IO;

    public class ConsoleWizardGamebase
    {
        Random random = new Random();
        int outcome = 0;
        bool isPlaying = false;
        protected string chosenOption = "none";
        string location =  "mainMenu";

         public void playSelection() {
          Console.WriteLine("Where Shall you Go?");
          Console.ReadLine();
          chosenOption = Console.ReadLine();
             
            if (chosenOption == "wander") { 
              
            }
        



         } 
         

       public void load() {
        isPlaying = false;
        location = "worldMap";
        Console.Write("You walk out of your house ready to start the day.");
        playSelection();

       }

       public void bossBattle() {


       }

        public void castSpell() {
             
          if (isPlaying){
            
         }

       }
    }
