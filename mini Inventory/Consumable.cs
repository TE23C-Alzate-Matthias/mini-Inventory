public class Consumable : Item
{
    public int maxUses = 3;
    public int currentUses = 3;

    public void Use(Character p)
    {
        if (currentUses > 0)
        {
            p.hp += Random.Shared.Next(10, 26);
            Console.WriteLine($"Your hp is now {p.hp}");
            currentUses--;
            Console.WriteLine($"You have {currentUses} left");
        }
        else
        {
            Console.WriteLine("You have no more uses for your potion");
        }
    }
}
