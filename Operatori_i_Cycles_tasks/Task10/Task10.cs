namespace Variables_tasks.Task10;

public class Task10Bootstrap
{
    public static void Run()
    {
        const int POWER_BASE = 2;
        
        Random rand = new Random();

        int targetValue = rand.Next(1, 100);

        int currentPower = 0;
        int currentPowerValue = 1; 

        while (currentPowerValue <= targetValue)
        {
            currentPowerValue *= POWER_BASE;  
            currentPower++;          
        }

        Console.WriteLine($"Число: {targetValue}");
        Console.WriteLine($"Минимальная степень двойки: {currentPower}");
        Console.WriteLine($"2^{currentPower} = {currentPowerValue}");
    }
}