using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Fabrics
{
    public interface AbstractFabric
    {
        public MeleeUnit CreateMeleeUnit();
        public RangeUnit CreateRangeUnit();
        public HealUnit CreateHealUnit();
    }
}
