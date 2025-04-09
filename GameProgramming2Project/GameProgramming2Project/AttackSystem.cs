using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class AttackSystem
    {    
        public AttackSystem(PlayerController pc) 
        {
            // pc.attackHappened += Attack;
            pc.attackCompleted += Attack;
        }
        
        public void AttackWithGun()
        {
            Console.WriteLine($"Player attacks with gun");
        }

        public void AttackWithSword()
        {
            Console.WriteLine($"Player attacks with sword");
        }

        public void AttackWithFist()
        {
            Console.WriteLine($"Player attacks with fists");
        }

        // [EventHanlder] (object sender, AttackEventArgs e)
        public void Attack(int attackType)
        {
            switch (attackType)
            {
                case 0:
                    AttackWithGun();
                    break;
                case 1:
                    AttackWithSword();
                    break;
                default:
                    AttackWithFist();
                    break;
            }
        }
    }
}
