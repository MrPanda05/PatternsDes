using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Comportamental
{
    public class Youtuber : INotifier
    {

        private List<IObserver> _incritosDoCanal = new List<IObserver>();
        //Adciona um inscrito
        public void Subscribe(IObserver observer)
        {
            _incritosDoCanal.Add(observer);
            Console.WriteLine("Adcionando inscrito");
        }
        //Remove um inscrito
        public void UnSubscribe(IObserver observer)
        {
            _incritosDoCanal.Remove(observer);
            Console.WriteLine("Removendo inscrito");

        }
        //Notifica os inscritos
        public void Notify()
        {
            foreach (var inscrito in _incritosDoCanal)
            {
                inscrito.Update();
                Console.WriteLine("Notificando video novo");

            }
        }
    }
}
