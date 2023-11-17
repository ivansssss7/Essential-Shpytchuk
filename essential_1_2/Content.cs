
namespace essential_1_2
{
    internal class Content
    {
        string field;
        public string Field
        {
            get
            {
                if (field != null)
                    return field;
                else
                    return "вміст відсутній.";
            }
            set
            {
                field = value;
            }
        }
        public Content(string content)
        {
            field = content;

        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Field);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
