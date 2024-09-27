using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Goblin : CharacterBase, ILootable, IThievish
    {
        public Treasure Treasure { get; set; }

        public Goblin(string name, string type, int level, int hp, Treasure treasure)
            : base(name, type, level, hp)
        {
            Treasure = treasure;
        }

        public void StealFrom(ICharacter target)
        {
            Console.WriteLine($"{Name} ransacks {target.Name}'s pockets.");
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} screeches, strinking fear into their enemies.");
        }
    }
}
