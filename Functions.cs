using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;

namespace EtteTest
{
    class Functions
    {
         public void ReadSingleAttribute()
         {
            XElement xelement = XElement.Load("gentext.xml");

            var gentext = xelement.Descendants("trans-unit");

            var data = from target in gentext
                         where target != null &&
                               target.Element("target").Value.Contains("Filen")
                       select target;

            foreach(var item in data)
            {
                Console.WriteLine(item.Value);
            }



        }
    }
}
