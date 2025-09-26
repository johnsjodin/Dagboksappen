namespace Dagboksappen
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

                string userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int choice))
                {
                    switch (choice)
                    {
                        //case 1:
                        //    Diary.AddEntry();
                        //    break;
                        //case 2:
                        //    Diary.ListAllEntries();
                        //    break;
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
                else
                {
                    Console.WriteLine("Ogiltig inmatning. Vänligen ange en siffra mellan 1 och 6.");
                }
            }
        }
    }
}
