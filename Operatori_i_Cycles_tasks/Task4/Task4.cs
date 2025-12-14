using System;
using System.Runtime.InteropServices;

namespace Variables_tasks.Task4;

public class Task4Bootstrap
{
    public static void Run()
    { 
        const int MIN_RANGE = 0; 
        const int MAX_RANGE = 101;
        const int FIRST_DIVISOR = 3;
        const int SECOND_DIVISOR = 5;
        
        Random random = new Random();
        int number = random.Next(MIN_RANGE,MAX_RANGE);
        
        int finalSum = 0;

        for (int i = 0; i <= number; i++)
        {
            if (i % FIRST_DIVISOR == 0 || i % SECOND_DIVISOR == 0)
            {
                finalSum += i;
            }
        }
        
        Console.WriteLine($"Сумма всех чисел кратных {FIRST_DIVISOR} или {SECOND_DIVISOR}, от {MIN_RANGE} до {number}, равна: {finalSum}");
    }
}