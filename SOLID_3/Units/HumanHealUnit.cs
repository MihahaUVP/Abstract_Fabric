using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Units
{
    public class HumanHealUnit:HealUnit
    {
        HumanHealUnit(int Health, int Power)
        {
            this.MaxHealth = Health;
            this.Health = Health;
            this.Power = Power;
        }
        public HumanHealUnit()
        {
            this.MaxHealth = 10;
            this.Health = 10;
            this.Power = 2;
        }
    }
}
