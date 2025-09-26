namespace Dagboksappen
{
    internal class Design
    {
        public static void AppHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n  Johns Supersäkra Dagboks-app(tm)");
            Console.WriteLine("====================================\n\n");
            Console.ResetColor();
        }

        public static void MenuHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\tMENY\n");
            Console.ResetColor();
        }

        public static void MenuOptionDesign(int option)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"({option}) ");
            Console.ResetColor();
        }

        public static void MenuChoiceDesign()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nAnge val: ");
            Console.ResetColor();
        }
    }
}
