using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Diagnostics;
using System.IO;

namespace EtteTest
{
    class Functions
    {
        public void ReadSingleAttribute()
        {
            XElement xelement = XElement.Load("gentext.xml"); // XElement läser av XML fil

            var gentext = xelement.Descendants("trans-unit"); //Letar upp alla element i Gentext som heter <trans-unit>

            var data = from target in gentext //Går igenom alla element i gentext
                       where target != null &&       //Kollar så inte elementet är tomt
                               target.Element("target").Value.Contains("Filen")   //Kollar om target elementet innehåller "Filen"
                       select target;



            string docPath = @"C:\Users\oscar\Desktop\Jobb\EttEtest\EtteTest"; //Sökvägen till där textfilen ska sparas
            string filePath = Path.Combine(docPath, "Textfil.txt"); //Sökvägen och namnet på textfilen

            using (StreamWriter writetext = new StreamWriter(filePath)) //Skapar en textfil
            {
                foreach (var item in data) 
                {
                    string value = item.Value;

                    Console.WriteLine(item.Value); //Skriver ut värdet i konsolen

                    writetext.WriteLine(item.Value); //Skriver ut värdet i en textfil

                }
            }


        }
    }
}
