using LB_1_OOP;
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main()
    {
        //initFirstTask();
        //initSecondTask();
        //initThirdTask();
        initFourthTask();
    }

    private static void initFirstTask()
    {
        try
        {
            Console.WriteLine("Введите количество часов");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n" + "Введите количество минут");
            int minutes = Convert.ToInt32(Console.ReadLine());
            FirstTask firstTask = new FirstTask(hours, minutes);
            Console.WriteLine("\n" + "Угол равен");
            Console.WriteLine(firstTask.calculateAngle() + "°");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void initSecondTask()
    {
        try
        {
            Console.WriteLine("Введите 4-х значное число");
            int number = Convert.ToInt32(Console.ReadLine());
            SecondTask secondTask = new SecondTask(number);
            bool isTrue = secondTask.isNumbersIncrease();
            if (isTrue)
            {
                Console.WriteLine("Все числа в числе возрастают слева на право");
            }
            else Console.WriteLine("Не все числа возрастают слева на право");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void initThirdTask()
    {
        try
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());
            ThirdTask thirdTask = new ThirdTask(n);
            Console.WriteLine(thirdTask.calculateRow());
            
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    private static void initFourthTask()
    {
        try
        {
            Console.WriteLine("Введите число n");
            double n = Convert.ToInt32(Console.ReadLine());
            FourthTask fourthTask = new FourthTask(n);
            Console.WriteLine("\n" + "Количество делителей числа равно");
            Console.WriteLine(fourthTask.getDelimetersCount());

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}