using System;

class TimeConverter
{
    static void Main()
    {
        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Конвертировать из 12-часового формата в 24-часовой");
        Console.WriteLine("2. Конвертировать из 24-часового формата в 12-часовой");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Convert12To24();
                break;
            case 2:
                Convert24To12();
                break;
            default:
                Console.WriteLine("Некорректный выбор.");
                break;
        }
    }

    static void Convert12To24()
    {
        Console.Write("Введите время в формате ЧЧ:ММ:СС AM/PM: ");
        string time12 = Console.ReadLine();

        DateTime time = DateTime.ParseExact(time12, "h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
        string time24 = time.ToString("HH:mm:ss");

        Console.WriteLine("Время в 24-часовом формате: " + time24);
    }

    static void Convert24To12()
    {
        Console.Write("Введите время в формате ЧЧ:ММ:СС: ");
        string time24 = Console.ReadLine();

        DateTime time = DateTime.ParseExact(time24, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
        string time12 = time.ToString("h:mm:ss tt");

        Console.WriteLine("Время в 12-часовом формате: " + time12);
    }
}
