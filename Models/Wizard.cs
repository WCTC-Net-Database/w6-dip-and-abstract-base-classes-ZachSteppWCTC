using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public class Wizard : CharacterBase, IFlyable, ICastable
    {
        public int Mana { get; set; }
        public Wizard(string name, string type, int level, int hp, int mana)
            : base(name, type, level, hp)
        {
            Mana = mana;
        }
        public void CastSpell(string spellname, ICharacter target, int manacost)
        {
            if (Mana >= manacost)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{Name} casts {spellname} on {target.Name}.");
                Console.ResetColor();
                Mana -= manacost;
            }
            else
            {
                Console.WriteLine($"{Name} tries to cast {spellname}, but doesn't have enough mana.");
            }
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} flies around on their broomstick.");
        }

        public override void UniqueBehavior()
        {
            Console.WriteLine($"{Name} reads from their spellbook, in preperation for their next attack.");
        }
    }
}
