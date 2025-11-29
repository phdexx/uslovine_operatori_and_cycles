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
    }
}