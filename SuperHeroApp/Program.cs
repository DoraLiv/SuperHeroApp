// See https://aka.ms/new-console-template for more information
namespace SuperHeroApp
{ internal class Program
    { static void Main(string[] args)
        {
            List<Hero> Guild = new List<Hero>();
            Hero hero1 = new Hero("Annie", "Time", "Anti", 428, 007, HeroType.Antihero, 974, "Telepathically breaking and blowing up things",
               "Time manipulation", "Eating unlimited amounts of cookies", 30, 2000, 1452, 'A');
            Hero hero2 = new Hero("Paul", "Neige", "Peng", 35, 003, HeroType.Hero, 25, "Freezing breath", "Killer looks", "Future prediction",
                150, 3, 1649982, 'A');
            Hero hero3 = new Hero("Robert", "Runner", "Kylo", 19, 189, HeroType.Hero, 4, "The Force", "Lightsaber fighting skills",
                "Math", 65, 3, 674, 'E');
            Hero hero4 = new Hero ("John", "Valentine", "Evron", 40, 057, HeroType.Antihero, 13, "Persuasion", "Perfect vision",
            "Killer voice", 80, 54, 10453, 'B');
            Guild.Add(hero1);
            Guild.Add(hero2);
            Guild.Add(hero3);
            Guild.Add(hero4);
            //Guild.Remove(hero1); remove from list by name
            //Guild.RemoveAt(0);   remove from list at position (eg user input - remove hero from guild)

            
            var foundHero1 = Guild.Find(find => find.Name == "John");
            var level1 = Guild.Count(n => n.CalculatedLevel() == 1);
            var level2 = Guild.Count(n => n.CalculatedLevel() == 2);
            var level3 = Guild.Count(n => n.CalculatedLevel() == 3);
            var level1plus = Guild.Count(n => n.CalculatedLevel() > 1);
            Console.WriteLine($"There are {level1} Level1 heroes");
            Console.WriteLine($"There are {level1} Level1 heroes");
            Console.WriteLine($"There are {level2} Level2 heroes");
            Console.WriteLine($"There are {level1plus} heroes with lever higher than 1");
            if (foundHero1 != null)
            {
                Console.WriteLine($"There is a hero {foundHero1.Nickname} named Jonh");
            }
            else if (foundHero1 == null)
            {
                Console.WriteLine("There are no heroes named John");
            }
           





            string[] SuperheroList = { "Anti", "Peng", "Kylo", "Evron" };
            
            /*for (int i = 0; i < Guild.Count; i++)
            {
                Console.WriteLine(Guild[i].Nickname);
            }*/

            /*string name = "Anti";
            int age = 428;
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Telepathically breaking and blowing up things";
            heroPower2 = "X-ray vision";
            heroPower3 = "Eating unlimited amounts of cookies";
            */
            bool menuOn = true;
            do
            {
                string menuoptions;
                Console.WriteLine("===============================");
                Console.WriteLine("Welcome to the Superhero guild!");
                Console.WriteLine("===============================");
                Console.WriteLine("\nChoose an option: ");
                Console.WriteLine("1 - See a list of avaliable superheros");
                Console.WriteLine("2 - See the stats of a specific superhero");
                Console.WriteLine("3 - Add a new superhero to the Guild");
                Console.WriteLine("4 - Remove a superhero from the Guild");
                Console.WriteLine("5 - Rate a superhero");
                //Console.WriteLine("6 - Award or fine a superhero");
                Console.WriteLine("* - Leave the guild");
                Console.WriteLine();
                menuoptions = Console.ReadLine();
                Console.WriteLine();

                switch (menuoptions)
                {
                    case "1":
                        Console.WriteLine("***** List of avaliable heros *****");
                        for (int i = 0; i < Guild.Count; i++)
                        {
                            Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                        }
                        Console.WriteLine("************************************");
                        Console.WriteLine();
                        break;

                    case "2":

                        bool parameterchoice = true;
                        do
                        {
                            Console.WriteLine("Choose search parameter:");
                            Console.WriteLine("1 - search by order in guild");
                            Console.WriteLine("2 - search by HeroID");
                            Console.WriteLine("3 - search by name, surname or nickname");
                            Console.WriteLine("* - back to main menu");
                            Console.WriteLine();
                            string searchparameter = Console.ReadLine();
                            switch (searchparameter)
                            {
                                case "1":
                                    bool herochoice1 = true;
                                    do
                                    {

                                        Console.WriteLine("\nPlease choose a hero from the list");
                                        for (int i = 0; i < Guild.Count; i++)
                                        {
                                            Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                                        }
                                        Console.WriteLine("* - Back to main menu");
                                        Console.WriteLine();
                                        string choice1 = Console.ReadLine();
                            
                                        if (choice1 != "*")
                                        {
                                
                                            int.TryParse(choice1, out int chosenNumber);
                                               if (chosenNumber <= Guild.Count && chosenNumber > 0)
                                               {
                                                    Guild[chosenNumber-1].PrintInfo();

                                                   /*bool menu2On = true;
                                                   do
                                                   {
                                                        Console.WriteLine($"\nYou have chosen {Guild[chosenNumber-1].Nickname}");
                                                        Console.WriteLine("\nWhich stats do you wish to see:");
                                                        Console.WriteLine("1 - General information");
                                                        Console.WriteLine("2 - Financial stats");
                                                        Console.WriteLine("* - Back to previous menu");
                                                        Console.WriteLine();
                                                        string menu2 = Console.ReadLine();
                                                            if (menu2 == "1")
                                                            {
                                                                Guild[chosenNumber-1].PrintInfo();
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
                                                            }
                                                            else if (menu2 == "*")
                                                            {
                                                                menu2On = false;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\nInvalid selection. Try again!\n");
                                                            }

                                                   }while (menu2On);
                                                */
                                               }
                                               else
                                               {
                                                   Console.WriteLine("\nInvalid selection. Try again!\n");
                                               }

                                    
                                        }
                                        else if (choice1 == "*")
                                        {
                                            herochoice1 = false;
                                        }
                            
                            

                                    } while (herochoice1);
                                    break;
                                case "2":
                                    bool idsearch = true;
                                    do
                                    {
                                        Console.WriteLine("Enter HeroID number:");
                                        Console.WriteLine("* - return to previous menu");
                                        string idnumber = Console.ReadLine();
                                        if (idnumber == "*")
                                        {
                                            idsearch = false;
                                        }
                                        else if (idnumber !="*")
                                        {
                                            if (int.TryParse(idnumber, out int searchID))
                                            {
                                                var foundID = Guild.Find(find => find.HeroID == searchID);
                                                if (foundID != null)
                                                {
                                                    foundID.PrintInfo();
                                                }
                                                else if (foundID == null)
                                                {
                                                    Console.WriteLine("There are no heroes with this HeroID number. Try again!");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid input! Try again!");
                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input! Try again!");
                                        }

                                        
                                    }while (idsearch);
                                    break;

                                case "3":
                                    bool stringsearch = true;
                                    do
                                    {
                                        Console.WriteLine("Enter hero's name, surname or nickname:");
                                        Console.WriteLine("* - return to previous menu");
                                        string namesearch = Console.ReadLine();
                                        if (namesearch == "*")
                                        {
                                            stringsearch = false;
                                        }
                                        else if (namesearch !="*")
                                        {
                                            

                                            var foundname = Guild.Find(find => find.Name == namesearch);
                                            var foundsurname = Guild.Find(find => find.Surname == namesearch);
                                            var foundnickname = Guild.Find(find => find.Nickname == namesearch);
                                            if (foundname != null)
                                            {
                                                foundname.PrintInfo();
                                            } 
                                            if (foundsurname != null)
                                            {
                                                foundsurname.PrintInfo();
                                            }
                                            if (foundnickname != null)
                                            {
                                                foundnickname.PrintInfo();
                                            }
                                            else if (foundname == null && foundsurname == null && foundsurname == null)
                                            {
                                                Console.WriteLine("There are no heroes with this name, surname or nickname. Try again!");
                                            }
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid input! Try again!");
                                        }


                                    } while (stringsearch);
                                    break;
                                case "*":
                                    parameterchoice = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid input! Try again!");
                                    break;
                            }
                        }while(parameterchoice);
                         break;

                    case "3":
                        Console.WriteLine("Name of the new Superhero:");
                        string newName = Console.ReadLine();
                        Console.WriteLine("Surname of the new Superhero:");
                        string newSurname = Console.ReadLine();
                        Console.WriteLine("Nickname of the new Superhero:");
                        string newNickname = Console.ReadLine();
                        Console.WriteLine($"What is the age of {newName}:");
                        int.TryParse(Console.ReadLine(), out int newAge);
                        Console.WriteLine($"HeroID number the {newName}:");
                        int.TryParse(Console.ReadLine(), out int newHeroID);
                        Console.WriteLine($"If {newName} is a hero  - enter 0, if an antihero = enter 1?");
                        int.TryParse(Console.ReadLine(), out int newTypeint);

                        HeroType newType = (HeroType)newTypeint;
                           
                        Console.WriteLine($"How many hours has {newName} worked?\n");
                        int.TryParse(Console.ReadLine(), out int newDeedTime);
                        Console.WriteLine($"{newName}'s 3 superpowers:");
                        Console.Write($"\n\t1. ");
                        string newPower1 = Console.ReadLine();
                        Console.Write($"\t2. ");
                        string newPower2 = Console.ReadLine();
                        Console.Write($"\t3. ");
                        string newPower3 = Console.ReadLine();

                        Console.WriteLine($"{newName}'s monthly salary:");
                        double.TryParse(Console.ReadLine(), out double newMonthlySalary);

                        Console.WriteLine($"How many cookies does {newName} have?");
                        int.TryParse(Console.ReadLine(), out int newCookies);
                        Console.WriteLine($"{newName}'s total earnings:");
                        double.TryParse(Console.ReadLine(), out double newTotalMoney);

                        Console.WriteLine($"{newName}'s average grade (A-F):");
                        char.TryParse((Console.ReadLine()).ToUpper(), out char newGrade);


                        Hero newHero = new Hero(newName, newSurname, newNickname, newAge, newHeroID,
                            newType, newDeedTime, newPower1, newPower2, newPower3, newMonthlySalary, newCookies,
                            newTotalMoney, newGrade);

                        Guild.Add(newHero);
                        
                        Console.WriteLine($"\nCongratulations! {newName} has joined the Superhero guild!");
                        Console.WriteLine($"\nCurrent Guild heroes are:");

                        for (int i = 0; i < Guild.Count; i++)
                        {
                            Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                        }
                        Console.WriteLine();
                        break;
                    
                    case "4":
                        bool menu3On = true;
                        do
                        {
                            Console.WriteLine("\nWhich hero would you like to remove?");
                            for (int i = 0; i < Guild.Count; i++)
                            {
                                Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                            }
                            Console.WriteLine($"* -  Back to main menu\n");
                            string input1 = Console.ReadLine();
                            Console.WriteLine();
                            if (input1 != "*")
                            {
                                int.TryParse(input1, out int removeNumber);
                                    if (removeNumber <=Guild.Count)
                                    {
                                        Guild.RemoveAt(removeNumber -1);
                                        
                                        Console.WriteLine($"\nThe remaining heroes are:");
                                        for (int i = 0; i < Guild.Count; i++)
                                        {
                                            Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                                        }  


                                    }
                                    else if (removeNumber > Guild.Count+1)
                                    {
                                        Console.WriteLine($"There are only {Guild.Count} heros. Please, choose one of them!");
                                    }
                            
                            } else if (input1 == "*")
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
                            for (int i = 0; i < Guild.Count; i++)
                            {
                                Console.WriteLine($"{i+1} - {Guild[i].Nickname}");
                            }
                            Console.WriteLine($"* - Return to main menu!");
                            Console.WriteLine();
                       
                            string herochoice = Console.ReadLine();

                            if (herochoice != "*")
                            {
                                int.TryParse(herochoice, out int rateHero);
                                Console.WriteLine();
                                if (rateHero <= Guild.Count && rateHero >0)
                                {
                                    bool ratingOn = true;
                                    do
                                    {

                                        Console.WriteLine($"\nHow would you rate {Guild[rateHero-1].Nickname}?");
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
                                            Console.WriteLine($"Thank you! This made {Guild[rateHero-1].Nickname} happy! :) \n");
                                            ratingOn = false;
                                        }
                                        else if (grade == 'C')
                                        {
                                            Console.WriteLine($"{Guild[rateHero-1].Nickname} will do better next time! :| \n");
                                            ratingOn = false;
                                        }
                                        else if (grade == 'D' || grade == 'E')
                                        {
                                            Console.WriteLine($"{Guild[rateHero-1].Nickname} just had a bad day :( \n");
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
                                }
                                else 
                                {
                                    Console.WriteLine("Wrong number! Pick a hero from the list!");
                                    Console.WriteLine();
                                }
                            } 
                            else if (herochoice == "*")
                            {
                                herolist = false;
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
