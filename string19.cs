namespace CheckNumberType
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int isInteger;
            double isDouble;

            if (int.TryParse(input, out isInteger))
            {
                Console.WriteLine("1");
            }
            else if (double.TryParse(input, out isDouble))
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}