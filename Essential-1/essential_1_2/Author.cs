
namespace essential_1_2
{
    public class Author
    {
        string field = null;

        public string Field
        {
            get
            {
                if (field != null)
                    return field;
                else
                    return "Автор відсутній.";
            }
            set
            {
                field = value;
            }
        }
        public Author(string author) 
        {
            field = author;

        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Field);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
