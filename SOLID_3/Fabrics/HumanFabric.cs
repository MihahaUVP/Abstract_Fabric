using SOLID_3.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Fabrics
{
    internal class HumanFabric:AbstractFabric
    {
        public MeleeUnit CreateMeleeUnit()
        {
            return new HumanMeleeUnit();
        }

        public RangeUnit CreateRangeUnit()
        {
            return new HumanRangeUnit();
        }

        public HealUnit CreateHealUnit()
        {
            return new HumanHealUnit();
        }
    }
}
