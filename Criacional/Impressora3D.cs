using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Criacional
{
    public class Impressora3D : IPrinter
    {
        public string Name { get; set; }
        public int Quantity { get; set; }


        public Impressora3D(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public int Impressao()
        {
            return Quantity * 2;
        }
    }
}
