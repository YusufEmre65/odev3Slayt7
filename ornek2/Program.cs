using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Deneme
    {
        public Deneme() {
            Console.WriteLine("Deneme 1");
        }
    }
}
namespace ornek21
{
    class Deneme
    {
        public Deneme()
        {
            Console.WriteLine("Deneme 2");
        }
    }
}
class Program
{
    static void Main()
    {
        ornek2.Deneme d1= new ornek2.Deneme();
        ornek21.Deneme d2= new ornek21.Deneme();
        Console.ReadLine();
    }
}
