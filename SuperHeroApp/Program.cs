// See https://aka.ms/new-console-template for more information
namespace SuperHeroApp
{ internal class Program
    { static void Main(string[] args)
        {
            string[] SuperheroList = { "Anti", "Peng", "Kylo", "Evron" };

            string name = "Anti";
            int age = 428;
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Telepathically breaking and blowing up things";
            heroPower2 = "X-ray vision";
            heroPower3 = "Eating unlimited amounts of cookies";

            bool menuOn = true;
            do
            {
                string menuoptions;
                Console.WriteLine("Welcome to the Superhero guild!");
                Console.WriteLine("\nChoose an option: ");
                Console.WriteLine("1 - See a list of avaliable superheros");
                Console.WriteLine("2 - See the stats of a specific superhero");
                Console.WriteLine("3 - Add a new superhero to the Guild");
                Console.WriteLine("4 - Remove a superhero from the Guild");
                Console.WriteLine("5 - Rate a superhero");
                //Console.WriteLine("6 - Award to a superhero");
                Console.WriteLine("* - Leave the guild");
                Console.WriteLine();
                menuoptions = Console.ReadLine();
                Console.WriteLine();

                switch (menuoptions)
                {
                    case "1":
                        Console.WriteLine("***** List of avaliable heros *****");
                        for (int i = 0; i < SuperheroList.Length; i++)
                        {
                            Console.WriteLine($"{i+1} - {SuperheroList[i]}");
                        }
                        Console.WriteLine("************************************");
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("\nPlease choose a hero from the list");
                        for (int i = 0; i < SuperheroList.Length; i++)
                        {
                            Console.WriteLine($"{i+1} - {SuperheroList[i]}");
                        }
                        Console.WriteLine();
                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        if (chosenNumber <= SuperheroList.Length)
                        {
                            bool menu2On = true;
                            do
                            {
                                Console.WriteLine($"\nYou have chosen {SuperheroList[chosenNumber-1]}");
                                Console.WriteLine("\nWhich stats do you wish to see:");
                                Console.WriteLine("1 - General information");
                                Console.WriteLine("2 - Financial stats");
                                Console.WriteLine("3 - Back to main menu");
                                Console.WriteLine();
                                string menu2 = Console.ReadLine();
                                if (menu2 == "1")
                                {
                                    Console.WriteLine("\n***** General Information *****");
                                    Console.WriteLine($"Name: {SuperheroList[chosenNumber-1]}");
                                    Console.WriteLine($"Age: {age}");
                                    Console.WriteLine($"Special powers: \n 1.{heroPower1} \n 2.{heroPower2} \n 3.{heroPower3}");
                                    Console.WriteLine("*******************************\n");
                                }
                                else if (menu2 == "2")
                                {
                                    int deedTimeInHours1 = 3;
                                    int deedTimeInHours2 = 4;
                                    int deedTimeInHours3 = 1;
                                    int hourlycookies = 5;
                                    double salary = 1452;
                                    double cookieprice = 1.35;
                                    double numofcookies = Math.Floor(salary / cookieprice);
                                    double dailysalary = Math.Round(salary / 30, 2);
                                    double workintotal = deedTimeInHours1 + deedTimeInHours2 +deedTimeInHours3;
                                    double workaverage = Math.Round(workintotal / 3, 2);
                                    double cookiesearned = workintotal * hourlycookies;
                                    double cookiesearnedperdeed = Math.Round(workaverage * hourlycookies, 2);
                                    Console.WriteLine("\n***** Financial Information *****");
                                    Console.WriteLine($"Work hours per day: {workintotal}" +
                                        $"\nAverage work hours per deed: {workaverage}");
                                    Console.WriteLine($"Monthly salary: {salary} monies" +
                                        $"\nDaily salary: {dailysalary} monies");
                                    Console.WriteLine("*********************************\n");
                                } else if (menu2 == "3")
                                {
                                    menu2On = false;
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid selection. Try again!\n");
                                }
                            } while (menu2On);
                        } else
                        { 
                            Console.WriteLine("\nInvalid selection. Try again!\n");
                        }
                         break;
                    case "3":
                        Console.WriteLine("Name of the new Superhero:\n");
                        string superHeroName = Console.ReadLine();
                        SuperheroList = SuperheroList.Append(superHeroName);
                        Console.WriteLine($"\nCongratulations! {superHeroName} has joined the Superhero guild!");
                        Console.WriteLine($"\nCurrent Guild heroes are:");

                        for (int i = 0; i < SuperheroList.Length; i++)
                        {
                            Console.WriteLine($"{i+1} - {SuperheroList[i]}");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        bool menu3On = true;
                        do
                        {
                            Console.WriteLine("\nWhich hero would you like to remove?");
                            for (int i = 0; i < SuperheroList.Length; i++)
                            {
                                Console.WriteLine($"{i+1}. {SuperheroList[i]}");
                            }
                            Console.WriteLine($"{SuperheroList.Length+1}. Back to main menu\n");
                            int.TryParse(Console.ReadLine(), out int removeNumber);
                            Console.WriteLine();
                            if (removeNumber <=SuperheroList.Length)
                            {
                                SuperheroList = SuperheroList.Remove(removeNumber-1);
                                Console.WriteLine($"\nThe remaining heroes are:");

                                for (int i = 0; i < SuperheroList.Length; i++)
                                {
                                    Console.WriteLine($"{i+1}. {SuperheroList[i]}");
                                }
                            } else if (removeNumber == SuperheroList.Length+1)
                            {
                                menu3On = false;
                            }
                        } while (menu3On);
                        break;
                   
                    case "5":

                        bool herolist = true;

                        do
                        {
                            Console.WriteLine("Which of our heroes do you want to rate?");
                            for (int i = 0; i < SuperheroList.Length; i++)
                            {
                                Console.WriteLine($"{i+1} - {SuperheroList[i]}");
                            }
                            Console.WriteLine($"{SuperheroList.Length+1} - Return to main menu!");
                            Console.WriteLine();
                       
                        
                            int.TryParse(Console.ReadLine(), out int rateHero);
                            Console.WriteLine();
                            if (rateHero <= SuperheroList.Length)
                            {
                             bool ratingOn = true;
                                do
                                {

                                    Console.WriteLine($"\nHow would you rate {SuperheroList[rateHero-1]}?");
                                    Console.WriteLine($"A - The best hero ever!");
                                    Console.WriteLine($"B - Very good at every task!");
                                    Console.WriteLine($"C - Needs more training!");
                                    Console.WriteLine($"D - Terrible!");
                                    Console.WriteLine($"E - Pure Evil!");
                                    Console.WriteLine($"* - Return to hero list!");
                                    Console.WriteLine();
                                    char grade = Char.ToUpper(Char.Parse(Console.ReadLine()));
                                    Console.WriteLine();
                                    if (grade == 'A' || grade == 'B')
                                    {
                                        Console.WriteLine($"Thank you! This made {SuperheroList[rateHero-1]} happy! :) \n");
                                        ratingOn = false;
                                    }
                                    else if (grade == 'C')
                                    {
                                        Console.WriteLine($"{SuperheroList[rateHero-1]} will do better next time! :| \n");
                                        ratingOn = false;
                                    }
                                    else if (grade == 'D' || grade == 'E')
                                    {
                                        Console.WriteLine($"{SuperheroList[rateHero-1]} just had a bad day :( \n");
                                        ratingOn = false;
                                    }
                                    else if (grade == '*')
                                    {
                                        ratingOn = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid rating. Try again!");
                                    }

                                } while (ratingOn);
                            }else if (rateHero == SuperheroList.Length+1)
                            {
                                herolist = false;
                            }
                            else if (rateHero > SuperheroList.Length+1 || rateHero <1)
                            {
                                Console.WriteLine("Wrong number! Pick a hero from the list!");
                                Console.WriteLine();
                            }
                        }while (herolist);
                        


                            break;
                    case "*":
                        menuOn = false;
                        Console.WriteLine($"See you next time! Have a nice day!");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Try again!");
                        break;
                }



            } while (menuOn);
            
            
            
            
            
            
            
           /* 
            string name = "Anti";
            int age = 428;
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Telepathically breaking and blowing up things";
            heroPower2 = "X-ray vision";
            heroPower3 = "Eating unlimited amounts of cookies";
            double salary = 1452;
            bool isevil = false;
            int deedTimeInHours1 = 3;
            int deedTimeInHours2 = 4;
            int deedTimeInHours3 = 1;
            int hourlycookies = 5;
           
            Console.WriteLine("~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~");
            Console.WriteLine("\n\n        THE LEGEND OF THE ANTI HERO");
            Console.WriteLine("\n\n~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~");
            Console.WriteLine($"\n\nName : {name}");
            Console.WriteLine("\nAge : " + age);
            Console.WriteLine($"\nHero Powers :\n  *{heroPower1} \n  *{heroPower2} \n  *{heroPower3}\n\n");

            //work and cookies

            double cookieprice = 1.35;
            double numofcookies = Math.Floor(salary / cookieprice);
            double dailysalary = Math.Round(salary / 30, 2);
            double workintotal = deedTimeInHours1 + deedTimeInHours2 +deedTimeInHours3;
            double workaverage = Math.Round(workintotal / 3,2);
            double cookiesearned = workintotal * hourlycookies;
            double cookiesearnedperdeed = Math.Round(workaverage * hourlycookies,2);
            Console.WriteLine("~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~\n");
            Console.WriteLine($"Anti works {workintotal} hours a day.\nIn average it takes him {workaverage} hours to do one deed.");
            Console.WriteLine($"Anti's monthly salary is {salary} monies, his daily salary is {dailysalary} monies.");
            Console.WriteLine($"Anti can buy {numofcookies} cookies with his monthly salary.");
                if (isevil == true)
            {
                Console.WriteLine("Anti will destroy the Cookie city!");
            }
            else
            {
                Console.WriteLine("Anti is not evil, he would not intentionally hurt the Cookie city.");
            }
            
            Console.WriteLine($"Anti earns {cookiesearned} cookies for his good work, averaging {cookiesearnedperdeed} cookies per deed.");

            //The deed grading

            Console.WriteLine("~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~\n"); 
            Console.WriteLine("Anti helped an old lady to cross the street!\n");

            Console.WriteLine("How would you grade Anti's deed?");
            char deedgrade = Char.ToUpper(char.Parse(Console.ReadLine()));
            switch (deedgrade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! He is so brave!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But he can do better!");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! He should choose his bad or good side!");
                    break;
                case 'F':
                    Console.WriteLine("He has FAILED to do a good job!");
                    break;
                case 'G':
                    Console.WriteLine("Bad, he is a true villain!");
                    break;
                case 'H':
                    Console.WriteLine("He is going straight to HELL!");
                    break;
                default:
                    Console.WriteLine("No one can be THAT bad!!? O.O");
                    break;
                    
            }*/
        }
    }
}
