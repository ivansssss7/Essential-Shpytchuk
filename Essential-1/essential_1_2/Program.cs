

namespace essential_1_2
{
    class Program
    {
        static void Main()
        {
            Author author = new Author("Kyle Sympson");
            Title title = new Title("You Don't Know JS");
            Content content = new Content("About javascript");
            Book book = new Book(author, title, content);
            book.Show();
        }
    }
}
