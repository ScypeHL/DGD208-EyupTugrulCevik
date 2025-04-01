using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class PlayerController
    {
        private AttackSystem aSys;
        private FoodSystem fSys;

        public delegate void PlayerAttack(int i);
        private PlayerAttack? attack;

        public delegate void PlayerFeed();
        private PlayerFeed feed;

        public PlayerController() 
        { 
            fSys = new FoodSystem();
            aSys = new AttackSystem();

            attack = aSys.AttackWithGun;
            attack = attack + aSys.AttackWithSword;

            feed = fSys.EatBread;
        }

        public void start()
        {
            ifExecuted(4);
            attack = attack - aSys.AttackWithSword;
            ifExecuted(5);


            feed();
        }

        private void ifExecuted(int times)
        {
            Console.WriteLine("------------");
            attack?.Invoke(times);
        }
    }
}
