namespace Variables_tasks.Task3;

public class Task3Bootstrap
{
    public static void Run()
    {
        int maxProgressionValue = 103;

        for (int progressionValue = 5; progressionValue <= maxProgressionValue; progressionValue += 7)
        {
            Console.Write(progressionValue + " ");
        }
        
        //Выбрал цикл for, потому что у нас конкретно указан старт (5), указан конец (103, и указан конкретный шаг (+7)
        //в последовательности
        
    }
}