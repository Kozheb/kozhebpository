/*Запрашивать у пользователя числа до тех пор пока пользователь не введёт букву Q
Числа добавляются в массив, в случае переполнения массива (кончилось начальное количество элементов) массив необходимо расширить (сохранив все введённые до этого значения) и продолжить записывать данные пользователя
После ввода буквы Q вывести на экран все введённые данные пользователем

В случае если пользователь ввёл данные не верно, программа не должна прекращать своё выполнение, а должна вывести информацию на экран и продолжить запрашивать данные от пользователя

Запросить что он хочет делать:
Очистить
Продолжить
Выйти

В случае Продолжить: продолжаем принимать данные от пользователя
В случае Очистить: Очищаем массив данных и снова спрашиваем у пользователя, что он хочет делать дальше
В случае Выйти: Завершаем программу, с выводом информации о том сколько пользователь ввёл элементов (количество) и количество совершённых им ошибок*/

class Program
{
    static int errorcount = 0;
    static double[] numsArr = new double[5];
    static int globalCounter = 0;
    static int resizeCounter = 0;
    private static void Main()
    {
        Console.WriteLine("Сформирован массив чисел. Введите значения для его элементов:");
        Arrinput();
    }


    static void Menu()
    {
        Console.WriteLine($"Выберите дальнейшее действие: 1 - продолжить ввод элементов в массив\n 2 - очистить данные в массиве\n 3 - Вывести данные массива на экран и выйти");
        try
        {
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Arrinput();
                    break;
                case 2:
                    Array.Clear(numsArr);
                    Menu();
                    break;
                case 3:
                    Console.WriteLine($"Результаты:\n Введенный массив:");
                    Array.ForEach(numsArr, Console.WriteLine);
                    Console.WriteLine($"Количество ошибок: {errorcount}");
                    Console.WriteLine($"Количество расширений массива: {resizeCounter}");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Опция не поддерживается");
                    Menu();
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Write("Опция не поддерживается");
            Menu();
        }
    }

    static void Arrinput()
    {
        for (; ; globalCounter++)
        {
            try
            {
                string custominput = Console.ReadLine().ToLower();

                if (custominput == "q")
                {
                    Console.WriteLine($"Ввод прерван.\n Введенный массив:");
                    Array.ForEach(numsArr, Console.WriteLine);
                    Console.WriteLine($"Количество ошибок: {errorcount}");
                    Console.WriteLine($"Количество расширений массива: {resizeCounter}");
                    Menu();
                    break;
                }

                numsArr[globalCounter] = double.Parse(custominput);
            }
            catch (FormatException)
            {
                Console.Write("Не верный формат введенного элемента");
                errorcount++;
                continue;
            }
            catch (IndexOutOfRangeException)
            {
                Array.Resize(ref numsArr, numsArr.Length * 2);
                resizeCounter++;
                continue;
            }
        }
    }
}