using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congtrunhanchia
{
    public class Math
    {
        public static  int cong(int a, int b)
        {
            return a + b;
        }
        public static int tru(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }
        }
        public static Double nhan(Double a, Double b)
        {
            return a * b;
        }
        public static Double chia(Double a, Double b)
        {

            return (a / b) * 1.0;
            
        }
    }
}
