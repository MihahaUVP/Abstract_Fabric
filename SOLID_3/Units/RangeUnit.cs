﻿using SOLID_3.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3
{
    public class RangeUnit:Unit
    {
        //public int Power { get; private set; }
        public void RangeAtack(Unit target)
        {
            target.getDamage(Power);
        }
    }
}
