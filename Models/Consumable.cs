using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_assignment_template.Models
{
    public class Consumable : ItemBase
    {
        public int Health {  get; set; }
        public Consumable(string name, int value, int health) : base(name, value)
        {
            Health = health;
        }
    }
}
