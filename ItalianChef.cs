using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef :Chef   //this makes Italian Chef inherit all there is in Chef, can now call methods in chef!

    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }
        public override void MakeSpecialDish() //use keyword override
        {
            Console.WriteLine("The Chef makes Italianspecials ");
        }
        //this class inherits from superclass, extends superclas by making new functions and also oveerride some superclass functions
    }
}
