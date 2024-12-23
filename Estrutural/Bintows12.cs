using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    public class Bintows12 : IPlatform
    {
        public string Name { get; set; } = "Bintows12";

        public string RunGame()
        {
            return $"Runing on {Name}";
        }
    }
}
