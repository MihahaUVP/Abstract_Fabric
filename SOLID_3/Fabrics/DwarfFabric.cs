using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID_3.Units;
namespace SOLID_3.Fabrics
{
    public class DwarfFabric : AbstractFabric
    {
        public HealUnit CreateHealUnit()
        {
            DwarfHealUnit dwarfHeal = new DwarfHealUnit();
            return dwarfHeal;
        }

        public MeleeUnit CreateMeleeUnit()
        {
            DwarfMeleeUnit dwarfMelee = new DwarfMeleeUnit();
            return dwarfMelee;
        }

        public RangeUnit CreateRangeUnit()
        {
            DwarfRangeUnit dwarfRange = new DwarfRangeUnit();
            return dwarfRange;
        }
    }
}
