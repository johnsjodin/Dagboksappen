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
                Console.WriteLine("Spara till fil");
                Design.MenuOptionDesign(5);
                Console.WriteLine("Läs från fil");
                Design.MenuOptionDesign(6);
                Console.WriteLine("Avsluta programmet");
                Design.MenuChoiceDesign();

                userMenuChoice = ValidateInput.GetInt();

                switch (userMenuChoice)
                {
                    case 1:
                        diary.AddEntry();
                        break;
                    case 2:
                        diary.ListAllEntries();
                        break;
                    //case 3:
                    //    Diary.SearchEntryByDate();
                    //    break;
                    //case 4:
                    //    FileHandler.SaveToFile();
                    //    break;
                    //case 5:
                    //    FileHandler.ReadFromFile();
                    //    break;
                    case 6:
                        Console.WriteLine("Avslutar programmet...");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }
    }
}
