using System;
using System.Collections.Generic;
using System.Text;

namespace DimondProblem
{
    class Scanner : Device
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("PrcessDoc:  " + document);
        }

        public void Scann(string document)
        {
            Console.WriteLine("Scann: " + document);
        }
    }
}
