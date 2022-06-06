using MartinKearnTestNuget.Interfaces;

namespace MartinKearnTestNuget.Services
{
    public class BookService : IBookService
    {
        public string GenerateBookTitle()
        {
            Random rand = new();
            int stringlen = rand.Next(4, 10);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < stringlen; i++)
            {
                randValue = rand.Next(0, 26);
                letter = Convert.ToChar(randValue + 65);
                str += letter;
            }

            return str;
        }
    }
}
