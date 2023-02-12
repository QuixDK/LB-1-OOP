using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_OOP
{
    internal class FirstTask
    {
        private int hours;
        private int minutes;
        private double angle;

        public FirstTask(int hours, int minutes)
        {
            if (hours > 0 & hours <= 12)
            {
                this.hours = hours;
            }
            else throw new Exception("Час должен быть в пределах от 1 и до 12");
            if (minutes >= 0 & minutes <= 60)
            {
                this.minutes = minutes;
            }
            else throw new Exception("Минуты должны быть в промежутке от 0 и до 60");

        }

        public double calculateAngle()
        {
            angle = 30 * hours + 0.5 * minutes - 6 * minutes;
            return angle;
        }

        public int getHours()
        {
            return this.hours;
        }
    }
}
