// See https://aka.ms/new-console-template for more information

using SOLID_3.Fabrics;
using SOLID_3.Game;

AbstractFabric fabric1 = new HumanFabric();
AbstractFabric fabric2 = new DwarfFabric();

Battle Battle = new Battle(fabric1, fabric2);
Battle.StartBattle();
