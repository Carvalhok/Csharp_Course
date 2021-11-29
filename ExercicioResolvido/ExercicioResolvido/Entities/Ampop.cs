using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvido.Entities
{
    class Ampop
    {
        public double Rf { get; set; }
        public double R2 { get; set; }
        public double R { get; set; }
        public double R6 { get; set; }
        public double V1 { get; set; }
        public double V2 { get; set; }

        public Ampop(){
        }
        public Ampop(double rf, double r2, double r, double r6, double v1, double v2)
        {
            Rf = rf;
            R2 = r2;
            R = r;
            R6 = r6;
            V1 = v1;
            V2 = v2;
        }

        public double V0Calculate()
        {
            double V0 = (Rf/R*(1 + 2*R2/R6)*(V2-V1));
            return V0;
        }
    }
}
