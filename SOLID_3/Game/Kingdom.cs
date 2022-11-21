using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Game
{
    public class Kingdom
    {
        public Kingdom(RangeUnit rangeUnit,MeleeUnit meleeUnit,HealUnit healUnit,string Name) 
        {
            this.HealUnit = healUnit;
            this.MeleeUnit = meleeUnit;
            this.RangeUnit = rangeUnit;
            this.Name = Name;
        }
        public RangeUnit RangeUnit { get; set; }
        public MeleeUnit MeleeUnit { get; set; }
        public HealUnit HealUnit { get; set; }
        public string Name { get; set; }
        public int GetPoints() 
        {
            int res;
            res = RangeUnit.Health + MeleeUnit.Health + HealUnit.Health;
            return res;
        }
    }
}
