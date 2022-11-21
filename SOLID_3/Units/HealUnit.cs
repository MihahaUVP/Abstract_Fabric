using SOLID_3.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3
{
    public class HealUnit:Unit
    {
        //public int Power { get; private set; }
        public void Heal(Unit target)
        {
            target.Health += Power;
            if (target.Health > target.MaxHealth)
                target.Health = target.MaxHealth;
        }
    }
}
