using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes.Comportamental
{
    public interface IObserver
    {
        /// <summary>
        /// Faz alguma coisa quando é notificado
        /// </summary>
        void Update();
    }
}
