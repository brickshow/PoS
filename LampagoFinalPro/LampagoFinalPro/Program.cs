namespace LampagoFinalPro
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ItemsStorage itemsStorage = new ItemsStorage();

            itemsStorage.MainMenu();
            itemsStorage.greetings();





            Console.ReadKey();
        }
    }
}