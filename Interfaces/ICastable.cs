using W6_assignment_template.Interfaces;

public interface ICastable
{
    int Mana { get; set; }
    void CastSpell(string spellname, ICharacter target, int manacost);
}