namespace Variables_tasks.Task1;

public class Task1Bootstrap
{
    public static void Run()
    {
        Console.WriteLine("Введите сообщение");
        string message = Console.ReadLine();
        
        Console.WriteLine("Введите сколько раз нужно его повторить");
        int repeatTimes = int.Parse(Console.ReadLine());

        for (int i = 0; i < repeatTimes; i++)
        {
            Console.WriteLine(message);
        }
    }
}