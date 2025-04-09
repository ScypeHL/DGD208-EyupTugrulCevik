using GameProgramming2Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pro
{
    public class PlayerController
    {
        private const int number = 2;
        private const string colour = "purpur";
        
        private AttackSystem aSys;
        private FoodSystem fSys;
        private ClothSystem cSys;
        private DeathSystem dSys;

        // Complicated way (Manual way)
        public event EventHandler<AttackEventArgs> attackHappened;
        
        // Easier way
        public event Action<int> attackCompleted;
        public event Action<int, string> whichCloth;
        public event Action playerDeath;

        #region Delegate
        // public Action<int> _attack;
        // public Func<int, string> _feed;

        // public delegate void PlayerAttack(int i);
        // private PlayerAttack? attack;

        // public delegate void PlayerFeed(int times);
        // private PlayerFeed feed;
        #endregion

        public PlayerController() 
        { 
            fSys = new FoodSystem();
            aSys = new AttackSystem(this);
            cSys = new ClothSystem(this);
            dSys = new DeathSystem(this);

            #region DelegateStuff
            // _attack = aSys.AttackWithGun;
            // _attack = _attack + aSys.AttackWithSword;

            // _feed = fSys.EatBread;
            #endregion
        }

        public void start()
        {
            // _attack = _attack - aSys.AttackWithSword;
            // Console.WriteLine(_feed(2));
            
            execute(number);
        }

        public void execute(int times)
        {
            // [Delegate]
            // Console.WriteLine("------------");
            // _attack?.Invoke(times);
            // _feed.Invoke(times);

            // [EventHandler]
            // int attackTypeCode = 0;
            // AttackEventArgs attackEventArg = new AttackEventArgs(attackTypeCode);
            // attackHappened?.Invoke(this, attackEventArg);

            // [Event Action]
            attackCompleted?.Invoke(number);
            whichCloth?.Invoke(number, colour);
            playerDeath?.Invoke();
            playerDeath?.Invoke();
        }
    }

    // Used only with [EventHandler]
    public class AttackEventArgs : EventArgs
    {
        public int AttackType { get; }

        public AttackEventArgs(int attackType)
        {
            AttackType = attackType;
        }

    }
}
