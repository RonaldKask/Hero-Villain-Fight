using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Batman", "Lara Croft" };
            string[] villains = { "Voldemort", "Harley Quinn", "Joker", "Darth Vader", "Venom"};

            string hero = GetCharacter(heroes);
            string villain = GetCharacter(villains);


            int heroHP = GenerateHP();
            int villainHP = GenerateHP();

            Console.WriteLine($"{hero} with {heroHP} HP will fight {villain} with {villainHP} HP.");

            while (heroHP > 0 && villainHP > 0)
            {
                /*Random rnd = new Random();
                heroHP = heroHP - rnd.Next(0, 4);
                villainHP = villainHP - rnd.Next(0, 4);*/
                heroHP = heroHP - FightToDeath(hero);
                villainHP = villainHP - FightToDeath(villain);
            }

            /*if(heroHP == 0)
            {
                Console.WriteLine("Evil is victorious!");
            }else
            {
                Console.WriteLine($"{hero} wins and justice prevails!");
            }*/
            Getwinner(heroHP, villainHP);
        }

        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;

        }

        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        }

        public static int FightToDeath(string character)
        {
            
            Random rnd = new Random();
            int strike = rnd.Next(0, 4);
            Console.WriteLine($"{character} hit {strike}!");

            if (strike == 0)
            {
                Console.WriteLine("Bad luck! Missed the target!");
            }else if (strike == 3)
            {
                Console.WriteLine("Ouch, that's a critical hit!");
            }
            return strike;
        }

        public static void Getwinner(int hHP, int vHP)
        {
            if (hHP == 0)
            {
                Console.WriteLine("Dark sdie wins");
            }
            else
            {
                Console.WriteLine("Hero wins the day");
            }
        }


    }
}
