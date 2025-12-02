namespace Variables_tasks.Task2;

public class Task2Bootstrap
{
    public static void Run()
    {
        do
        {
            Console.WriteLine("Цикл работает, введите exit чтоб выйти из него");
        } 
        while (Console.ReadLine() != "exit");
    }
}