namespace Variables_tasks.Task5;

public class Task5Bootstrap
{
    public static void Run()
    {
        int userCommand;
        bool isProgramWorking = true;
        
        Random random = new Random();

        while (isProgramWorking)
        {
            Console.WriteLine("1- Сказать 'привет!'");
            Console.WriteLine("2- Сказать 'как дела?'");
            Console.WriteLine("3- Бросить кубик");
            Console.WriteLine("4- Очистить консоль");
            Console.WriteLine("5- Выйти из консоли");
            
            userCommand = Convert.ToInt32(Console.ReadLine());

            switch (userCommand)
            {
                case 1:
                    Console.WriteLine("И тебе привет!");
                    break;
                case 2:
                    Console.WriteLine("У меня всё отлично!");
                    break;
                case 3:
                    int randomDiceNumber = random.Next(1, 7);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Вам выпало {randomDiceNumber} на кубике!!!!");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Жаль расставаться, пока!");
                    isProgramWorking = false;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Я не знаю такой команды =(");
                    Console.ResetColor();
                    break;
            }
            
            

        }
        
        
    }
}