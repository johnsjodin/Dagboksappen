namespace Dagboksappen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            DisplayMenu(diary);
        }

        public static void DisplayMenu(Diary diary)
        {
            int userMenuChoice;

            while (true)
            {
                Design.AppHeader();
                Design.MenuHeader();

                Design.MenuOptionDesign(1);
                Console.WriteLine("Skriv ny dagboksanteckning");
                Design.MenuOptionDesign(2);
                Console.WriteLine("Lista alla anteckningar");
                Design.MenuOptionDesign(3);
                Console.WriteLine("Sök anteckning efter datum");
                Design.MenuOptionDesign(4);
                Console.WriteLine("Ta bort inlägg efter datum");
                Design.MenuOptionDesign(5);
                Console.WriteLine("Spara till fil");
                Design.MenuOptionDesign(6);
                Console.WriteLine("Läs från fil");
                Design.MenuOptionDesign(7);
                Console.WriteLine("Avsluta programmet");
                Design.MenuChoiceDesign();

                userMenuChoice = ValidateInput.GetInt();

                switch (userMenuChoice)
                {
                    case 1:
                        diary.AddEntry();
                        diary.SaveToFile();
                        break;
                    case 2:
                        diary.LoadFromFile();
                        diary.ListAllEntries();
                        break;
                    case 3:
                        diary.LoadFromFile();
                        diary.SearchEntryByDate();
                        break;
                    case 4:
                        diary.DeleteEntryByDate();
                        diary.SaveToFile();
                        break;
                    case 5:
                        diary.SaveToFile();
                        Design.CyanText("\nAnteckningarna har sparats till fil.\n\n");
                        Design.Pause();
                        break;
                    case 6:
                        diary.LoadFromFile();
                        Design.CyanText("\nAnteckningarna har laddats från fil.\n\n");
                        Design.Pause();
                        break;
                    case 7:
                        Design.CyanText("\nTack för att du använde Johns Dagboksapp!\n");
                        return;
                    default:
                        Design.RedText("\nFelaktig inmatning!\n");
                        Design.Pause();
                        break;
                }
            }
        }
    }
}
