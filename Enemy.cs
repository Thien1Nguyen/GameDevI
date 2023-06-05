public class Enemy
{
    public string Name;
    int Health;

    public int _Health;
    List<Attack> AttackList;

    Random rand = new Random();

    public Enemy(string name, int health, List<Attack> attackList)
    {
        Name = name;
        Health = health;
        _Health = Health;
        AttackList = attackList;
    }

    public string RandomAttack()
    {
        return AttackList[rand.Next(AttackList.Count)].Name;
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public void ShowAttackList()
    {
        AttackList.ForEach(attack => Console.WriteLine(attack.Name));
    }
}