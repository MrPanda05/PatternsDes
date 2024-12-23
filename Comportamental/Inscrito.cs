using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Comportamental
{
    public class Inscrito : IObserver
    {
        //Quando receber notificação
        public void Update()
        {
            Console.WriteLine("Video novo!");
        }
    }
}
