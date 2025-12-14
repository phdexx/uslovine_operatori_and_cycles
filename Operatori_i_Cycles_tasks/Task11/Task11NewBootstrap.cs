using System;

namespace Variables_tasks.Task11
{
    public static class HeroActions
    {
        public const string ATTACK = "1";
        public const string MAGIC = "2";
    }

    public static class MagicActions
    {
        public const string HEAL = "1";
        public const string FIRE_BALL = "2";
        public const string EXPLOSION = "3";
    }

    public class Task11NewBootstrap
    {
        static private bool _isGameActive = true;

        static private int _heroMaxHealth = 200;
        static private int _heroCurrentHealth = _heroMaxHealth;
        static private int _heroMaxMana = 120;
        static private int _heroCurrentMana = _heroMaxMana;
        static private int _heroDamage = 15;

        static private int _heroHealPower = 40;
        static private int _heroHealUsability = 3;

        static private int _heroFireBallManaCost = 20;
        static private int _heroExplosionManaCost = 45;

        static private int _heroFireBallDamage = 25;
        static private int _heroExplosionDamage = 100;

        static private bool _isFireBallCastedLastTurn = false;

        static private int _bossMaxHealth = 500;
        static private int _bossCurrentHealth = _bossMaxHealth;
        static private int _bossDamage = 18;
        

        public static void Run()
        {

            
            while (_isGameActive)
            {
                PrintMenu();

                string _actionInput = Console.ReadLine();

                if (_actionInput == HeroActions.ATTACK)
                {
                    _bossCurrentHealth -= _heroDamage;
                    _isFireBallCastedLastTurn = false;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вы наносите урон боссу {_heroDamage}, здоровье босса {_bossCurrentHealth}");
                    Console.ResetColor();
                }
                else if (_actionInput == HeroActions.MAGIC)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Выберите заклинание");
                    Console.ResetColor();

                    if (_heroHealUsability > 0)
                    {
                        Console.WriteLine($"1 - Лечение (осталось {_heroHealUsability})");
                    }

                    Console.WriteLine("2 - Огненный шар");

                    if (_isFireBallCastedLastTurn)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("3 - ВЗРЫВ!!");
                        Console.ResetColor();
                    }

                    string _magicInput = Console.ReadLine();

                    if (_magicInput == MagicActions.HEAL && _heroHealUsability > 0)
                    {
                        _heroCurrentHealth += _heroHealPower;
                        _heroCurrentMana += _heroHealPower;

                        if (_heroCurrentHealth > _heroMaxHealth)
                        {
                            _heroCurrentHealth = _heroMaxHealth;
                        }

                        if (_heroCurrentMana > _heroMaxMana)
                        {
                            _heroCurrentMana = _heroMaxMana;
                        }

                        _heroHealUsability--;
                        _isFireBallCastedLastTurn = false;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Вы лечитесь на {_heroHealPower}, ваше здоровье {_heroCurrentHealth}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Вы восстановили {_heroHealPower} маны, ваша мана {_heroCurrentMana}");
                        Console.ResetColor();
                    }
                    else if (_magicInput == MagicActions.FIRE_BALL && _heroCurrentMana >= _heroFireBallManaCost)
                    {
                        _bossCurrentHealth -= _heroFireBallDamage;
                        _heroCurrentMana -= _heroFireBallManaCost;

                        _isFireBallCastedLastTurn = true;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Вы наносите урон огненным шаром {_heroFireBallDamage}, здоровье босса {_bossCurrentHealth}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"-{_heroFireBallManaCost} маны");
                        Console.ResetColor();
                    }
                    else if (_magicInput == MagicActions.EXPLOSION &&
                             _isFireBallCastedLastTurn &&
                             _heroCurrentMana >= _heroExplosionManaCost)
                    {
                        _bossCurrentHealth -= _heroExplosionDamage;
                        _heroCurrentMana -= _heroExplosionManaCost;

                        _isFireBallCastedLastTurn = false;

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"УРОН ВЗРЫВА БЫЛ {_heroExplosionDamage}, здоровье босса {_bossCurrentHealth}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"-{_heroExplosionManaCost} маны");
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
                Console.WriteLine("Нажмите любую клавишу чтобы продолжить...");
                Console.ResetColor();

                Console.ReadKey();
                Console.Clear();

                _heroCurrentHealth -= _bossDamage;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Босс наносит вам {_bossDamage} урона, ваше здоровье становится {_heroCurrentHealth}");
                Console.ResetColor();

                if (_heroCurrentHealth <= 0 && _bossCurrentHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("В попытке убить друг друга, вы не заметили как оба погибли... Ничья!");
                    Console.ResetColor();
                    _isGameActive = false;
                }
                else if (_bossCurrentHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы выиграли! Босс повержен");
                    Console.ResetColor();
                    _isGameActive = false;
                }
                else if (_heroCurrentHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы проиграли! Босс победил!");
                    Console.ResetColor();
                    _isGameActive = false;
                }
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine("Вы дерётесь с боссом!");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("        БОСС        ");
            Console.WriteLine($"Здоровье {_bossCurrentHealth} | Атака {_bossDamage}");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваши характеристики:");
            Console.WriteLine($"Здоровье |{_heroCurrentHealth}|");
            Console.WriteLine($"Мана |{_heroCurrentMana}|");
            Console.WriteLine($"Атака |{_heroDamage}|");
            Console.ResetColor();

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Атаковать");
            Console.WriteLine("2 - Магия");
        }
    }
}
