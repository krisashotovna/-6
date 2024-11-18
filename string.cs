namespace FirstUppercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получить число N от пользователя
            Console.WriteLine("Введите число N (от 1 до 26): ");
            int n = int.Parse(Console.ReadLine());

            // Проверить, что число находится в допустимом диапазоне
            if (n < 1 || n > 26)
            {
                Console.WriteLine("Ошибка: число N должно быть от 1 до 26.");
                return;
            }

            // Вывести первые N прописных букв латинского алфавита
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                // Проверить, что мы вывели уже N букв
                if (letter - 'A' >= n)
                {
                    break;
                }

                // Вывести прописную букву
                Console.Write(letter);
            }

            Console.WriteLine();
        }
    }
}