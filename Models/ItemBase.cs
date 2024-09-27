using W6_assignment_template.Interfaces;

namespace W6_assignment_template.Models
{
    public abstract class ItemBase : IItem
    {
        public string Name { get; set; }
        public int Value { get; set; }

        protected ItemBase(string name, int value)
        {
            Name = name;
            Value = value;
        }

    }


}
