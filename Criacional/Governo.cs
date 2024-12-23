using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Criacional
{
    public class Governo : Impressor
    {
        public override IPrinter FactoryMethod()
        {
            return new ImpressoraDeDinheiro("Reais", 100000000);
        }
    }
}
