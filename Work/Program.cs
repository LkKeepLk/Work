using Work;

void Menu()
{
    Console.WriteLine($"Денег у вас {Human.Money}$");
    Console.WriteLine($"Фишек у вас {Human.Chips}");
    Console.WriteLine("1. Купить фишки");
    Console.WriteLine("2. Сделать ставку");
    Console.WriteLine("3. Узнать кол-во фишек");
    Console.WriteLine("4. Вывод фишек по курсу");
    Console.WriteLine("5. Выход из игры");
}
void FuncMenu()
{

    string Enter = Console.ReadLine();
    bool Parse = int.TryParse(Enter, out int Exit);
    if (Parse)
    {
        switch (Exit)
        {
            case 1:
                Chips.CourseChipsChange();
                break;
            case 2:
                if(Human.Chips == null || Human.Chips == 0 || Human.Chips == ' ')
                {
                    Console.WriteLine("Сначала купите фишки");
                }
                else
                {
                    Table.Menu();
                }
                break;
            case 3:
                Console.WriteLine($"{Human.Chips} - фишек");
                break;
            case 4:
                Chips.CourseMoneyChange();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Выберите пункт из меню");
                break;

        }
    }
    else
    {
        Console.WriteLine("Выберите пункт из меню");
        
    }
}
while (true)
{
    Menu();
    FuncMenu();
}