namespace Dagboksappen
{
    internal class DiaryEntry
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }

        public DiaryEntry(DateTime date, string text)
        {
            Date = date;
            Text = text;
        }

        public DiaryEntry() { }
    }
}
