using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Ghost : CharacterBase, IFlyable, ILootable
    {
        public Treasure Treasure { get; set; }

        public Ghost(string name, string type, int level, int hp, Treasure treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies rapidly through the air.");
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name}'s presence chills the battlefield, stiffening everyone's movements.");
        }
    }
}
