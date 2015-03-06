using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24
{
    // implements a simple game character
    // 1. The character has a certain number of hit points
    // 2. The character can deal damage
    // 3. The character can receive damage causing hit points to decrease
    class Hero
    {
        private int _currentHitPoints;
        private NumberGenerator _generator;
        private BattleLog _log;

        // create beast using references to random number generator and battle log
        public Hero(NumberGenerator generator, BattleLog log)
        {
            _generator = generator;
            _log = log;
            Reset();
        }

        // resets beasts state to original
        public void Reset()
        {
            _currentHitPoints = 90;
        }

        // returns amount of points a beast deals in damage.
        // Damage could be received by another character.
        public int DealDamage()
        {
            int damage = _generator.GetRandomNumberInInterval(10, 25);
            string message = "Beast dealt " + damage + " damage";
            _log.Save(message);
            return damage;
        }

        // beast receives amount of damage specified by parameter.
        // The number of hit points decrease accordingly
        public void ReceiveDamage(int points)
        {
            _currentHitPoints = _currentHitPoints - points;
            string message = "Hero receives " + points + " damage, and is down to " + _currentHitPoints + " hit points";
            _log.Save(message);

            if (IsDead())
            {
                _log.Save("Hero died");
            }
        }

        // checks if the beast is dead defined as it having <= 0 hit points
        public bool IsDead()
        {
            return (_currentHitPoints <= 0);
        }
    }
}
