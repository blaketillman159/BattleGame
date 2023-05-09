using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleGame
{
    /// <summary>
    /// Hős
    /// </summary>
    public class Hero
    {
        public int Id { get; private set; }
        public int MaxHealt { get; init; }
        public bool IsAlive { get; private set; } = true;

        private int health;
        public int Health
        {
            get { return health; }
            set {
                if (health != value){ health = value; }
                if(health <= (MaxHealt / 4))
                {
                    Console.WriteLine($"[{Id}] {this.GetType().Name} Died");
                    IsAlive = false;
                }
            }
        }


        public Hero() { 
            Id = new Random().Next();
        }
        /// <summary>
        /// Megtámad valakit
        /// </summary>
        /// <param name="opponent">Ellenfél</param>
        public virtual void Attack(Hero opponent)
        {
            Console.WriteLine($"[{Id}] {this.GetType().Name} attack -> [{opponent.Id}] {opponent.GetType().Name}");
            this.DecreseHealth();
            opponent.DecreseHealth();
        }

        /// <summary>
        /// Hős tulajdonságai
        /// </summary>
        public void ToDetails()
        {
            Console.WriteLine($"[{Id}] {this.GetType().Name}, Health: {Health}");
        }

        /// <summary>
        /// Életerő regenerálódik
        /// </summary>
        internal void Rest()
        {
            int computedHealt = Health + 10;
            if (computedHealt > MaxHealt)
            {
                Health = MaxHealt;
            }
            else
            {
                Health = computedHealt;
            }
        }

        /// <summary>
        /// Életerő felére csökken
        /// </summary>
        internal void DecreseHealth()
        {
            int newValue = Health / 2;
            Console.WriteLine($"[{Id}] {this.GetType().Name} Health: {Health} -> {newValue}");
            Health = newValue;

        }

        /// <summary>
        /// Meghal
        /// </summary>
        internal void Die()
        {
            IsAlive = false;
            Console.WriteLine($"[{Id}] {this.GetType().Name} died");
        }
    }
}
