using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroApp
{
    public enum HeroType
    {
        Hero,
        Antihero
    }
    internal class Hero
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public int HeroID { get; set; }
        public HeroType HeroType { get; set; }
        public int DeedTime { get; set; }
        public string Power1 { get; set; }
        public string Power2 { get; set; }
        public string Power3 { get; set; }
        public double MonthlySalary { get; set; }
        public int Cookies { get; set; }
        public double TotalMoney { get; set; }
        public char Grade { get; set; }

        //prop tab tab -> public property
        //propfull tab tab -> private property, needs method to set values; to fide info from others,
        //+can add validation

        public Hero() //no-arg constructor
        {
            this.Name = "unknown";
            this.Surname = "unknown";
            this.Nickname = "unknown";
            this.Age = 1;
            this.HeroID = 0;
            this.HeroType = HeroType.Hero;
            this.DeedTime = 1;
            this.Power1 = "unknown";
            this.Power2 = "unknown";
            this.Power3 = "unknown";
            this.MonthlySalary = 0;
            this.Cookies = 0;
            this.TotalMoney = 0;
            this.Grade = 'C';
        }

        public Hero(string name, string surname, string nickname, int age, int heroID, HeroType heroType, int deedTime,
            string power1, string power2, string power3, double monthlySalary, int cookies, double totalMoney, char grade)
        //arg constructor
        {
            Name = name;
            Surname = surname;
            Nickname = nickname;
            Age = age;
            HeroID = heroID;
            HeroType = heroType;
            DeedTime = deedTime;
            Power1 = power1;
            Power2 = power2;
            Power3 = power3;
            MonthlySalary = monthlySalary;
            Cookies = cookies;
            TotalMoney = totalMoney;
            Grade = grade;

        }
                public int CalculatedLevel()
                {
                    int level = 0;
                    if(DeedTime < 20)
                    {
                        level = 1;
                    }
                    if (DeedTime >= 20 && DeedTime <40)
                    {
                        level = 2;
                    }
                    if (DeedTime >=40)
                    {
                        level=3;
                    }
                    return level;   
                }
        public void PrintInfo() //method -> what happens
        {
            Console.WriteLine($"Hero Info:\n"
                + $"\tHero name: {Name} \"{Nickname}\" {Surname}\n"
                + $"\tHero age: {Age} years\n"
                + $"\tHero ID number: {HeroID}\n"
                + $"\tHero/Antihero: {HeroType}\n"
                + $"\tSuperpowers: \n\t\t1. {Power1}  \n\t\t2. {Power2}  \n\t\t3. {Power3}\n"
                + $"\tTotal time spent working: {DeedTime} hours\n"
                + $"\tLevel: {CalculatedLevel()}\n"
                + $"\tMonthly salary: {MonthlySalary} monies\n"
                + $"\tTotal earnings: {TotalMoney} monies and {Cookies} cookies\n"
                + $"\tAverage rating: {Grade}");
        }

        public void Ate(int cookies)
        {
            cookies += Cookies;
        }

        
    }

    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }

        public int DistrictID { get; set; }
        public List<Hero> HeroesInTheDistrict { get; set; }

        public District()
        {
            this.Title = "not determined";
            this.City = "not determined";
            this.DistrictID = 0;
            this.HeroesInTheDistrict = new List<Hero>();
        }

        public District(string title, string city, int districtID, List<Hero> herosinthedistrict)
        {
            Title = title;
            City = city;
            DistrictID = districtID;
            HeroesInTheDistrict = herosinthedistrict;
        }
        //public string toString();
        
        //bool addNewHero();

        //Hero removeHero(int index);

        //float calculateAvgLevelInDistrict();


    }

}
