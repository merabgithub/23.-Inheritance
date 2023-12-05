using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // have a class be able inherit characyers of another
            //can have a superclass and other subclasses

            Chef chef = new Chef();//the chef object
            chef.MakeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MakeChicken(); // Italian chef using his inheritance! Chef is superclass, Italian Chef is subclass
            chef1.MakePasta(); // calling his own method,Chef cant call on make pasta
            chef1.MakeSpecialDish();

            //freeze console
            Console.ReadLine();
        }
    }
}
