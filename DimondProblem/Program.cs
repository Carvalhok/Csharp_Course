using System;

namespace DimondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboDevice comboDevice = new ComboDevice("Happy New Year");
            comboDevice.ProcessDoc();
            comboDevice.Print();
            comboDevice.Scann();
        }
    }
}
