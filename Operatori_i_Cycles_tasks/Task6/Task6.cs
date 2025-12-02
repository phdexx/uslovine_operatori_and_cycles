namespace Variables_tasks.Task6;

public class Task6Bootstrap
{
    public static void Run()
    {
        //курс валют для удобства
        // usd/rub = 78,23
        // eth/rub = 219 248
        // usd/eth = 0,000353
        // rub/usd = 0,012783
        // rub/eth = 0,000005
        // eth/usd = 2830,92

        const double RUB_TO_USD_CURRENCY = 0.012783;
        const double RUB_TO_ETH_CURRENCY = 0.000005;
        const double USD_TO_RUB_CURRENCY = 78.23;
        const double USD_TO_ETH_CURRENCY = 0.000353;
        const double ETH_TO_RUB_CURRENCY = 219248;
        const double ETH_TO_USD_CURRENCY = 2830.92;

        double rubBalance = 500;
        double usdBalance = 10;
        double ethBalance = 1.5323;

        bool isMarketActive = true;

        while (isMarketActive)
        {
            Console.WriteLine("Добро пожаловать на биржу");
            Console.WriteLine("Ваш баланс в валютах:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"RUB - {rubBalance}");
            Console.WriteLine($"USD - {usdBalance}");
            Console.WriteLine($"ETH - {ethBalance}");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Доступны операции:");
            Console.WriteLine("1 - Перевод RUB -> USD");
            Console.WriteLine("2 - Перевод RUB -> ETH");
            Console.WriteLine("3 - Перевод USD -> RUB");
            Console.WriteLine("4 - Перевод USD -> ETH");
            Console.WriteLine("5 - Перевод ETH -> RUB");
            Console.WriteLine("6 - Перевод ETH -> USD");
            Console.WriteLine("0 - Выйти из биржи");
            Console.ResetColor();
            
            string currencyChangeChoice = Console.ReadLine();
            if (currencyChangeChoice == "0")
            {
                isMarketActive = false;
                Console.Clear();
                Console.WriteLine("До свидания! Удачных торгов в будущем ;)");
                break;
            }
            
            Console.WriteLine("Сколько нужно перевести?");
            double valueToChange = Convert.ToDouble(Console.ReadLine());
            
            switch (currencyChangeChoice)
            { 
                //rub cases 1-2
                case "1":
                    if (valueToChange > rubBalance)
                    {
                        Console.WriteLine("Недостаточно RUB");
                    }
                    else
                    {
                        rubBalance -= valueToChange;
                        usdBalance += valueToChange * RUB_TO_USD_CURRENCY;
                    }
                    break;
                case "2":
                    if (valueToChange > rubBalance)
                    {
                        Console.WriteLine("Недостаточно RUB");
                    }
                    else
                    {
                        rubBalance -= valueToChange;
                        ethBalance += valueToChange * RUB_TO_ETH_CURRENCY;
                    }
                    break;
                //usd cases 3-4
                case "3":
                    if (valueToChange > usdBalance)
                    {
                        Console.WriteLine("Недостаточно USD");
                    }
                    else
                    {
                        usdBalance -= valueToChange;
                        rubBalance += valueToChange * USD_TO_RUB_CURRENCY;
                    }
                    break;
                case "4":
                    if (valueToChange > usdBalance)
                    {
                        Console.WriteLine("Недостаточно USD");
                    }
                    else
                    {
                        usdBalance -= valueToChange;
                        ethBalance += valueToChange * USD_TO_ETH_CURRENCY;
                    }
                    break;
                //eth cases 5-6
                case "5":
                    if (valueToChange > ethBalance)
                    {
                        Console.WriteLine("Недостаточно ETH");
                    }
                    else
                    {
                        ethBalance -= valueToChange;
                        rubBalance += valueToChange * ETH_TO_RUB_CURRENCY;
                    }
                    break;
                case "6":
                    if (valueToChange > ethBalance)
                    {
                        Console.WriteLine("Недостаточно ETH");
                    }
                    else
                    {
                        ethBalance -= valueToChange;
                        usdBalance += valueToChange * ETH_TO_USD_CURRENCY;
                    }
                    break;
                default:
                    Console.WriteLine("Нет такого варианта!");
                    break;
            }

        }
    }
}