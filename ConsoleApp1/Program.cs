using System;
using System.IO;

bool Running = true;
void Menu()
{
   
    while (Running)
    {
        Console.WriteLine("START STORY? Y/N");
        string Quit = Console.ReadLine();
        Quit = Quit.ToUpper();
        if (Quit == "N")
        {
            Running = false;
        }
        if (Quit != "N")

            Intro();
    }

    void Intro()
    {
        //string array for my text
        string[] text = new string[7];

        text[0] = "You wake up and find yourself in a dimmly lit room.";
        text[1] = "ddedadadadafagaga";
        text[2] = "You observe the room You see...";
        text[3] = "That the room can be no larger than a 3x3 metres. There was light from a candle on the bed side table and some seeping under the door.";
        text[4] = "A candle. looks like its about to flicker its last breath. .";



        Console.WriteLine(text[0]);
        Console.WriteLine("Press 1 to Keep Eyes Closed");
        Console.WriteLine("Press 2 to Open Eyes");
        choiceset1(); 

        void choiceset1()
        {
            ConsoleKey choice;
            while (choiceset1 != null)
            {

                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    // 1 ! key
                    case ConsoleKey.D1:
                        Console.WriteLine("1. Keep Eyes Closed");
                        Console.WriteLine("'BANG!'You hear a loud Crash, but you do not care.");
                        Console.WriteLine("you stare at the back of your eyelids");
                        Console.WriteLine("You feel a sharp stabbing pain thrust through your stomach");
                        Console.WriteLine("'Oughhhh!' You Scream Looks like it hurts.");
                        Console.WriteLine("You don't see who is stabbing you or what with since your eyes are still closed.");
                        Console.WriteLine("You Quickly lose consciousness and slip into the River Styx");
                        Console.WriteLine("Death Comes Quick to this poor lad.");
                        Continue();
                            break;
                    //2 @ key
                    case ConsoleKey.D2:
                        Console.WriteLine("2. Open Eyes");
                        Console.WriteLine(text[1]);
                        Console.WriteLine(text[2]);
                        Console.WriteLine(text[3]); 
                        Console.WriteLine(text[4]);
                        break;

                } while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2) ;

            }
        }
      

    }
}



void Continue()
{
    while (Running)
    {
        Console.WriteLine("Did you want to continue Y/N");
        string Quit = Console.ReadLine();
        Quit = Quit.ToUpper();
        if (Quit == "N")
        {
            Running = false;
        }
        if (Quit != "N")

            Menu();
    }
}
        Menu();

    //messages[0] = "";
    //messages[1] = ";
    //messages[2] = "";


   /* Choices     ConsoleKey choice;
    do
    {
        choice = Console.ReadKey(true).Key;
        switch (choice)
        {
            // 1 ! key
             ConsoleKey.D1:
                Console.WriteLine("1. Choice");
break;
            //2 @ key
            case ConsoleKey.D2:
                Console.WriteLine("2. Choice");
break;
        }
    } while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2) ;
}*/