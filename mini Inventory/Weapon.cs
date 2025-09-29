public class Weapon : Item
{
    public int minDamage = 10;
    public int maxDamage = 31;

    public int Attack()
    {
        return Random.Shared.Next(minDamage, maxDamage);
    }
}
