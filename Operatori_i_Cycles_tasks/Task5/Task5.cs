namespace Variables_tasks.Task5;

public static class UserCommandIds
{
    public const int Hello = 1;
    public const int HowAreYou = 2;
    public const int RollDice = 3;
    public const int ClearConsole = 4;
    public const int Exit = 5;
}
public class Task5Bootstrap
{
    static bool isProgramWorking = true; 
    
    public static void Run()
    {
        while (isProgramWorking)
        {
            PrintMenu();
            int userCommandId = Convert.ToInt32(Console.ReadLine());
            
            ExecuteCommand(userCommandId);
        }
    }
    
    private static void PrintMenu()
    {
        Console.WriteLine("1- Сказать 'привет!'");
        Console.WriteLine("2- Сказать 'как дела?'");
        Console.WriteLine("3- Бросить кубик");
        Console.WriteLine("4- Очистить консоль");
        Console.WriteLine("5- Выйти из консоли");
    }

    private static void ExecuteCommand(int commandId)
    {
        switch (commandId)
        {
            case UserCommandIds.Hello:
                PrintHello();
                break;

            case UserCommandIds.HowAreYou:
                PrintHowAreYou();
                break;

            case UserCommandIds.RollDice:
                RollDice();
                break;

            case UserCommandIds.ClearConsole:
                ClearConsole();
                break;

            case UserCommandIds.Exit:
                ExitProgram();
                break;

            default:
                PrintUnknownCommand();
                break;
        }
    }


    private static void PrintUnknownCommand()
    {
        Console.WriteLine("Неизвестная команда!");
    }

    private static void ExitProgram()
    {
        Console.Clear();
        isProgramWorking = false;
    }
    
    private static void ClearConsole()
    {
        Console.Clear();
    }
    
    private static void RollDice()
    {
        Random random = new Random();
        int randomDiceNumber = random.Next(1, 7);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Вам выпало {randomDiceNumber} на кубике!!!!");
        Console.ResetColor();
    }

    private static void PrintHowAreYou()
    {
        Console.WriteLine("У меня всё отлично!");
    }

    private static void PrintHello()
    {
        Console.WriteLine("И тебе привет!");
    }
}