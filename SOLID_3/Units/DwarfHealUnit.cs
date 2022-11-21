﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Units
{
    public class DwarfHealUnit:HealUnit
    {
        public DwarfHealUnit()
        {
            MaxHealth = 7;
            Health = 7;
            Power = 3;
        }
    }
}
