using System;

namespace Dagboksappen
{
    internal class Diary
    {
        public List<DiaryEntry> _entries = new List<DiaryEntry>();

        public Diary()
        {
            _entries = FileHandler.LoadEntries();
        }

        public void AddEntry()
        {
            Design.AppHeader();

            Design.CyanText("Vad har du på hjärtat idag? Skriv av dig:\n\n");

            string userEntry = ValidateInput.GetString();

            DiaryEntry _entry = new DiaryEntry(DateTime.Now, userEntry);
            _entries.Add(_entry);

            Design.CyanText("\nDin dagboksanteckning har sparats!\n");
            Design.Pause();
        }

        public void ListAllEntries()
        {
            Design.AppHeader();

            if (_entries.Count == 0)
            {
                Design.RedText("Inga dagboksinlägg hittades.\n");
                Design.Pause();
                return;
            }
            Design.CyanText("Alla dagboksinlägg:\n");
            foreach (var entry in _entries)
            {
                Console.WriteLine($"{entry.Date:yyyy-MM-dd HH:mm} - {entry.Text}");
            }
            Design.Pause();
        }

        public void SearchEntryByDate()
        {
            Design.AppHeader();
            Design.CyanText("\nAnge ett datum att söka efter (yyyy-MM-dd): ");

            DateTime searchDate = ValidateInput.GetDate();

            var matchingEntries = _entries.Where(entry => entry.Date.Date == searchDate.Date).ToList();

            Design.AppHeader();

            if (matchingEntries.Count == 0)
            {
                Design.RedText($"\nInga anteckningar hittades för datumet {searchDate:yyyy-MM-dd}.\n\n");
            }
            else
            {
                Design.CyanText($"\nAnteckningar för datumet {searchDate:yyyy-MM-dd}:\n\n");
                foreach (var entry in matchingEntries)
                {
                    Console.WriteLine($"{entry.Date:HH:mm} - {entry.Text}");
                }
            }
            Design.Pause();
        }

        public void SaveToFile()
        {
            FileHandler.SaveEntries(_entries);
        }

        public void LoadFromFile()
        {
            _entries = FileHandler.LoadEntries();
        }
    }
}
