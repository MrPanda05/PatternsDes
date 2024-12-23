using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Criacional
{
    public interface IPrinter
    {
        string Name { get; set; }
        int Quantity {  get; set; }
        int Impressao();
    }
}
