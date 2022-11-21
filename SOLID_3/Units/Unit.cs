using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Units
{
    public abstract class Unit
    {
        public void getDamage(int damage)
        {
            Health -= damage;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
    }
}
