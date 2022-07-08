using System;
using System.IO;

namespace datastore // Note: actual namespace depends on the project name.
{
    public class SaveData
    { 
         public SaveData() {
        
         if (File.Exists("SaveLocation")) {
            
          Console.WriteLine("Looking for Save Data...");

         } else {
          
            Console.WriteLine("Please Specify a Path for your games save file.");
            Console.ReadLine();
            saveLocation = Console.ReadLine();
            File.WriteAllText(saveLocation + "consoleWizardSave.txt", "Weapons==ThinStick");
            


         }
      }
        private string saveLocation = "null";
        
     
     

    }
}