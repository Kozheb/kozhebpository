class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите свою фамилию:");
        string surname = Console.ReadLine();
        Console.WriteLine("Введите свое имя:");
        string name = Console.ReadLine();
        Console.WriteLine("Введите свое отчество");
        string patronymic = Console.ReadLine();
        string text = $"Здравствуйте, {surname} {name} {patronymic}";
        Console.WriteLine(text);
    }
}