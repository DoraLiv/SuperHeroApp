// See https://aka.ms/new-console-template for more information
namespace SuperHeroApp
{ internal class Program
    { static void Main(string[] args)
        { string name = "Anti";
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
/*
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
*/
            //The deed grading

            Console.WriteLine("~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~\n"); 
            Console.WriteLine("DA DEED!! What did you do?? How well did you do it?\n");

            Console.WriteLine("How would you grade my deed? (Enter a grade A - G)");
            char deedgrade = Char.ToUpper(char.Parse(Console.ReadLine()));
            switch (deedgrade)
            {
                case 'A':
                case 'B':
                    Console.WriteLine("Perfect! You are so brave!");
                    break;
                case 'C':
                    Console.WriteLine("Good! But You can do better!");
                    break;
                case 'D':
                case 'E':
                    Console.WriteLine("It is not good! You should choose your bad or good side!");
                    break;
                case 'F':
                    Console.WriteLine("You have FAILED!");
                    break;
                case 'G':
                    Console.WriteLine("Bad, you are true villain!");
                    break;
                case 'H':
                    Console.WriteLine("You are going straight to HELL!");
                    break;
                default:
                    Console.WriteLine("No one can be THAT bad!!? O.O");
                    break;

            }
        }
    }
}
