using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Units
{
    public class HumanMeleeUnit:MeleeUnit
    {
        public HumanMeleeUnit(int Health, int Power)
        {
            this.Health = Health;
            this.Power = Power;
        }
        public HumanMeleeUnit()
        {
            this.Health = 10;
            this.MaxHealth = 10;
            this.Power = 2;
        }
    }
}
