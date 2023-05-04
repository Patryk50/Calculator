namespace ConsoleCalculator;

internal class Interface
{
    internal static void Error(string information)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(information);
        Console.ResetColor();
    }

    internal static void Menu()
    {
        Console.WriteLine("MENU\n");

        Console.WriteLine("[1] Dodawanie (+)");
        Console.WriteLine("[2] Odejmowanie (-)");
        Console.WriteLine("[3] Mnożenie (x)");
        Console.WriteLine("[4] Dzielenie (:)");
        Console.WriteLine("[5] Modulo (?%)");
        Console.WriteLine("[6] Potęgowanie (^)");
        Console.WriteLine("[7] Pierwiastkowanie (v-)");
        Console.WriteLine("[8] Procenty (%)");
        Console.WriteLine("[9] Równanie kwadratowe (ax^2 + bx + c = 0)");
        Console.WriteLine("[0] Wartość bezwględna |x|");
        Console.WriteLine("[x] Zakończ");

        Console.Write("\nWybierz opcję: ");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1": Actions.Adding(); break;
            case "2": Actions.Substraction(); break;
            case "3": Actions.Multiplication(); break;
            case "4": Actions.Division(); break;
            case "5": Actions.Modulo(); break;
            case "6": Actions.Exponentiation(); break;
            case "7": Actions.Rooting(); break;
            case "8": Actions.Percentages(); break;
            case "9": Actions.QuadraticEquations(); break;
            case "0": Actions.TheAbsoluteValue(); break;
            case "x": Environment.Exit(0); break;
            default: Error("Wybrano błędny klawisz..."); Run(); return;
        }
    }

    internal static void Run()
    {
        Console.WriteLine("Wciśnij Enter aby przejść dalej...");
        ConsoleKeyInfo keyPressed = Console.ReadKey();
        do
        {
            Console.Clear();
            Menu();
        } while (keyPressed.Key != ConsoleKey.Enter);
    }
}
