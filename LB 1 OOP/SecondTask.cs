using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_1_OOP
{
    internal class SecondTask
    {
        private int number;

        public SecondTask(int number)
        {
            if (number % 10000 > 999 & number % 10000 <= 9999)
            {
                this.number = number;
            }
            else throw new Exception("Введите 4-х значное число");
        }

        public bool isNumbersIncrease()
        {
            int fourthRank = this.number % 10000;
            int thirdRank = this.number % 1000;
            int secondRank = this.number % 100;
            int firstDigit = this.number % 10;

            int fourthDigit = (fourthRank - secondRank) / 1000;
            int thirdDigit = (thirdRank - secondRank) / 100;
            int secondDigit = (secondRank - firstDigit) / 10;

            Console.WriteLine(fourthDigit);
            Console.WriteLine(thirdDigit);
            Console.WriteLine(secondDigit);
            Console.WriteLine(firstDigit);

            if (fourthDigit < thirdDigit && thirdDigit < secondDigit && secondDigit < firstDigit)
            {
                return true;
            }
            else return false;
        }
    }
}
