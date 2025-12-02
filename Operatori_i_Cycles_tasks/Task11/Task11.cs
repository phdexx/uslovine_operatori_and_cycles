namespace Variables_tasks.Task11;

public class Task11Bootstrap
{
    public static void Run()
    {
        //easy победа команды: 2 2 2 3 2 1 2 2 2 3 2 1 2 1 2 2 2 2 1 1 1 1 1
        //очень жду любой критики, парился с кодом очень долго, хотелось бы чтоб "засрали" по полной
        
        bool isGameActive = true;

        int heroMaxHealth = 200;
        int heroCurrentHealth = heroMaxHealth;
        int heroMaxMana = 120;
        int heroCurrentMana = heroMaxMana;
        int heroDamage = 15;

        int heroHealPower = 40;
        int heroHealUsability = 3;
        
        int heroFireBallManaCost = 20;
        int heroExplosionManaCost = 45;
        
        int heroFireBallDamage = 25;
        int heroExplosionDamage = 100;

        bool isFireBallCastedLastTurn = false;

        int bossMaxHealth = 500;
        int bossCurrentHealth = bossMaxHealth;
        int bossDamage = 18;

        string actionOption;
        string magicOption;
        
        
        while (isGameActive)
        {
            
            Console.WriteLine("Вы дерётесь с боссом!");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        БОСС        ");
            Console.WriteLine($"Здоровье {bossCurrentHealth} | Атака {bossDamage}");
            Console.ResetColor();
            
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваши характеристики:");
            Console.WriteLine($"Здоровье |{heroCurrentHealth}|");
            Console.WriteLine($"Мана |{heroCurrentMana}|");
            Console.WriteLine($"Атака |{heroDamage}|");
            Console.ResetColor();

            Console.WriteLine("Выберите действие для атаки!");
            Console.WriteLine("1 - Атаковать");
            Console.WriteLine("2 - Магия");
            
            actionOption = Console.ReadLine();
            //не стал делать через switch потому что показалось что не так много условий для проверки
            if (actionOption == "1")
            {
                bossCurrentHealth -= heroDamage;
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы наносите урон боссу {heroDamage}, здоровье босса {bossCurrentHealth}");
                Console.ResetColor();
            }
            else if (actionOption == "2")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Выберите заклинание");

                if (heroHealUsability > 0)
                {
                    Console.WriteLine($"1 - Лечение (осталось {heroHealUsability})");
                }
                
                Console.WriteLine("2 - Огненный шар");
                Console.ResetColor();
                
                if (isFireBallCastedLastTurn)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("3 - ВЗРЫВ!!");
                    Console.ResetColor();
                }
                
                magicOption = Console.ReadLine();

                if (magicOption == "1" && heroHealUsability > 0)
                {
                    heroCurrentHealth += heroHealPower;
                    heroCurrentMana += heroHealPower;

                    if (heroCurrentHealth > heroMaxHealth)
                    {
                        heroCurrentHealth = heroMaxHealth;
                    }
                    
                    heroHealUsability--;
                    
                    isFireBallCastedLastTurn = false;
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Вы лечитесь на {heroHealPower}, ваше здоровье {heroCurrentHealth}");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Вы восстановили {heroHealPower} маны, ваша мана {heroCurrentMana}");
                    Console.ResetColor();
                    
                }
                else if (magicOption == "2" && heroFireBallManaCost <= heroCurrentMana)
                {
                    bossCurrentHealth -= heroFireBallDamage;
                    heroCurrentMana -= heroFireBallManaCost;
                    
                    isFireBallCastedLastTurn = true;
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы наносите урон огненым шаром {heroFireBallDamage}, здоровье босса {bossCurrentHealth}");
                    Console.ResetColor();
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"-{heroFireBallManaCost} маны");
                    Console.ResetColor();
                }
                else if (magicOption == "3" && heroExplosionManaCost <= heroCurrentMana)
                {
                    bossCurrentHealth -= heroExplosionDamage;
                    heroCurrentMana -= heroExplosionManaCost;
                    
                    isFireBallCastedLastTurn = false;
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"УРОН ВЗРЫВА БЫЛ {heroExplosionDamage}, здоровье босса {bossCurrentHealth}");
                    Console.ResetColor();
                    
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"-{heroExplosionManaCost} маны");
                    Console.ResetColor();
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("НЕДОСТАТОЧНО МАНЫ ИЛИ НЕВЕРНЫЙ ВВОД!");
                    Console.ResetColor();
                }
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("НЕВЕРНЫЙ ВВОД!");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Нажмите любую клавишу что-бы продолжить...");
            
            Console.ReadKey();
            Console.Clear();
            
            heroCurrentHealth -= bossDamage;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Босс наносит вам {bossDamage} урона, ваше здоровье становится {heroCurrentHealth}");
            Console.ResetColor();

            if (bossCurrentHealth <= 0 && heroCurrentHealth <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("В попытке убить друг друга, вы не заметили как оба погибли... Ничья!");
                Console.ResetColor();
                
                isGameActive = false;
            }
            else if (bossCurrentHealth <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вы выиграли! Босс повержен");
                Console.ResetColor();

                isGameActive = false;
            }
            else if (heroCurrentHealth <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы програли! Босс победил!");
                Console.ResetColor();
                
                isGameActive = false;
            }
        }
    }
}