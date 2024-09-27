using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_assignment_template.Models
{
    public class Treasure : ItemBase
    {
        public string Description { get; set; }
        public Treasure(string name, int value, string description) : base(name, value)
        {
            Description = description;
        }

    }
}
