namespace Variables_tasks.Task3;

public class Task3Bootstrap
{
    public static void Run()
    {
        const int maxProgressionValue = 103;
        const int progressionStartValue = 5;
        const int progressionStep = 7;

        for (int i = progressionStartValue ; i <= maxProgressionValue; i += progressionStep)
        {
            Console.Write(i + " ");
        }
        
        //Выбрал цикл for, потому что у нас конкретно указан старт (5), указан конец (103, и указан конкретный шаг (+7)
        //в последовательности
        
    }
}