using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Area
{
    public static class shape
    {
        

        public static double CalcAreaCircle(double radius)
        {
            return Math.PI * radius;
        }

        public static double CalcAreaTriangle(double A, double B, double C)
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt(P*(P-A)*(P-B)*(P-C));
        }

        public static bool CheckTriangleStraight (double A, double B, double C)
        {
            if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
            {
                return true;
            }
            else return false;
        }
    }
}
