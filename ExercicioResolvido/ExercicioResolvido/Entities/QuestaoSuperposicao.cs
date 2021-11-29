using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class QuestaoSuperposicao
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }
        public double R4 { get; set; }
        public double Va { get; set; }
        public double Vb { get; set; }
        public double I { get; set; }

        public QuestaoSuperposicao()
        {

        }
        public QuestaoSuperposicao(double r1, double r2, double r3, double r4, double va, double vb, double i)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
            R4 = r4;
            Va = va;
            Vb = vb;
            I = i;
        }

        public double CurrentCalculation1()
        {
            double I1 = 1000 *((Va - (R2 * Va - R1 * Vb + R2 * R1 * I) / (R1 + R2)) / R1);
            return I1;
        }
        public double CurrentCalculation2()
        {
            double I2 = -1000*((R2 * Va - R1 * Vb + R2 * R1 * I) / (R1 + R2) + Vb) / R2;
            return I2;
        }
        
    }
}
