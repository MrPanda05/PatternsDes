using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Comportamental
{
    public interface INotifier
    {
        /// <summary>
        /// Adciona observer
        /// </summary>
        /// <param name="observer"></param>
        void Subscribe(IObserver observer);
        /// <summary>
        /// Remove observers
        /// </summary>
        /// <param name="observer"></param>
        void UnSubscribe(IObserver observer);
        /// <summary>
        /// Notifica Observer que algo mudou
        /// </summary>
        void Notify();
    }
}
