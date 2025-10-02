public class Character
{
    public int hp;
    public string name;
    public Inventory backpack;
    public Weapon sword;
    public Consumable potion;
    public Character()
    {
        backpack = new();

        sword = new() { name = "Sword", weight = 10f };
        potion = new() { name = "Healing Potion", weight = 3f };

        backpack.Items.Add(sword);
        backpack.Items.Add(potion);

        hp = 100;
        name = "Bob";
    }
}
