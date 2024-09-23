double result;
Console.Write("Введите первое число:");
double first = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число:");
double second = Convert.ToDouble(Console.ReadLine());
Console.Write("Определите действие между числами (+, -, *, /, %):");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        result = first + second;
        Console.WriteLine(result);
        break;
    case "-":
        result = first - second;
        Console.WriteLine(result);
        break;
    case "*":
        result = first * second;
        Console.WriteLine(result);
        break;
    case "/":
        result = first / second;
        Console.WriteLine(result);
        break;
    case "%":
        result = first % second;
        Console.WriteLine(result);
        break;
    default:
        Console.WriteLine("Действие не поддерживается");
        break;
}

Console.ReadKey();