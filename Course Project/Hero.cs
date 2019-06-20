using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Project
{
    class Hero
    {
        private Item[] items = new Item[4];

        protected String name;
        protected int intel;
        protected int agil;
        protected int strike;
        protected int power;
        protected int health;
        public Hero(String name, int intel, int agil, int strike, int power, int health)
        {
            this.name = name;
            this.intel = intel;
            this.agil = agil;
            this.strike = strike;
            this.power = power;
            this.health = health;
            
            items[0] = new Item("Club", 0, 2, 4);
            items[1] = new Item("Bow", 1, 4, 1);
            items[2] = new Item("Cane", 4, 2, 0);
            items[3] = new Item("None", 0, 0, 0);
        }
        public String getName()
        {
            return name;
        }
        public int getIntel()
        {
            return intel;
        }
        public int getAgil()
        {
            return agil;
        }
        public int getStrike()
        {
            return strike;
        }
        public int getPower()
        {
            return power;
        }
        public int getHealth()
        {
            return health;
        }
        public virtual int changeHealth()
        {
            return health;
        }
        Random random1 = new Random();
        Random random2 = new Random();
        private int rnd1;
        private int rnd2;
        public void setRnd1()
        {
            rnd1 = random1.Next(0, items.Length);
        }
        public int getRnd1()
        {
            return rnd1;
        }
        public void setRnd2()
        {
            rnd2 = random2.Next(0, items.Length);
        }
        public int getRnd2()
        {
            return rnd2;
        }
        public String getItemName1()
        {
            return items[getRnd1()].getName();
        }
        public int getItemIntel1()
        {
            return items[getRnd1()].getIntel();
        }
        public int getItemAgil1()
        {
            return items[getRnd1()].getAgil();
        }
        public int getItemStrike1()
        {
            return items[getRnd1()].getStrike();
        }
        public String getItemName2()
        {
            return items[getRnd2()].getName();
        }
        public int getItemIntel2()
        {
            return items[getRnd2()].getIntel();
        }
        public int getItemAgil2()
        {
            return items[getRnd2()].getAgil();
        }
        public int getItemStrike2()
        {
            return items[getRnd2()].getStrike();
        }
        public int getPlusItem1()
        {
            return items[getRnd1()].plusItem();
        }
        public int getPlusItem2()
        {
            return items[getRnd1()].plusItem();
        }
    }
    class Timbersaw : Hero
    {
        public Timbersaw(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return strike / 2 + intel / 4 + agil / 4 + power / 2;
        }
    }
    class Axe : Hero
    {
        public Axe(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return strike / 2 + intel / 4 + agil / 4 + power / 2;
        }
    }
    class Spectre : Hero
    {
        public Spectre(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return agil / 2 + strike / 4 + intel / 4 + power / 2;
        }
    }
    class Jakiro : Hero
    {
        public Jakiro(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return intel / 2 + agil / 4 + agil / 4 + power / 2;
        }
    }
    class Dazzle : Hero
    {
        public Dazzle(String name, int intel, int agil, int strike, int power, int health) : base(name, intel, agil, strike, power, health)
        {

        }
        public override int changeHealth()
        {
            return intel / 2 + agil / 4 + agil / 4 + power / 2;
        }
    }
}
