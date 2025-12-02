using System;
namespace Variables_tasks.Task9;

public class Task9Bootstrap
{
    public static void Run()
    {
        // я очень жестко тупил над этой задачей в плане написания названий переменных
        Random rnd = new Random();
        
        int N = rnd.Next(10, 26);
        Console.WriteLine($"N которое мы получили: {N}");
        
        int count = 0;
        int firstNumber = N;
        
        while (firstNumber< 50)
        {
            firstNumber += N;
        }
        
        for (; firstNumber <= 150; firstNumber += N)
        {
            count++;
        }
        Console.WriteLine($"Чисел кратных {N} от 50 до 150: {count}");
        
        //сначала я написал вот такой цикл
        // for (int i = 50; i <= 150;  i+= N)
        // {
        //     count++;
        // }
        // но он был не правильный, потому что первая итерация (50) могла посчитаться как кратное, что неверно
        //я дописал цикл while который ищет первое кратное число сразу после 50, например 53, и уже от него идет отсчёт
    }
}