namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем строку у пользователя
            Console.WriteLine("Введите строку из русских слов, разделенных пробелами:");
            string input = Console.ReadLine();

            // Разделяем строку на слова
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Выводим количество слов
            Console.WriteLine($"Количество слов в строке: {words.Length}");
        }
    }
}