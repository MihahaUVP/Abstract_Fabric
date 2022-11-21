using SOLID_3.Fabrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_3.Game
{
    public class Battle
    {
        Kingdom kingdom1 { get; set; }
        Kingdom kingdom2 { get; set; }
        public Battle(AbstractFabric abstractFabric1, AbstractFabric abstractFabric2)
        {
            kingdom1 = new Kingdom(abstractFabric1.CreateRangeUnit(), abstractFabric1.CreateMeleeUnit(), abstractFabric1.CreateHealUnit(),"name1");

            kingdom2 = new Kingdom(abstractFabric2.CreateRangeUnit(), abstractFabric2.CreateMeleeUnit(), abstractFabric2.CreateHealUnit(),"name 2");

        }
        public void StartBattle()
        {
            kingdom1.HealUnit.Heal(kingdom1.MeleeUnit);
            kingdom1.MeleeUnit.MeleeAtack(kingdom2.RangeUnit);
            kingdom1.RangeUnit.RangeAtack(kingdom2.MeleeUnit);

            kingdom2.HealUnit.Heal(kingdom2.RangeUnit);
            kingdom2.MeleeUnit.MeleeAtack(kingdom1.RangeUnit);
            kingdom2.RangeUnit.RangeAtack(kingdom1.HealUnit);


            int kingdom1Points;
            int kingdom2Points;

            kingdom1Points = kingdom1.GetPoints();
            kingdom2Points = kingdom2.GetPoints();
            if (kingdom1Points > kingdom2Points)
            {
                Console.WriteLine("Победило королевство 1");
            }
            else
                Console.WriteLine("Победило королевство 2");
        }
    }
}
