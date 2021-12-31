using System;
using System.Collections.Generic;
using System.Text;

namespace DimondProblem
{
    abstract class Device
    {
        public string SerialNumber { get; set; }

       abstract public void ProcessDoc(string document);
    }
}
