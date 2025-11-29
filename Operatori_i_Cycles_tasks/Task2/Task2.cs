namespace Variables_tasks.Task2;

public class Task2Bootstrap
{
    public static void Run()
    {
        bool isCycleActive = true;
        
        while (isCycleActive)
        {
            Console.WriteLine("Цикл работает, введите exit чтоб выйти из него");
            
            if (Console.ReadLine() == "exit")
            {
                isCycleActive = false;
            }
        }
    }
}