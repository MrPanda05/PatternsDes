using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Estrutural
{
    public interface IPlatform
    {
        string Name { get; set; }
        string RunGame();
    }
}
