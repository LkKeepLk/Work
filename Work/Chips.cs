using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

public static class Chips
{
    public static void AllChips(int number, int summ)
    {
        Random RandomChips = new Random();
        int AnyChips = RandomChips.Next(1, 36);
        Console.WriteLine($"Выпало число - {AnyChips}");
        Console.WriteLine($"Число которое ставили вы - {number}");
        if (AnyChips == number)
        {
            Console.WriteLine("Победа!");
            Console.WriteLine($"+ {summ * 36} ещё фишек");
            int win = summ * 2;
            Human.Chips = Human.Chips + win;
        }
        else
        {
            Console.WriteLine("Вы проиграли");
        }
    }
    public static void ColorChips(int number, int summ)
    {
        Random RandomChips = new Random();
        
        int AnyChips = RandomChips.Next(1, 36);

        if (AnyChips % 2 != 0)
        {
            Console.WriteLine($"Красная");
            if (number % 2 != 0)
            {
                Console.WriteLine($" + {summ * 2} фишек на счёт");
                int win = summ * 2;
                Human.Chips = Human.Chips + win;
                Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }

        }
        else if (AnyChips % 2 == 0)
        {
            Console.WriteLine($"Черная");
            if (number % 2 == 0)
            {
                Console.WriteLine($" + {summ * 2} фишек на счёт ");
                int win = summ * 2;
                Human.Chips = Human.Chips + win;
                Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }
        }

    }
    public static void CourseChipsChange()
    {
        Console.WriteLine($"Ваше количество средств - {Human.Money}");
        Random RandomCourse = new Random();
        int Course = RandomCourse.Next(4, 8);
        Console.WriteLine($"Курс перевода 1$ к {Course}");
        Console.WriteLine("Какую сумму хотите перевести?");
        string Enter = Console.ReadLine();
        bool Parse = int.TryParse(Enter, out int Exit);
        if (Exit > Human.Money)
        {
            Console.WriteLine("Недостаточно средств");
            return;
        }
        Human.Money = Human.Money - Exit;
        
        if (Parse)
        {
                int result = Exit * Course;
                Human.Chips = result;

        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
        
    }
    public static void CourseMoneyChange()
    {
        Console.WriteLine($"Ваше количество фишек - {Human.Chips}");
        Random RandomCourse = new Random();
        int Course = RandomCourse.Next(2, 6);
        Console.WriteLine($"Курс перевода {Course} к 1$");
        Console.WriteLine("Какую сумму хотите перевести?");
        string Enter = Console.ReadLine();
        bool Parse = int.TryParse(Enter, out int Exit);
        
        if (Parse)
        {
            if (Exit <= Human.Chips)
            {
                int result = Exit / Course;
                Human.Chips = Human.Chips - Exit;
                Human.Money = Human.Money + result;
            }
            else
            {
                Console.WriteLine("Недостаточно фишек");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
        
    }
    public static void ParityChips(int number, int summ)
    {
        Random RandomChips = new Random();
        int AnyChips = RandomChips.Next(1, 36);

        if (AnyChips % 2 != 0)
        {
            Console.WriteLine($"Нечётное");
            if (number % 2 != 0)
            {
                Console.WriteLine($" + {summ * 2} фишек на счёт");
                int win = summ * 2;
                Human.Chips = Human.Chips + win;
                Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }

        }
        else if (AnyChips % 2 == 0)
        {
            Console.WriteLine($"Чётное");
            if (number % 2 == 0)
            {
                Console.WriteLine($" + {summ * 2} фишек на счёт ");
                int win = summ * 2;
                Human.Chips = Human.Chips + win;
                Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
            }
            else
            {
                Console.WriteLine("Вы проиграли");
            }
        }

    }
    public static void SeriesOfNumbers(int number, int summ)
    {
        Random random = new Random();
        int[] SeriesOne = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        int[] SeriesTwo = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        int[] SeriesThree = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
        Console.WriteLine("Выберите ряд");
        int randomNumbers = random.Next(1, 36);
        if (number == 1)
        {
            foreach(int numbers in SeriesOne)
            {
                if(numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
        else if (number == 2)
        {
            foreach (int numbers in SeriesTwo)
            {
                if (numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
        else if (number == 3)
        {
            foreach (int numbers in SeriesThree)
            {
                if (numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
    }
    public static void SecondSeriesOfNembers(int number, int summ)
    {
        Random random = new Random();
        int[] SeriesOne = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] SeriesTwo = new int[12] { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };
        int[] SeriesThree = new int[12] { 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
        Console.WriteLine("Выберите серию чисел");
        int randomNumbers = random.Next(1, 36);
        if (number == 1)
        {
            foreach (int numbers in SeriesOne)
            {
                if (numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
        else if (number == 2)
        {
            foreach (int numbers in SeriesTwo)
            {
                if (numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
        else if (number == 3)
        {
            foreach (int numbers in SeriesThree)
            {
                if (numbers == randomNumbers)
                {
                    Console.WriteLine("Ставка сыграла");
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine($" + {summ * 3} фишек на счёт");
                    int win = summ * 2;
                    Human.Chips = Human.Chips + win;
                    Console.WriteLine($"Кол-во фишек на счету {Human.Chips}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Выпало число {randomNumbers}");
                    Console.WriteLine("Вы проиграли");
                    break;
                }
            }
        }
    }
}




