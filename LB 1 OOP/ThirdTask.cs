using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_OOP
{
    internal class ThirdTask
    {
        private int n;

        public ThirdTask(int n)
        {
            this.n = n;
        }

        public double calculateRow()
        {
            double sumRow = 0;

            for (double i = 0; i <= n; i++)
            {
                sumRow += (i / (i + 1));
            }
            return sumRow;
        }
    }
}
