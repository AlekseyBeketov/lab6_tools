using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Доступные операции:");
        Console.WriteLine("1. Сложение (+)");
        Console.WriteLine("2. Вычитание (-)");
        Console.WriteLine("3. Умножение (*)");
        Console.WriteLine("4. Деление (/)");

        Console.Write("Выберите операцию (введите соответствующий номер): ");
        char choice = Console.ReadLine()[0];

        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case '1':
                Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
                break;
            case '2':
                Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
                break;
            case '3':
                Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
                break;
            case '4':
                if (num2 != 0)
                {
                    Console.WriteLine($"Результат: {num1} / {num2} = {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Деление на ноль!");
                }
                break;
            default:
                Console.WriteLine("Некорректный выбор операции.");
                break;
        }

        Console.Write("Хотите выполнить еще одну операцию? (да/нет): ");
        string again = Console.ReadLine();
        if (again.ToLower() == "да")
        {
            Main(); // Рекурсивный вызов для выполнения еще одной операции
        }
        else
        {
            Console.WriteLine("До свидания!");
        }
    }
}
