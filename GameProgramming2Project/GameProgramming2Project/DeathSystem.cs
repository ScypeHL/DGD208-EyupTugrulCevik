using Pro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming2Project
{
    internal class DeathSystem
    {
        private PlayerController pc;
        public DeathSystem(PlayerController _pc) 
        {
            pc = _pc;
            pc.playerDeath += kill;
        }

        public void kill()
        {
            Console.WriteLine("Player is dead");
            pc.playerDeath -= kill;
        }
    }
}
