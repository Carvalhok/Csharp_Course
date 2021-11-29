using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class Superno
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }
        public double R4 { get; set; }
        public double K { get; set; }
        public double I { get; set; }
        public double Va { get; set; }

        public Superno()
        {
        }
        public Superno(double r1, double r2, double r3, double r4, double k, double i, double v)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            K = k;
            I = i;
            Va = v;
        }

        public double Ficurrent()
        {
            double I_fi = (((R3 * Va * (R4 + K) + R2 * R3 * R4 * I) / (R4 * (R3 + R2) + R3 * ( R2 + K))- Va) / R2);
            return I_fi;
        }
    }
}
