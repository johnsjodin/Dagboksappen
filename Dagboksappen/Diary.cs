namespace Dagboksappen
{
    internal class Diary
    {
        private Dictionary<DateTime, DiaryEntry> _entriesByDate = new Dictionary<DateTime, DiaryEntry>();

        public Diary()
        {
            _entriesByDate = FileHandler.LoadEntries();
        }

        public void AddEntry()
        {
            Design.AppHeader();

            Design.CyanText("Vad har du på hjärtat idag?\n\n");

            string userEntry = ValidateInput.GetString();

            if (userEntry == null)
            {
                return;
            }

            DateTime today = DateTime.Now.Date;
            string timestamp = DateTime.Now.ToString("HH:mm");

            if (_entriesByDate.ContainsKey(today))
            {
                // Uppdatera befintligt inlägg med ny text och tidsstämpel
                _entriesByDate[today].Text += $"\n({timestamp}) {userEntry}";
                Design.CyanText("\nDagens dagboksanteckning har uppdaterats med ny text!\n");
            }
            else
            {
                // Skapa ett nytt inlägg med tidsstämpel
                DiaryEntry newEntry = new DiaryEntry(today, $"({timestamp}) {userEntry}");
                _entriesByDate[today] = newEntry;
                Design.CyanText("\nDin dagboksanteckning har sparats!\n");
            }

            Design.Pause();
        }

        public void ListAllEntries()
        {
            Design.AppHeader();

            if (_entriesByDate.Count == 0)
            {
                Design.RedText("Inga dagboksinlägg hittades.\n");
                Design.Pause();
                return;
            }
            Design.CyanText("Alla dagboksinlägg:\n\n");
            foreach (var entry in _entriesByDate)
            {
                Design.YellowText($"{entry.Key:yyyy-MM-dd}\n");
                Console.WriteLine($"{entry.Value.Text}\n");
                //Console.WriteLine($"{entry.Key:yyyy-MM-dd}\n{entry.Value.Text}");
            }
            Design.Pause();
        }

        public void SearchEntryByDate()
        {
            Design.AppHeader();
            Design.CyanText("\nAnge ett datum att söka efter (yyyy-MM-dd): ");

            DateTime searchDate = ValidateInput.GetDate();

            if (_entriesByDate.TryGetValue(searchDate.Date, out DiaryEntry entry))
            {
                Design.CyanText($"\nAnteckning för datumet {searchDate:yyyy-MM-dd}:\n\n");
                Console.WriteLine($"{entry.Text}");
            }
            else
            {
                Design.RedText($"\nInga anteckningar hittades för datumet {searchDate:yyyy-MM-dd}.\n");
            }

            Design.Pause();
        }

        public void DeleteEntryByDate()
        {
            Design.AppHeader();
            Design.CyanText("\nAnge ett datum att ta bort (yyyy-MM-dd): ");

            DateTime dateToDelete = ValidateInput.GetDate();

            if (_entriesByDate.Remove(dateToDelete.Date))
            {
                Design.CyanText($"\nInlägget för datumet {dateToDelete:yyyy-MM-dd} har tagits bort.\n");
            }
            else
            {
                Design.RedText($"\nInga inlägg hittades för datumet {dateToDelete:yyyy-MM-dd}.\n");
            }

            Design.Pause();
        }

        public void SaveToFile()
        {
            FileHandler.SaveEntries(_entriesByDate);
        }

        public void LoadFromFile()
        {
            _entriesByDate = FileHandler.LoadEntries();
        }
    }
}
