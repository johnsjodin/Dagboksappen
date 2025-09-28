namespace Dagboksappen
{
    internal class Design
    {
        public static void Pause()
        {
            Console.Write("\nTryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void CyanText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void RedText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void GreenText(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void AppHeader()
        {
            Console.Clear();
            CyanText("\n  Johns Dagboks-app(tm)\n");
            CyanText("=========================\n\n\n");
        }

        public static void MenuHeader()
        {
            CyanText("\t\tMENY\n\n");
        }

        public static void MenuOptionDesign(int option)
        {
            CyanText($"({option}) ");
        }

        public static void MenuChoiceDesign()
        {
            CyanText("\nAnge val: ");
        }
    }
}
