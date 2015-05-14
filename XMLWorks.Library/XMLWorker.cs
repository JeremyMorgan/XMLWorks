using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLWorks.Library
{
    public class XMLWorker
    {
        public string XMLFileName { get; set; }

        public void ReadXMLFile()
        {
            try
            {
                XElement xelement = XElement.Load(XMLFileName);
                IEnumerable<XElement> employees = xelement.Elements();

                // Read the entire XML
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }

            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

    }
}
