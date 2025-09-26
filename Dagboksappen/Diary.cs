namespace Dagboksappen
{
    internal class Diary
    {
        private List<DiaryEntry> _entries = new List<DiaryEntry>();
        private string _filePath = "../../../entries.txt";

        public Diary()
        {
            
        }

        public void Pause()
        {
            Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
            Console.Clear();
        }

        public void AddEntry()
        {
            Console.Clear();
            Design.AppHeader();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Vad har du på hjärtat idag? Skriv av dig:\n");
            Console.ResetColor();
            string userEntry = ValidateInput.GetString();
            DiaryEntry _entry = new DiaryEntry(DateTime.Now, userEntry);
            _entries.Add(_entry);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nInlägget sparat.");
            Console.ResetColor();
            Pause();
        }

        public void ListAllEntries()
        {
            Console.Clear();
            Design.AppHeader();

            if (_entries.Count == 0)
            {
                Console.WriteLine("Inga dagboksinlägg hittades.");
                Pause();
                return;
            }
            Console.WriteLine("Alla dagboksinlägg:");
            foreach (var entry in _entries)
            {
                Console.WriteLine($"{entry.Date:yyyy-MM-dd HH:mm} - {entry.Text}");
            }
            Pause();
        }

        public static void SearchEntryByDate()
        {
            
        }
    }
}
