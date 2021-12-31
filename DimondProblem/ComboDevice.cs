using System;

namespace DimondProblem
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public ComboDevice(string message) : base(message)
        {
            Message = message;
        }

        public override void ProcessDoc()
        {
            Console.WriteLine("PrcessDoc:  " + Message);
        }

        public void Scann()
        {
            Console.WriteLine("Scann: " + Message);
        }

        public void Print()
        {
            Console.WriteLine("Printer: " + Message);
        }
    }
}
