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
                Console.Write("Felaktig inmatning, försök igen: ");
                Console.ResetColor();
            }
            return intInput;
        }
        public static DateTime GetDate()
        {
            DateTime dateInput;

            while (!DateTime.TryParse(Console.ReadLine(), out dateInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Felaktig inmatning, försök igen: ");
                Console.ResetColor();
            }
            return dateInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(stringInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Felaktig inmatning, försök igen: ");
                Console.ResetColor();
                stringInput = Console.ReadLine();
            }
            return stringInput;
        }
    }
}
