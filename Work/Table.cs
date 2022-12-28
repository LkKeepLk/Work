using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work;

public static class Table
{

    public static void Menu()
    {
        Console.WriteLine("На что ставите?");
        Console.WriteLine("1. На цвет (Коэффициент х2)");
        Console.WriteLine("2. На цифру (Коэффициент х36)");
        Console.WriteLine("3. На ряд (Коэффициент х3)");
        Console.WriteLine("4. На чётную - нечётную (Коэффициент х2)");
        Console.WriteLine("5. На первый второй или третий ряд (Коэффициент х3)");
        string EnterMenu = Console.ReadLine();
        bool ParseSelect = int.TryParse(EnterMenu, out int OutputSelect);
        if (ParseSelect)
        {
            Console.WriteLine("Сколько фишек");
            Console.WriteLine($"Доступное кол-во фишек - {Human.Chips}");
            string EnterSumm = Console.ReadLine();
            bool cool = int.TryParse(EnterSumm, out int Cool);
            if (cool)
            {
            int summ = int.Parse(EnterSumm);
                if (summ > Human.Chips)
                {
                    Console.WriteLine("Недостаточно фишек");
                    return;
                }
                Human.Chips = Human.Chips - summ;
                Console.WriteLine($"Кол-во фишек после ставки - {Human.Chips}");
                if (OutputSelect == 1)
                {
                    Console.WriteLine("Какой цвет?");
                    Console.WriteLine("1.Красный");
                    Console.WriteLine("2.Чёрный");
                    string EnterSelectColor = Console.ReadLine();
                    bool ParseSelectColor = int.TryParse(EnterSelectColor, out int OutputSelectColor);
                    if (ParseSelectColor)
                    {
                        Chips.ColorChips(OutputSelectColor, summ);

                    }
                    else
                    {

                        Console.WriteLine("введите корректное значение");
                        Human.Chips = Human.Chips + summ;
                        return;
                    }

                }
                else if (OutputSelect == 2)
                {
                    Console.WriteLine("Выберите число");
                    string EnterChips = Console.ReadLine();
                    bool ParseChips = int.TryParse(EnterChips, out int OutputChips);
                    if (ParseChips)
                    {
                        Chips.AllChips(OutputChips, summ);
                    }
                    else
                    {
                        Console.WriteLine("Для ввода используйте цифры");
                        Human.Chips = Human.Chips + summ;
                        return;
                    }

                }
                else if (OutputSelect == 3)
                {
                    Console.WriteLine("Выберите ряд");
                    string EnterChips = Console.ReadLine();
                    bool ParseChips = int.TryParse(EnterChips, out int OutputChips);
                    if (ParseChips)
                    {
                        Chips.SeriesOfNumbers(OutputChips, summ);
                    }
                    else
                    {
                        Console.WriteLine("Для ввода используйте цифры");
                        Human.Chips = Human.Chips + summ;
                        return;
                    }
                }
                else if (OutputSelect == 4)
                {
                    Console.WriteLine("Какое число?");
                    Console.WriteLine("1.Нечётное");
                    Console.WriteLine("2.Чётное");
                    string EnterSelectColor = Console.ReadLine();
                    bool ParseSelectColor = int.TryParse(EnterSelectColor, out int OutputSelectColor);
                    if (ParseSelectColor)
                    {
                        Chips.ParityChips(OutputSelectColor, summ);
                    }
                    else
                    {
                        Console.WriteLine("Для ввода используйте цифры");
                        Human.Chips = Human.Chips + summ;
                        return;
                    }

                }
                else if (OutputSelect == 5)
                {
                    Console.WriteLine("Выберите ряд");
                    string EnterChips = Console.ReadLine();
                    bool ParseChips = int.TryParse(EnterChips, out int OutputChips);
                    if (ParseChips)
                    {
                        Chips.SecondSeriesOfNembers(OutputChips, summ);
                    }
                    else
                    {
                        Console.WriteLine("Для ввода используйте цифры");
                        Human.Chips = Human.Chips + summ;
                        return;
                    }

                }
                else if (OutputSelect < 1 && OutputSelect > 5)
                {
                    Console.WriteLine("Введите цифру из списка");
                }
            }
            else
            {
                Console.WriteLine("Для ввода используйте цифры");
                return;
            }
        }
        else
        {
            Console.WriteLine("Для ввода используйте цифры");
        }
    }
}
