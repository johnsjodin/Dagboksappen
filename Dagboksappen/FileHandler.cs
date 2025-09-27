namespace Dagboksappen
{
    internal class FileHandler
    {
        private const string FilePath = "../../../entries.txt";
        private const string DateFormat = "yyyy:MM:dd HH:mm";

        public static void SaveEntries(List<DiaryEntry> entries)
        {
            try
            {
                var lines = new List<string>();
                foreach (var entry in entries)
                {
                    string line = $"{entry.Date.ToString(DateFormat)}|{entry.Text}";
                    lines.Add(line);
                }

                File.WriteAllLines(FilePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid sparning: {ex.Message}");
            }
        }

        public static List<DiaryEntry> LoadEntries()
        {
            var entries = new List<DiaryEntry>();

            try
            {
                if (!File.Exists(FilePath))
                    return entries;

                string[] lines = File.ReadAllLines(FilePath);

                foreach (var line in lines)
                {
                    string[] parts = line.Split('|', 2);
                    if (parts.Length == 2 &&
                        DateTime.TryParseExact(parts[0], DateFormat, null,
                            System.Globalization.DateTimeStyles.None, out DateTime date))
                    {
                        entries.Add(new DiaryEntry(date, parts[1]));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid laddning: {ex.Message}");
            }

            return entries;
        }
    }
}
