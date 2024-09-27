namespace W6_assignment_template.Models
{
    public class Player : CharacterBase
    {
        public int Gold { get; set; }
        public Consumable[] Equipment { get; set; }

        public Player(string name, string type, int level, int hp, int gold, Consumable[] equipment)
            : base(name, type, level, hp)
        {
            Gold = gold;
            Equipment = equipment;
        }

        public override void UniqueBehavior() //atempts to consume something from their equipment inventory
        { 
            if (Equipment.Length > 0) // check if they have anything in their equipment inventory
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{Name} consumes {Equipment[0].Name} and gains {Equipment[0].Health} health.");
                Console.ResetColor();
                HP += Equipment[0].Health;
                Equipment = Equipment.Skip(1).ToArray();
            }
            else
            {
                Console.WriteLine($"{Name} looks through their equipment only to find nothing to restore their health. ");
                
            }
        }
    }
}
