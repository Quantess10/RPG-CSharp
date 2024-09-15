using RPG;
    
class Program
{
    static void Main(string[] args)
    {
        Character player = new Character();
        player.Name = "Gracz";
        player.Health = 50;
        player.AttackPower = 25;
        player.Defense = 1;

        Character enemy = new Character();
        enemy.Name = "Goblin";
        enemy.Health = 50;
        enemy.AttackPower = 2;
        enemy.Defense = 1;

        Interface intefjes = new Interface();
        intefjes.StartMenu();

        while (player.Health > 0 && enemy.Health > 0)
        {
            Console.Clear();

            player.Attack(enemy);
            Thread.Sleep(2000);
            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{enemy.Name} ginie.");
                break;
            }

            enemy.Attack(player);
            Thread.Sleep(2000);
            if (player.Health <= 0)
            {
                Console.WriteLine($"{player.Name} ginie.");
                break;
            }
        }
    }
}
