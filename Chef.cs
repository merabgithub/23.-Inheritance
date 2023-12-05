using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken ");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish() //virtual allows subclasses to override
        {
            Console.WriteLine("The Chef makes dish ");
        }
    }
}
