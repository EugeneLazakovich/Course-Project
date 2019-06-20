using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Project
{
    class Item
    {
        protected String name;
        protected int intel;
        protected int agil;
        protected int strike;
        public Item(String name, int intel, int agil, int strike)
        {
            this.name = name;
            this.intel = intel;
            this.agil = agil;
            this.strike = strike;
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
        public int plusItem()
        {
            return intel + agil + strike;
        }
    }    
}
