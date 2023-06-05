// See https://aka.ms/new-console-template for more information
List<Attack> zedAttacks = new List<Attack>();
Attack q = new Attack("Razor Shuriken", 10);
Attack w = new Attack("Living Shadow", 17);
Attack e = new Attack("Shadow Slash", 7);
Attack r = new Attack("Death Mark", 25);

zedAttacks.Add(q);
zedAttacks.Add(w);
zedAttacks.Add(e);


Enemy zed = new Enemy("zed", zedAttacks);

Console.WriteLine(zed.RandomAttack()); 
Console.WriteLine(zed._Health);

zed.AddAttack(r);

zed.ShowAttackList();


