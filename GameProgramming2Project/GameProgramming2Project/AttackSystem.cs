using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class AttackSystem
    {    
        public void AttackWithGun(int times)
        {
            Console.WriteLine($"Player attacks with gun {times} times");
        }

        public void AttackWithSword(int times)
        {
            Console.WriteLine($"Player attacks with {times} sword");
        }
    }
}
