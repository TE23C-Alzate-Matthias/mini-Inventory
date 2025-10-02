Character player = new();

Armor helmet = new() { name = "Bronze helmet", weight = 5f, protection = 10f };

player.backpack.Display();

Console.WriteLine($"You foud a {helmet.name}, do you want to pick it up?");

string choice = "";

while (choice != "yes" && choice != "no")
{
    choice = Console.ReadLine().ToLower();
}

if (choice == "yes")
{
    Console.WriteLine($"You picked up the {helmet.name}");
    player.backpack.Items.Add(helmet);
}
else
{
    Console.WriteLine("You decided to leave it be");
}
Console.ReadLine();

Console.WriteLine("Your current items are:");
player.backpack.Display();
Console.ReadLine();
Console.Clear();

while (choice != "3")
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1) Use potion");
    Console.WriteLine("2) Display Backpack");
    Console.WriteLine("3) Exit");
    choice = Console.ReadLine();
    if (choice == "1")
    {
        player.potion.Use(player);
    }
    else if (choice == "2")
    {
        player.backpack.Display();
    }
    else if (choice == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("That is not an option");
    }
    Console.ReadLine();
    Console.Clear();
}

Console.ReadLine();