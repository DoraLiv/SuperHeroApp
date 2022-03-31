// See https://aka.ms/new-console-template for more information
using SuperHeroApp;

List<Hero> heroesindistrict1 = new List<Hero>();
List <Hero> heroesindistrict2 = new List<Hero>();
District district1 = new District("Pin", "Kern", 34, heroesindistrict1);
District district2 = new District("Nur", "Beadrem", 27, heroesindistrict2);
Hero hero1 = new Hero("Annie", "Time", "Anti", 428, 007, HeroType.Antihero, 974, "Telepathically breaking and blowing up things",
               "Time manipulation", "Eating unlimited amounts of cookies", 30, 2000, 1452, 'A');
Hero hero2 = new Hero("Paul", "Neige", "Peng", 35, 003, HeroType.Hero, 25, "Freezing breath", "Killer looks", "Future prediction",
    150, 3, 1649982, 'A');
Hero hero3 = new Hero("John", "Runner", "Kylo", 19, 189, HeroType.Antihero, 4, "The Force", "Lightsaber fighting skills",
    "Math", 65, 3, 674, 'E');
Hero hero4 = new Hero("John", "Valentine", "Evron", 40, 057, HeroType.Antihero, 13, "Persuasion", "Perfect vision",
"Killer voice", 80, 54, 10453, 'B');
Hero hero5 = new Hero("Oliver", "Ray", "Bummer", 12, 86, HeroType.Hero, 2, "X-ray vision", "Levitation", "Fireball", 
    10, 2, 37, 'E');
Hero hero6 = new Hero("Adrien", "English", "Dot", 33, 248, HeroType.Hero, 29, "Fast reading", "Perfect visual memory",
    "Multilinguist", 69, 73, 28965, 'C');
Hero hero7 = new Hero("Nanon", "Pran", "Triple N", 20, 439, HeroType.Hero, 19, "Facial recognision", "Sonic punch", "Invisibility",
    47, 90, 8743, 'B');
heroesindistrict1.Add(hero1);
heroesindistrict1.Add(hero5);
heroesindistrict1.Add(hero6);
heroesindistrict1.Add(hero7);
heroesindistrict2.Add(hero2);
heroesindistrict2.Add(hero3);
heroesindistrict2.Add(hero4);

