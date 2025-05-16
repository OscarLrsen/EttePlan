using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace EtteTest
{

    class Program
    {
        static void Main(string[] args)
        {
            Functions fn = new Functions();

            fn.ReadSingleAttribute();

            Console.ReadLine();
        }
    }
}
