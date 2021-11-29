using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class QuestãoThvennin
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }
        public double R4 { get; set; }
        public double K { get; set; }
        public double I { get; set; }
        public double V { get; set; }

        public QuestãoThvennin()
        {

        }

        public QuestãoThvennin(double r1, double r2, double r3, double r4, double k, double i, double v)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            K = k;
            I = i;
            V = v;
        }

        public double Voltage()
        {
            double Vth = (((1 + K) * V / R1 - (R4 * I) / (R3 + R4)) / ((1 + K) / R1 + (R2 + R3 + R4) / (R2 * (R3 + R4))));
            return Vth;
        }

        public double Resistence()
        {
            double Rth = 1 / ((R3 + R4 + R2) / ((R3 + R4) * R2) + (1 + K) / R1);
            return Rth;
        }
    }
}
