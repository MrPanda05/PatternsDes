using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Criacional
{
    public abstract class Impressor
    {
        public abstract IPrinter FactoryMethod();

        public void ResultadoImpressao()
        {
            var product = FactoryMethod();
            var result = $"Acabei de imprimir {product.Impressao()} {product.Name}";

            Console.WriteLine(result);
        }
    }
}
