using System;
using oopLab1;

class Application
{

    public static void Main(String[] args)
    {
        while (true)
        {
            menu();
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    consoleInputCalculationArea();
                    break;
                case 2:
                    consoleInputCalculationPerimeter();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Перевірте правильніть вашої цифри");
                    break;

            }
        }
    }

    public static void menu()
    {
        Console.WriteLine("Натисніть 1 - щоб порахувати площу ромба");
        Console.WriteLine("Натисніть 2 - щоб порахувати периметр ромба");
        Console.WriteLine("Натисніть 0 - щоб вийти з програми");

    }

    public static void consoleInputCalculationArea()
    {
        Console.WriteLine("Введіть x1");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y1");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x2");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y2");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x3");
        int x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y3");
        int y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x4");
        int x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y4");
        int y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses rhombuses = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine(rhombuses.squareRhombuses());
    }

    public static void consoleInputCalculationPerimeter()
    {
        Console.WriteLine("Введіть x1");
        int x1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y1");
        int y1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x2");
        int x2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y2");
        int y2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x3");
        int x3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y3");
        int y3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть x4");
        int x4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть y4");
        int y4 = Convert.ToInt32(Console.ReadLine());

        Rhombuses rhombuses2 = new Rhombuses(x1, y1, x2, y2, x3, y3, x4, y4);
        Console.WriteLine(rhombuses2.perimeterRhombuses());
    }

}
