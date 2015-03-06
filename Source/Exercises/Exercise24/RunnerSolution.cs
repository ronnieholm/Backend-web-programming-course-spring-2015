using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24
{
    class RunnerSolution
    {
        public void Run()
        {
            NumberGenerator generator = new NumberGenerator();
            BattleLog log = new BattleLog();

            Hero hero = new Hero(generator, log);
            Beast beast = new Beast(generator, log);

            while (!hero.IsDead() && !beast.IsDead())
            {
                // let hero deal damage to beast
                beast.ReceiveDamage(hero.DealDamage());

                // let beast deal damage to hero if not dead
                if (!beast.IsDead())
                {
                    hero.ReceiveDamage(beast.DealDamage());
                }
            }

            log.PrintEntireBattleLog();
        }
    }
}
