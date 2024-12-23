using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    public class Chess2 : Game
    {
        public Chess2(IPlatform platforma) : base(platforma)
        {
        }

        public override void Operation()
        {
            Console.WriteLine($"Chess 2 {_platforma.RunGame()}");
        }
    }
}
