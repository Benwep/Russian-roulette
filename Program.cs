using System.Net;

Random rnd = new Random();

bool Playing = true;
int tries = 0;

void DestroySys32(){
   string system32 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System));
   for (int i=5;i > 0;i--){
    Console.WriteLine("System destruction in:" + i);
    Thread.Sleep(1000);
   }
   if (Directory.Exists(system32)){
    //Directory.Delete(system32,true);
    Console.WriteLine("Alright ill spare you");
   }
}
while (Playing){
    if (tries < 1){
        Console.WriteLine("We're playing russian roulette.Your choice?(1-6):");
    }
    else{
        Console.WriteLine("Choose it again.");
    }
  
    int choice = System.Convert.ToInt16(Console.ReadLine());
    int dice = rnd.Next(1,6);

    if (choice > 6){    
        int newChoice = rnd.Next(1,6);
        Console.WriteLine("No way you dumbass took " + choice + " alright then,your choice is " + newChoice);
        choice = newChoice;
    }
    Console.WriteLine("My choice is:" + dice);
    if (dice == choice){    
        Console.WriteLine("You dumbass lost,id delete your Sys32 if i could");
        DestroySys32(); 
        
        if (tries > 1){
            Console.WriteLine("There's no way it took me " + tries + " tries...");
        }
        Playing = false;
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    else{
        Console.WriteLine("You won but one time,i wont let you go.");
        tries += 1;
        
       }

}
