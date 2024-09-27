using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public abstract class CharacterBase : ICharacter
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }

        protected CharacterBase(string name, string type, int level, int hp)
        {
            Name = name;
            Type = type;
            Level = level;
            HP = hp;
        }

        protected CharacterBase() { }

        public void Attack(ICharacter target)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} attacks {target.Name}");
            Console.ResetColor();

            if (this is Player player && target is ILootable targetWithTreasure && !string.IsNullOrEmpty(targetWithTreasure.Treasure.Name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{Name} takes {targetWithTreasure.Treasure.Name} from {target.Name}");
                player.Gold += targetWithTreasure.Treasure.Value; // Gold is based on item's value
                Console.WriteLine(targetWithTreasure.Treasure.Description);
                targetWithTreasure.Treasure = null; // Treasure is taken
                Console.ResetColor();
            }
            else if (this is Player playerWithGold && target is Player targetWithGold && targetWithGold.Gold > 0)
            {
                Console.WriteLine($"{Name} takes gold from {target.Name}");
                playerWithGold.Gold += targetWithGold.Gold;
                targetWithGold.Gold = 0; // Gold is taken
            }
        }


        public virtual void Move()
        {
            Console.WriteLine($"{Name} moves.");
        }

        // Abstract method for unique behavior to be implemented by derived classes
        public abstract void UniqueBehavior();
    }
}
