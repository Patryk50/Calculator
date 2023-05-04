namespace ConsoleCalculator;

internal class Actions
{
    internal static void Adding()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Substraction()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Multiplication()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Division()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} : {secondNumber} = {firstNumber / secondNumber}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }
    internal static void Modulo()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszą liczbę: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugą liczbę: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Exponentiation()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj podstawę potęgi: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj wykładnik potęgi: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber}^{{{secondNumber}}} = {Math.Pow(firstNumber, secondNumber)}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Rooting()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj podstawę potęgi: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($" v-{firstNumber} = {Math.Sqrt(firstNumber)}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void Percentages()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Obliczanie danego procentu z liczby:");
            Console.Write("Podaj procent: ");
            double firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Podaj liczbę: ");
            double secondNumber = int.Parse(Console.ReadLine());

            double result = (firstNumber / 100) * secondNumber;

            Console.WriteLine($"{firstNumber}% z liczby {secondNumber} = {result}");
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void QuadraticEquations()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj pierwszy współczynnik liczbowy: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Podaj drugi współczynnik: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Podaj trzeci współczynnik: ");
            int c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                Interface.Error(" \"a\" musi być większe od zera -> a =/= 0");
            }
            else
            {
                double delta = Math.Pow(b, 2) - (4 * a * c);
                if (delta < 0)
                {
                    Console.WriteLine("Równanie kwadratowe nie ma rozwiązań");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Równanie kwadratowe ma jedno rozwiązanie: x = {x}");
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Równanie kwadratowe ma dwa rozwiązania: ");
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
            }
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }

    internal static void TheAbsoluteValue()
    {
        Console.Clear();
        try
        {
            Console.Write("Podaj liczbę: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine($"x: {Math.Abs(x)}");
            }
            else
            {
                Console.WriteLine($"x: {Math.Abs(x)}");
            }
        }
        catch (System.FormatException)
        {
            Interface.Error("Podano nieprawidłowy format");
        }
        Interface.Run();
    }
}
