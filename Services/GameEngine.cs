using W6_assignment_template.Data;
using W6_assignment_template.Models;

namespace W6_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IContext _context;
        private readonly Player _player;
        private readonly Goblin _goblin;
        private readonly Ghost _ghost;
        private readonly Rogue _rogue;
        private readonly Wizard _wizard;

        public GameEngine(IContext context)
        {
            _context = context;
            _player = context.Characters.OfType<Player>().FirstOrDefault();
            _goblin = _context.Characters.OfType<Goblin>().FirstOrDefault();
            _ghost = _context.Characters.OfType<Ghost>().FirstOrDefault();
            _rogue = _context.Characters.OfType<Rogue>().FirstOrDefault();
            _wizard = _context.Characters.OfType<Wizard>().FirstOrDefault();
        }

        public void Run()
        {
            if (_player == null || _goblin == null || _ghost == null || _rogue == null || _wizard == null)
            {
                Console.WriteLine("Failed to initialize game characters.");
                return;
            }

            Console.WriteLine($"Player Gold: {_player.Gold}");

            _goblin.Move();
            _goblin.Attack(_player);
            _player.UniqueBehavior();
            _player.UniqueBehavior();
            _player.UniqueBehavior();
            _rogue.UniqueBehavior();
            _rogue.Move();
            _rogue.Attack(_goblin);
            _goblin.UniqueBehavior();
            _player.Move();
            _player.Attack(_goblin);
            Console.WriteLine($"Player Gold: {_player.Gold}");

            _wizard.Move();
            _ghost.Fly();
            _wizard.UniqueBehavior();
            _wizard.CastSpell("materialize", _ghost, 15);
            _wizard.Attack(_ghost);
            _ghost.Move();
            _wizard.CastSpell("explode", _ghost, 20);
            _ghost.Attack(_wizard);
            _player.Attack(_ghost);
            Console.WriteLine($"Player Gold: {_player.Gold}");

        }
    }
}
