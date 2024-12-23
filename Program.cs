using PatternsDes.Comportamental;
using PatternsDes.Criacional;
using PatternsDes.Estrutural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementação observer pattern
            Console.WriteLine("Coportamental Pattern | Observer pattern");
            var Enaldinho = new Youtuber();
            var Inscrito1 = new Inscrito();
            var Inscrito2 = new Inscrito();
            var Inscrito3 = new Inscrito();
            Enaldinho.Subscribe(Inscrito1);
            Enaldinho.Subscribe(Inscrito2);
            Enaldinho.Subscribe(Inscrito3);
            Enaldinho.UnSubscribe(Inscrito2);
            Enaldinho.Notify();

            //Implementação Factory pattern
            Console.WriteLine("Criational Pattern | Factory method pattern");
            var veganMeat = new CarneVegana();
            var brazil = new Governo();
            veganMeat.ResultadoImpressao();
            brazil.ResultadoImpressao();

            //Implementação Bridge pattern
            Console.WriteLine("Estructural Pattern | Bridge pattern");
            var bubunto = new Bubunto();
            var bintows12 = new Bintows12();
            var meguminBubunto = new MeguminAdventures(bubunto);
            var meguminBintows12 = new MeguminAdventures(bintows12);
            var chess2Bubunto = new Chess2(bubunto);
            var chess2Bintows12 = new Chess2(bintows12);
            meguminBubunto.Operation();
            chess2Bubunto.Operation();
            meguminBintows12.Operation();
            chess2Bintows12.Operation();
        }
    }
}
