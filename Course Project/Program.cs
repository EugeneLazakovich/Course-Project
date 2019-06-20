using System;

namespace Course_Project
{        
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();

            battle.setRnd1();
            battle.setRnd2();
            battle.setItemRnd1();
            battle.setItemRnd2();
            battle.getStartInfo();
            battle.setParams();
            battle.fightHero();
            battle.getFinishInfo();
        }
    }
}
