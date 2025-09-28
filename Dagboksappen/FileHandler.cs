using System.Text.Json;

namespace Dagboksappen
{
    internal class FileHandler
    {
        private const string FilePath = "../../../entries.json";

        // Spara hela dictionaryn som JSON
        public static void SaveEntries(Dictionary<DateTime, DiaryEntry> entries)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true // för snygg formatering
                };

                // Serialisera och skriv till fil
                string json = JsonSerializer.Serialize(entries, options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid sparning: {ex.Message}");
                LogError($"SaveEntries: {ex.Message}");
            }
        }

        // Ladda hela dictionaryn från JSON
        public static Dictionary<DateTime, DiaryEntry> LoadEntries()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new Dictionary<DateTime, DiaryEntry>();

                string json = File.ReadAllText(FilePath);
                var entries = JsonSerializer.Deserialize<Dictionary<DateTime, DiaryEntry>>(json);

                return entries ?? new Dictionary<DateTime, DiaryEntry>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid laddning: {ex.Message}");
                LogError($"LoadEntries: {ex.Message}");
                return new Dictionary<DateTime, DiaryEntry>();
            }
        }

        private static void LogError(string message)
        {
            string logFilePath = "../../../error.log";
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";

            try
            {
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            }
            catch
            {
                // Om loggning misslyckas, gör inget för att undvika att krascha programmet
            }
        }
    }
}
