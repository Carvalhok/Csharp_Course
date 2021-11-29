using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double additionalCharge)
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1*AdditionalCharge;
        }


    }
}
