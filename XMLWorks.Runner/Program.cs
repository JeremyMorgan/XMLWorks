using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLWorks.Library;

namespace XMLWorks.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLWorker ourXMLWorker = new XMLWorker();

            ourXMLWorker.XMLFileName = "Employees.xml";
            ourXMLWorker.ReadXMLFile();

            Console.ReadLine();

        }
    }
}
