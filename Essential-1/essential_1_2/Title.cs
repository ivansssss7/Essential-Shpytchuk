
namespace essential_1_2
{
    public class Title
    {
        string field = null;
        public string Field
        {
            get
            {
                if (field != null)
                    return field;
                else
                    return "Заголовок відсутній.";
            }
            set
            {
                field = value;
            }
        }
        public Title(string title)
        {
            field = title;

        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Field);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
