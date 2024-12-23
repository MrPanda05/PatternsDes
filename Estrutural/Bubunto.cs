using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    public class Bubunto : IPlatform
    {
        public string Name { get; set; } = "Bubunto";

        public string RunGame()
        {
            return $"Runing on {Name}, please install all other 200000 dependecies to make this game work";
        }

    }
}
