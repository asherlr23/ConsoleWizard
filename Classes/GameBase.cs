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
              outcome = random.Next(1,3);
              if (outcome==2) {
                int randomWeapon = random.Next(1,5);
             

              }

                if (outcome == 1) {

                  Console.Write("You Wander around for 2 hours. \n Eventually, You find a'" + randomWeapon + "'.");


                 }
         
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
