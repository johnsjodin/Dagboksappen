namespace Dagboksappen
{
    internal class ValidateInput
    {
        public static int GetInt()
        {
            int intInput;

            while (!int.TryParse(Console.ReadLine(), out intInput))
            {
                Design.RedText("\nFelaktig inmatning!\n");
                Design.Pause();
                break;
            }
            return intInput;
        }
        public static DateTime GetDate()
        {
            DateTime dateInput;

            while (!DateTime.TryParse(Console.ReadLine(), out dateInput))
            {
                Design.RedText("\nFelaktig inmatning!\n");
                Design.Pause();
                return DateTime.MinValue;
            }
            return dateInput;
        }
        public static string GetString()
        {
            string stringInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(stringInput))
            {
                Design.RedText("\nDu måste skriva något för att spara en anteckning!\n");
                Design.Pause();
                return null;
            }

            return stringInput.Trim();
        }
    }
}
