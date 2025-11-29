namespace Variables_tasks.Task1;

public class Task1Bootstrap
{
    public static void Run()
    {
        string message;
        int repeatTimes;
        
        Console.WriteLine("Введите сообщение");
        message = Console.ReadLine();
        
        Console.WriteLine("Введите сколько раз нужно его повторить");
        repeatTimes = int.Parse(Console.ReadLine());

        for (int i = 0; i < repeatTimes; i++)
        {
            Console.WriteLine(message);
        }
    }
}