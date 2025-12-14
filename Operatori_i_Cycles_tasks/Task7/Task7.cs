namespace Variables_tasks.Task7;

public class Task7Bootstrap
{
    public static void Run()
    {
        const int FRAME_EXTRA_SYMBOLS = 2;
        
        Console.WriteLine("Введите имя");
        string name = Console.ReadLine();

        Console.WriteLine("Введите символ для заполнения");
        char symbolForSquare = Console.ReadLine()[0];
        
        string squareFrame = new string(symbolForSquare, name.Length + FRAME_EXTRA_SYMBOLS);
        
        Console.WriteLine(squareFrame);
        Console.WriteLine(symbolForSquare + name + symbolForSquare);
        Console.WriteLine(squareFrame);
    }
}