using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    internal class MeguminAdventures : Game
    {
        public MeguminAdventures(IPlatform platforma) : base(platforma)
        {
        }
        public override void Operation()
        {
            Console.WriteLine($"Megumin adventures {_platforma.RunGame()}");
        }
    }
}
