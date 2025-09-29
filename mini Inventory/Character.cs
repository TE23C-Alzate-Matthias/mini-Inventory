using System.Reflection.Metadata;

public class Character
{
    public int hp;
    public string name;
    public Inventory backpack;

    public Character()
    {
        backpack = new();

        Weapon sword = new() { name = "Sword", weight = 10f };
        Consumable potion = new() { name = "Healing Potion", weight = 3f };

        backpack.Items.Add(sword);
        backpack.Items.Add(potion);

        hp = 100;
        name = "Bob";
    }
}
