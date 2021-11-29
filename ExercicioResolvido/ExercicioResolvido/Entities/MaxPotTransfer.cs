using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class MaxPotTransfer
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }
        public double R4 { get; set; }
        public double Va { get; set; }
        public double Vb { get; set; }
        public double I { get; set; }

        public MaxPotTransfer()
        {

        }
        public MaxPotTransfer(double r1, double r2, double r3, double r4, double va, double vb, double i)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            Va = va;
            Vb = vb;
            I = i;
        }

        public double MaxPot()
        {
            double V1 = ((R4 * R1 * (I * R2 - Vb) + (R2 + R4) * (R1 * Vb - R2 * Va)) / (R4 * R1 - (R2 + R4) * (R1 + R2)));
            double V2 = ((R4 * (R1 + R2) * (Vb - I * R2) + R4 * (R2 * Va - R1 * Vb)) / ((R2 + R4) * (R1 + R2) - R4 * R1));
            double Vth = V1 - V2;
            double Rth = R2 * (R1 + R4) / (R1 + R2 + R4);
            //return V1;
            return Math.Pow((((R4 * R1 * (I * R2 - Vb) + (R2 + R4) * (R1 * Vb - R2 * Va)) / (R4 * R1 - (R2 + R4) * (R1 + R2)))- ((R4 * (R1 + R2) * (Vb - I * R2) + R4 * (R2 * Va - R1 * Vb)) / ((R2 + R4) * (R1 + R2) - R4 * R1))),2)/(4* R2 * (R1 + R4) / (R1 + R2 + R4));
        }
    }
}
