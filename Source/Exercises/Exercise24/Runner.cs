using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24
{
    class Runner
    {
        public void Run()
        {
            NumberGenerator generator = new NumberGenerator();
            BattleLog log = new BattleLog();

            Hero hero = new Hero(generator, log);
            Beast beast = new Beast(generator, log);

            // now battle
            // How do we do that. Hint: You need a loop.
            // Insert code here to make Hero and Beast battle

            log.PrintEntireBattleLog();
        }
    }
}
