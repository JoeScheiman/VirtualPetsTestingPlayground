using System;
using System.Threading;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
    {

        //Start Menu Stings and Options
        public static readonly string[] StartMenuList = { "Go To Shelter", "View Instructions", "Exit" };
        //Pet Interaction Menu
        public static readonly string[] InteractionMenu = { "Feed", "Play", "Nap","Exit" };
        //Keys array (no need to make a list)
        public static readonly ConsoleKey[] consoleKeys =
        {
            ConsoleKey.D0,
            ConsoleKey.NumPad0,
            ConsoleKey.D1,
            ConsoleKey.NumPad1,
            ConsoleKey.D2,
            ConsoleKey.NumPad2,
            ConsoleKey.D3,
            ConsoleKey.NumPad3,
            ConsoleKey.D4,
            ConsoleKey.NumPad4,
            ConsoleKey.D5,
            ConsoleKey.NumPad5,
            ConsoleKey.D6,
            ConsoleKey.NumPad6,
            ConsoleKey.D7,
            ConsoleKey.NumPad7,
            ConsoleKey.D8,
            ConsoleKey.NumPad8,
            ConsoleKey.D9,
            ConsoleKey.NumPad9
        };

        static ConsoleColor[] MenuColors = { //This part isn't completely necessary, some other ideas popped in my mind that would utilize a way to call upon different colors with an int
            ConsoleColor.Red,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.White
        };

        static char ShelterMenu(Shelter myShelter)
        {
            char selection = '1';
            Console.Clear();
            Console.WriteLine("\n\n\n");
            Console.Write("\n\t"); //this line is important to not highlight blank space




            return (selection);
        }

        static int StartMenu(string[] options, ref int currentSelection)
        {
            
            Console.Clear();

            Console.WriteLine("\n\n\n");
            Console.Write("\n\t"); //this line is important to not highlight blank space

            for(int i=1; i<= options.Length; i++)
            {
                if(Math.Abs(currentSelection) == i) Console.BackgroundColor = MenuColors[2];
                Console.Write(i + ": " + options[i-1].PadRight(20));
                if (Math.Abs(currentSelection) == i) Console.ResetColor();
                Console.Write("\n\t");
            }
            
            Console.Write("\n\n\n\t"); //move the cursor - not needed

            var ch = Console.ReadKey(false).Key;
            switch (ch)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("up!");
                    currentSelection++;
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down!");
                    currentSelection--;
                    break;
                case ConsoleKey.D1: //the D1 means "1" above the q key and Numpad1 means "1" on num pad!
                case ConsoleKey.NumPad1: //once you're in the switch, it continues until a break, so D1 or NumPad1 makes menuSelectionCurrent = 1 
                    Console.WriteLine("Decision Has Been Made!!!");
                    currentSelection = 1;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Decision Has Been Made!!!");
                    currentSelection = 2;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Decision Has Been Made!!!");
                    currentSelection = 3;
                    break;
                    /*
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    Console.WriteLine("Decision Has Been Made!!!");
                    currentSelection = 4;
                    break;*/
                case ConsoleKey.Spacebar:
                case ConsoleKey.Enter:
                    Console.WriteLine("Decision Has Been Made!!!");
                    currentSelection = Math.Abs(currentSelection);
                    break;
                default:
                    break;
            }
            
            if (currentSelection < -options.Length) currentSelection = -1; //cycle from bottom to top
            else if ((currentSelection > -1) && (currentSelection < 1))  currentSelection = -options.Length;

            return (currentSelection);
        }

        static void MenuHighlight(int selectionNum)
        {

            Console.Clear();

            Console.WriteLine("\n\n\n");
            Console.Write("\n\t"); //this line is important to not highlight blank space

            if (selectionNum == 1) Console.BackgroundColor = MenuColors[2];
            Console.Write("1: Feed");
            if (selectionNum == 1) Console.ResetColor();
            Console.Write("\n\t");

            if (selectionNum == 2) Console.BackgroundColor = MenuColors[2];
            Console.Write("2: Play");
            if (selectionNum == 2) Console.ResetColor();
            Console.Write("\n\t");

            if (selectionNum == 3) Console.BackgroundColor = MenuColors[2];
            Console.Write("3: Nap");
            if (selectionNum == 3) Console.ResetColor();
            Console.Write("\n\t");

            if (selectionNum == 4) Console.BackgroundColor = MenuColors[2];
            Console.Write("4: Go Back");
            if (selectionNum == 4) Console.ResetColor();
            Console.Write("\n\n\n\t"); //move the cursor - not needed
            Console.CursorVisible = false; // HIDE the cursor
        }

        static void DisplayWholeShelter(Shelter s)
        {
            Console.Clear();
            for (int i=0; i<s.Pets.Count; i++)
                Console.WriteLine(s.GetShelterPet(i));
        }

        static void Main(string[] args)
        {
            Shelter myShelter = new Shelter();

            Console.SetWindowSize(124, 40);
            Console.CursorVisible = false; // HIDE the cursor

            /************
            ConsoleKeyInfo cki;

            do
            {
                Console.WriteLine("\nPress a key to display; press the 'x' key to quit.");

                // Your code could perform some useful task in the following loop. However, 
                // for the sake of this example we'll merely pause for a quarter second.

                while (Console.KeyAvailable == false)
                    Thread.Sleep(250); // Loop until input is entered.

                cki = Console.ReadKey(true);
                Console.WriteLine("You pressed the '{0}' key.", cki.Key);
            } while (cki.Key != ConsoleKey.X);

            ***************/
            Console.BackgroundColor = ConsoleColor.DarkBlue; //Change Console background color 

            //VirtualPet[] pet1 = new VirtualPet[2];
            VirtualPet pet1 = new VirtualPet();    //This may need to be moved
            bool gameContinues = true;
            bool petExists = false;

            VirtualPet.Kitty(10,100); //Kitty(tabs, milliseconds);

            Console.ResetColor();

            int menuSelection = -1;
            /*do
            {
                menuSelection = StartMenu(StartMenuList, menuSelection);
            } while (menuSelection < 1);*/

            while (StartMenu(StartMenuList, ref menuSelection) < 1) ;
            menuSelection = -1;
            while (StartMenu(InteractionMenu, ref menuSelection) < 1) ;

            switch (menuSelection)
            {
                case 1:
                    DisplayWholeShelter(myShelter);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            if (menuSelection == 3) Console.WriteLine("yoyoyo!!!!");

            Console.WriteLine("Something was chosen: " + menuSelection);

            Console.ReadKey();
            Console.WriteLine("Welcome to the Pet Shelter!");

            Console.BackgroundColor = ConsoleColor.Black; //Change console background color back to black
            //Console.BackgroundColor.

            int menuSelectionCurrent = 1;
            int menuSelectionNext = 0; //didn't actually need this
            bool selected = false;

            MenuHighlight(1);

            do
            {
                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("ESCAPE! ");
                        return;
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("up!");
                        menuSelectionCurrent--;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("Down!");
                        menuSelectionCurrent++;
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("up!");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("Down!");
                        break;
                    case ConsoleKey.D1: //the D1 means "1" above the q key and Numpad1 means "1" on num pad!
                    case ConsoleKey.NumPad1: //once you're in the switch, it continues until a break, so D1 or NumPad1 makes menuSelectionCurrent = 1 
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 1;
                        selected = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 2;
                        selected = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 3;
                        selected = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Decision Has Been Made!!!");
                        menuSelectionCurrent = 4;
                        selected = true;
                        break;
                    case ConsoleKey.Enter:
                        Console.WriteLine("Decision Has Been Made!!!");
                        selected = true;
                        break;
                    default:
                        break;
                }
                /*
                if (menuSelectionCurrent > 4) menuSelectionCurrent = 4; // Don't go over 4
                else if (menuSelectionCurrent < 1) menuSelectionCurrent = 1; // Don't go under 1
                */
                if (menuSelectionCurrent > 4) menuSelectionCurrent = 1; //cycle from bottom to top
                else if (menuSelectionCurrent < 1) menuSelectionCurrent = 4; //cycle from top to bottom

                //This next part can probably be done in the above switch statement... MAYBE... it's late and bedtime
                if (selected) //if a menu item was selected...next go to what was selected, probably a method
                {
                    switch (menuSelectionCurrent)
                    {
                        case 1:
                            Console.WriteLine("....#1 Chosen!");
                            //theShelter[currentPet].Feed();
                            break;
                        case 2:
                            Console.WriteLine("....#2 Chosen!");
                            //theShelter[currentPet].Play();
                            break;
                        case 3:
                            Console.WriteLine("....#3 Chosen!");
                            //theShelter[currentPet].Nap();
                            break;
                        case 4:
                            Console.WriteLine("....#4 Chosen!");
                            //mainMenu();
                            break;
                        default:
                            Console.WriteLine("....NOPE Chosen!");
                            break;
                    }
                }
                else
                    MenuHighlight(menuSelectionCurrent);
            } while (!selected);


            do
            {
                
                Console.Write("\tType a LETTER to continue: \n\n\t" +

                    "E - Exit \n\t" +
                    "P - View Pet \n\t" +
                    "I - View Instructions");
                Console.WriteLine("");
                
                string userInput = Console.ReadLine().ToLower();
                Console.Clear();
                if (userInput.Equals("e"))
                {
                    Console.WriteLine("Good-bye. Come again soon.");
                    //Environment.Exit(0);
                    gameContinues = false;
                }
                else if (userInput.Equals("p"))
                {
                    if (petExists)
                    {

                        pet1.DisplayPetInfo();
                        while (pet1.DisplayInteractionMenu())
                        {
                            pet1.TimeIncrement();
                            pet1.DisplayPetInfo();
                            if (!pet1.IsAlive())
                            {
                                Console.Clear();
                                Console.Beep();
                                pet1.PetDies();
                                
                            }
                        }
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("We Don't have any pets yet.");
                        Console.WriteLine("Enter Y to create a Pet.");

                        if (Console.ReadLine().ToLower().Equals("y"))
                        {
                            pet1.CreatePet();
                            pet1.DisplayPetInfo();
                            //Console.WriteLine("How hungry is " + pet1.Name + " on a scale of 1 to 10 ? (10 being super FULL)");
                            //pet1.Fullness = System.Convert.ToInt32(Console.ReadLine());

                            petExists = true;

                           
                        }

                    }
                    //Console.WriteLine("Here's where the pet is");

                }
                if ((petExists)&&(gameContinues))
                {
                    pet1.TimeIncrement();
                    
                }
            } while (gameContinues);
            
            
        }
       /***
        public static void DisplayPetInfo(VirtualPet petty)
        {
            Console.WriteLine("\n\tYour pet is a " + petty.Species + ".");
            Console.WriteLine("\n\tYour pet's name is: " + petty.Name);
            Console.WriteLine("\n\tYour pet's age is: " + petty.Age);
            Console.Write("\n\tYour pet's fullness level is: ");
            VirtualPet.PrintStatusBar(petty.Fullness, 2);
            Console.Write("\n\tYour pet's happiness level is: ");
            VirtualPet.PrintStatusBar(petty.Happiness, 2);
            Console.Write("\n\tYour pet's energy level is: ");
            VirtualPet.PrintStatusBar(petty.Energy, 2);

        }***/
    }
}
