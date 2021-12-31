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
        text[1] = "You observe the room You see...";
        text[2] = "A small room that is very dark. Apart from...";
        text[3] = "A candle. looks like its about to flicker its last breath. .";
        text[4] = "A Bedside Table";
        text[5] = "A small bed frame";



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
                        Console.WriteLine("you stare at the back of your eyelids.");
                        Console.WriteLine("You feel a sharp stabbing pain thrust through your stomach.");
                        Console.WriteLine("'Oughhhh!' You Scream Looks like it hurts.");
                        Console.WriteLine("You don't see who is stabbing you or what with since your eyes are still closed.");
                        Console.WriteLine("You Quickly lose consciousness and slip into the River Styx.");
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
                        Console.WriteLine(text[5]);
                        Console.WriteLine("What Do you do?");
                        Console.WriteLine("Press 1 to Open bedside table doors.");
                        Console.WriteLine("Press 2 to Search under the bed");
                        Console.WriteLine("Press 3 to Throw Candle at the wall");
                        choiceset2();
                        break;

                } while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2) ;

            }
        }
      

    }
}

void choiceset2()
{
    ConsoleKey choice;
    while (choiceset2 != null)
    {

        choice = Console.ReadKey(true).Key;
        switch (choice)
        {
            // 1 Bedside table
            case ConsoleKey.D1:
                Console.WriteLine("You open the doors of the bedside table.");
                Console.WriteLine("You find a chest hidden within");
                Console.WriteLine("You grab it and find that the chest needs a key.");
                Console.WriteLine("BANG!");
                Console.WriteLine("The door slams open and a grotesque naked abomination walks through. The thing is missing a limb and it's skin looks like slime");
                Console.WriteLine("The room becomes rotten with a fishy oder.");
                Console.WriteLine("The 'Man' sprints at you with blinding speed.");
                Console.WriteLine("You feel a sharp object get inserted into your chest.");
                Console.WriteLine("You drop to the floor with a yelp and a kick.");
                Console.WriteLine("The pain is overwhelming.");
                Console.WriteLine("You die with the lingering smell of a decomposed sailor... it burns.");
                Continue();


                break;
            //2 Under the bed
            case ConsoleKey.D2:
                Console.WriteLine("You get down low and search under the bed.");
                Console.WriteLine("It's old and musty down here. Looks like there is something on the far side.");
                Console.WriteLine("You have to crawl under to reach it. You start to crawl.");
                Console.WriteLine("The dust and dirt scrapes your skin. Uncomfortable and unpleasant. " +
                    "This small space seems lengthy when crawling underneath.");
                Console.WriteLine("You finally grab the key.");
                Console.WriteLine("BANG!");
                Console.WriteLine("The door swings open.");
                Console.WriteLine("You are facing the wrong way and can't see anything happening.");
                Console.WriteLine("Two things fill the room the sound of heavy breathing and the rotten stench of a dead mariner.");
                Console.WriteLine("Crash, Bang! 'AHHHHHHHHHHHHHHHHHHHHH!' sounds echo from outside the room.");
                Console.WriteLine("You hear the sound of the door close and lock");
                Console.WriteLine("Silence.");
                Console.WriteLine("What do you do?");
                Console.WriteLine("Press 1 to Investigate door");
                Console.WriteLine("Press 2 to Get on the bed and take a nap.");
                Console.WriteLine("Press 3 to Search Bedside table.");
                Console.WriteLine("Press 4 to Adjust yourself to face the door and wait under the bed.");
              
                break;
            //3 @ Key
            case ConsoleKey.D3:
                Console.WriteLine("You throw the candle at the wall.");
                Console.WriteLine("THUD.");
                Console.WriteLine("You throw it with great intensity.");
                Console.WriteLine("You walk towards the corner of the room, hug your knees and try to wake up.");
                Console.WriteLine("What a Wonderous time...");
                Console.WriteLine("BANG!");
                Console.WriteLine("The door slams open and a foul oder leaks in.");
                Console.WriteLine("You can't see anything.");
                Console.WriteLine("But you can hear. THUD, THUD, THUD. Somthing is walking towards the bed.");

                break;

        } while (choice != ConsoleKey.D1 && choice != ConsoleKey.D2 && choice != ConsoleKey.D3) ;

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