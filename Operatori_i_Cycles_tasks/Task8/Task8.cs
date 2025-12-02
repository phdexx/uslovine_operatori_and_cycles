namespace Variables_tasks.Task8;

public class Task8Bootstrap
{
    public static void Run()
    {
        const string PASSWORD = "secret password";
        
        string guessedPassword;
        int guessesCount = 3;
        bool isPasswordCorrect = false;

        while (!isPasswordCorrect && guessesCount > 0)
        {
            Console.WriteLine($"Введите пароль, у вас {guessesCount} попытки");
            guessedPassword = Console.ReadLine();
            if (guessedPassword == PASSWORD)
            {
                isPasswordCorrect = true;
                Console.WriteLine("Пароль верный!");
            }
            else
            {
                guessesCount--;
            }
        }
        if (guessesCount == 0)
        {
            Console.WriteLine("Вы не угадали пароль, программа закрывается");
        }
    }
}