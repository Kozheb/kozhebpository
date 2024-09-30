/*Сделать небольшой каталог пользователей (от 3 до 5)
С консоли вводятся данные о пользователе (не менее двух вариантов)
данные записываются в массив (либо двумерный, либо массив массивов, либо несколько разных массивов)
По окончанию запросить у пользователя какого человека он хочет вывести*/

using System.Globalization;

class Program
{
    static void Main()
    {
        string[,] arr = new string[3, 3];
        Console.WriteLine("Введите данные пользователя в массив. Массив хранит данные трех пользователей.");

        try
        {
            Console.WriteLine("Данные пользователя 1");
            Console.WriteLine("Имя:");
            arr[0, 0] = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            arr[0, 1] = Console.ReadLine();
            Console.WriteLine("Должность:");
            arr[0, 2] = Console.ReadLine();

            Console.WriteLine("Данные пользователя 2");
            Console.WriteLine("Имя:");
            arr[1, 0] = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            arr[1, 1] = Console.ReadLine();
            Console.WriteLine("Должность:");
            arr[1, 2] = Console.ReadLine();

            Console.WriteLine("Данные пользователя 3");
            Console.WriteLine("Имя:");
            arr[2, 0] = Console.ReadLine();
            Console.WriteLine("Фамилия:");
            arr[2, 1] = Console.ReadLine();
            Console.WriteLine("Должность:");
            arr[2, 2] = Console.ReadLine();
        }

        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Данные какого пользователя Вы хотите вывести на экран ? Введите его порядковый номер:");
        try
        {
            int user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    Console.WriteLine($"{arr[0, 0]} {arr[0, 1]}, {arr[0, 2]}");
                    break;
                case 2:
                    Console.WriteLine($"{arr[1, 0]} {arr[1, 1]}, {arr[1, 2]}");
                    break;
                case 3:
                    Console.WriteLine($"{arr[2, 0]} {arr[2, 1]}, {arr[2, 2]}");
                    break;
                default:
                    Console.WriteLine("Пользователя с таким порядковым номером не существует");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Значение не является порядковым номером пользователя");
        }
    }
}