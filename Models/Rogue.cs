using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Rogue : CharacterBase, IThievish
    {
        public Rogue(string name, string type, int level, int hp)
    : base(name, type, level, hp)
        { }

        public override void Move()
        {
            Console.WriteLine($"{Name} moves through the shadows undetected.");
        }
        public void StealFrom(ICharacter target)
        {
            Console.WriteLine($"{Name} steals something from {target.Name} without them noticing.");
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} disguises themself to evade enemy detection."); ;
        }
    }
}
