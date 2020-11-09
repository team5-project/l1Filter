using System;
using System.Collections.Generic;
using System.Text;

namespace l1Filter
{
    class l1Filter
    {
        public static double Alpha = 0.01;
        public static double Beta = 0.5;
        public static int Mu = 2;
        public static int Maxiter = 40;
        public static int Maxlister = 20;
        public static double Tol = 1e-4;

        public static List<string> y = new List<string>();
        public static int n = y.Count;
        public static int m = n - 2;

        public static Matrix I2 = Matrix.Speye(n - 2, n - 2);
        public static Matrix O2 = Matrix.Zeros(n - 2, 1);
    }
}
