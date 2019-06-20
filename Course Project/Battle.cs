using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Course_Project
{
    class Battle
    {        
        private Hero[] heroes = new Hero[5];
                
        private int health1;        
        private int health2;

        public Battle()
        {
            heroes[0] = new Timbersaw("Timbersaw", 23, 16, 23, 26, 587);
            heroes[1] = new Axe("Axe", 18, 20, 25, 27, 625);
            heroes[2] = new Spectre("Spectre", 16, 23, 23, 23, 587);
            heroes[3] = new Jakiro("Jakiro", 26, 10, 27, 27, 663);
            heroes[4] = new Dazzle("Dazzle", 25, 21, 18, 22, 492);
        }
        Random random1 = new Random();
        Random random2 = new Random();
        private int rnd1;
        private int rnd2;
        public void setRnd1()
        {
            rnd1 = random1.Next(0, heroes.Length);
        }        
        public int getRnd1()
        {            
            return rnd1;
        }
        public void setRnd2()
        {
            rnd2 = random2.Next(0, heroes.Length);
        }
        public int getRnd2()
        {
            return rnd2;
        }
        public void setItemRnd1()
        {
            heroes[getRnd1()].setRnd1();
        }
        public void setItemRnd2()
        {
            heroes[getRnd2()].setRnd2();
        }
        public void getStartInfo()
        {            
            Console.WriteLine(heroes[getRnd1()].getName() + " with " + heroes[getRnd1()].getItemName1() + " vs " + heroes[getRnd2()].getName() + " with " + heroes[getRnd2()].getItemName2());
            Console.WriteLine(heroes[getRnd1()].getName() + ": Inteligence: " + heroes[getRnd1()].getIntel());
            Console.WriteLine("\t" + ": Agility: " + heroes[getRnd1()].getAgil());
            Console.WriteLine("\t" + ": Strike: " + heroes[getRnd1()].getStrike());
            Console.WriteLine("\t" + ": Power: " + heroes[getRnd1()].getPower());
            Console.WriteLine("\t" + ": Health: " + heroes[getRnd1()].getHealth());
            Console.WriteLine(heroes[getRnd1()].getItemName1() + ": Inteligence: " + heroes[getRnd1()].getItemIntel1());
            Console.WriteLine("\t" + ": Agility: " + heroes[getRnd1()].getItemAgil1());
            Console.WriteLine("\t" + ": Strike: " + heroes[getRnd1()].getItemStrike1());
            Console.WriteLine(heroes[getRnd2()].getName() + ": Inteligence: " + heroes[getRnd2()].getIntel());
            Console.WriteLine("\t" + ": Agility: " + heroes[getRnd2()].getAgil());
            Console.WriteLine("\t" + ": Strike: " + heroes[getRnd2()].getStrike());
            Console.WriteLine("\t" + ": Power: " + heroes[getRnd2()].getPower());
            Console.WriteLine("\t" + ": Health: " + heroes[getRnd2()].getHealth());
            Console.WriteLine(heroes[getRnd2()].getItemName2() + ": Inteligence: " + heroes[getRnd2()].getItemIntel2());
            Console.WriteLine("\t" + ": Agility: " + heroes[getRnd2()].getItemAgil2());
            Console.WriteLine("\t" + ": Strike: " + heroes[getRnd2()].getItemStrike2());
        }
        public void setParams()
        {            
            health1 = heroes[getRnd1()].getHealth();            
            health2 = heroes[getRnd2()].getHealth();
        }
        public void fightHero()
        {
            do
            {
                health1 -= heroes[getRnd2()].changeHealth() + heroes[getRnd2()].getPlusItem2();
                health2 -= heroes[getRnd1()].changeHealth() + heroes[getRnd1()].getPlusItem1();
                if (health1 < 0)
                {
                    health1 = 0;
                }
                if (health2 < 0)
                {
                    health2 = 0;
                }
                Console.WriteLine();
                Console.WriteLine(heroes[getRnd1()].getName() + " hit " + heroes[getRnd2()].getName() + ": " + heroes[getRnd1()].changeHealth());
                Console.WriteLine(heroes[getRnd2()].getName() + "'s health: " + health2);
                Console.WriteLine(heroes[getRnd2()].getName() + " hit " + heroes[getRnd1()].getName() + ": " + heroes[getRnd2()].changeHealth());
                Console.WriteLine(heroes[getRnd1()].getName() + "'s health: " + health1);
                Thread.Sleep(1000);
            } while (health1 > 0 && health2 > 0);
        }
        public void getFinishInfo()
        {
            Console.WriteLine();
            if (health1 == 0)
            {
                Console.WriteLine(heroes[getRnd2()].getName() + " IS WINNER!!!");
            }
            else
            {
                Console.WriteLine(heroes[getRnd1()].getName() + " IS WINNER!!!");
            }
        }
    }
}
