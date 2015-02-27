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
    // 3. The character can receive damage causing the hit points to decrease
    class Beast
    {
        private int _currentHitPoints;
        private NumberGenerator _generator;
        private BattleLog _log;

        // creates Beast using references to random number generator and battle log
        public Beast(NumberGenerator generator, BattleLog log)
        {
            this._generator = generator;
            this._log = log;
            Reset();
        }

        // resets Beast state to original
        public void Reset()
        {
            _currentHitPoints = 90;
        }

        // returns amount of points a Beast deals in damage to
        // be received by another character.
        public int DealDamage()
        {
            int damage = _generator.GetRandomNumberInInterval(10, 25);
            string message = "Beast dealt " + damage + " damage!";
            _log.Save(message);
            return damage;
        }

        // Beast receives amount of damage specified in the parameter.
        // The number of hit points are decreased accordingly
        public void ReceiveDamage(int points)
        {
            _currentHitPoints = _currentHitPoints - points;
            string message = "Beast receives " + points + " damage, and is down to " + _currentHitPoints + " hit points";
            _log.Save(message);

            if (IsDead())
            {
                _log.Save("Beast died!");
            }
        }

        // checks if Beast is dead which is defined as having 0 or less hit points
        public bool IsDead()
        {
            return (_currentHitPoints <= 0);
        }
    }
}
