int[] arr = new int[3];

try
{
    Console.WriteLine("Необходимо сформировать массив ЦИФР. Введите цифру для элемента 1:");
    arr[0] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите цифру для элемента 2:");
    arr[1] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите цифру для элемента 3:");
    arr[2] = Convert.ToInt32(Console.ReadLine());

    if ((arr[0] > 9 | arr[0] < 0) || (arr[1] > 9 | arr[1] < 0) || (arr[2] > 9 | arr[2] < 0))
    {
        throw new ArgumentOutOfRangeException ("Один из элементов массива не валиден");
    }

}

catch (ArgumentOutOfRangeException argumentOutOfRangeException)
{
    Console.WriteLine($"Error: {argumentOutOfRangeException.Message}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

double arraverage = (arr[0] + arr[1] + arr[2]) / arr.Length;
Console.WriteLine($"Среднее арифметическое введенного массива: {arraverage}");