/*
    Abstract classes
    --------------------
    Order:
    - In-class assignment: StartKnight
    - Player: introduction to abstract classes
    - Knight: inheriting an abstract class
    - Monster: student exercise
    - Program: abstract classes types
*/
public class Program
{
    static void Main(string[] args)
    {
        // Player p = new Player("Tim", 1000); // Error!!! Class Player is abstract.
        List<Player> players = [
            new Knight("Sir Lancelot", 100,
                new Weapon("Lance", 10), null!),
            new Knight("Brienne of Tarth", 150,
                new Weapon("Sword", 15), new Armor("Shield", 3)),
            new Monster("Dracula", 50),
            new Monster("Snake", 5)
        ];

        foreach (var player in players)
        {
            player.MoveRight(5);
            Console.WriteLine($"{player.Name} is at {player.CurrentPosition}");
            Console.WriteLine($"{player.Name} has {player.CurrentHitPoints}");
            player.Defend(10);
            Console.WriteLine($"After an attack {player.Name} has {player.CurrentHitPoints}");
            Console.WriteLine($"They attack with {player.Attack()} points");
            
            if (player is Knight knight)
            {
                Console.WriteLine($"They attack with a {knight.EquippedWeapon.Name}");
            }

            Dance(player);
            Console.WriteLine();
        }
    }

    public static void Dance(Player player){
        Console.WriteLine($"{player.Name} is dancing");
        player.MoveLeft(5);
        player.MoveRight(5);
    }
}
