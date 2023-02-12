using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_OOP
{
    internal class FourthTask
    {
        private double n;

        public FourthTask(double n)
        {
            this.n = n;
        }


        public int getDelimetersCount()
        {
            int delimeter = 0;

            for (double i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    delimeter++;
                }
            }
            return delimeter;
        }
    }

}
