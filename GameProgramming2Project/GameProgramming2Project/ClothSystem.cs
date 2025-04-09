using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    internal class ClothSystem
    {
        public ClothSystem(PlayerController pc)
        {
            pc.whichCloth += (int count, string colour) =>
            {
                Console.WriteLine($"I have {count} {colour} coat");
            };
        }

        private void wear()
        {
            Console.WriteLine("I am wearing a coat");
        }
    }
}
