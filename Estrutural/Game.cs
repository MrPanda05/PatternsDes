using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    public class Game
    {
        protected IPlatform _platforma;

        public Game(IPlatform platforma)
        {
            _platforma = platforma;
        }

        public virtual void Operation()
        {
            Console.WriteLine($"Game {_platforma.RunGame()}");
        }
    }
}
