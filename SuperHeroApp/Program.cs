// See https://aka.ms/new-console-template for more information
namespace SuperHeroApp
{ internal class Program
    { static void Main(string[] args)
        { string name = "Anti";
            int age = 428;
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Telepathically breaking and blowing up things";
            heroPower2 = "X-ray vision";
            heroPower3 = "Eating unlimited amounts of chocolate";
            Console.WriteLine("~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~");
            Console.WriteLine("\n\n        THE LEGEND OF THE ANTI HERO");
            Console.WriteLine("\n\n~~~~~~~~*****~~~~~~~*****~~~~~~~*****~~~~~~~");
            Console.WriteLine($"\n\nName : {name}");
            Console.WriteLine("\nAge : " + age);
            Console.WriteLine($"\nHero Powers :\n  *{heroPower1} \n  *{heroPower2} \n  *{heroPower3}\n\n\n\n\n");                       }
    }
}
