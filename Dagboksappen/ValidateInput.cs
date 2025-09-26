namespace Dagboksappen
{
    internal class ValidateInput
    {
        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
            }
            return intInput;
        }
        public static double GetDouble()
        {
            double doubleInput;

            while (!double.TryParse(Console.ReadLine(), out doubleInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
            }
            return doubleInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Felaktig inmatning, försök igen:");
                Console.ResetColor();
                stringInput = Console.ReadLine();
            }
            return stringInput;
        }
    }
}
