using MartinKearnTestNuget.Interfaces;

namespace MartinKearnTestNuget.Services
{
    public class BookService : IBookService
    {
        public string GenerateBookTitle()
        {
            Random rand = new();
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < 10; i++)
            {
                randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                str += letter;
            }

            return str;
        }
    }
}
