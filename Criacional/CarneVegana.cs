using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Criacional
{
    public class CarneVegana : Impressor
    {
        public override IPrinter FactoryMethod()
        {
            return new Impressora3D("Carne falsa", 50);
        }
    }
}
