// See https://aka.ms/new-console-template for more information
List<Attack> zedAttacks = new List<Attack>();
Attack q = new Attack("Razor Shuriken", 650);
Attack w = new Attack("Living Shadow", 1200);
Attack e = new Attack("Shadow Slash", 550);
Attack r = new Attack("Death Mark", 3000);

zedAttacks.Add(q);
zedAttacks.Add(w);
zedAttacks.Add(e);


Enemy zed = new Enemy("zed", 2700, zedAttacks);

Console.WriteLine(zed.RandomAttack()); 
Console.WriteLine(zed._Health);

zed.AddAttack(r);

zed.ShowAttackList();


