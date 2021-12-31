using System;
using System.Collections.Generic;
using System.Text;

namespace DimondProblem
{
    class Printer : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ProcessDocument: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer: ");
        }
    }
}
