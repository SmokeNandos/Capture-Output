using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capture_Output
{
    class Program
    {
        static void Main(string[] args)
        {
            string designer = "Anders Hejlsberg";

            int indexOfSpace = designer.IndexOf(" ");
            string secondName = designer.Substring(indexOfSpace);

            Console.WriteLine(secondName);
            Console.ReadLine();
        }
    }
}
