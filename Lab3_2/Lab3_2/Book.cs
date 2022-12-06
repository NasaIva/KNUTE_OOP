namespace Lab3_2
{
    class Book
    {
        static void Main(string[] args)
        {
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.Write("Title: ");
            title.SetTitle(Console.ReadLine());

            Console.Write("Author: ");
            author.SetAuthor(Console.ReadLine());

            Console.Write("Content: ");
            content.SetContent(Console.ReadLine());
            Console.WriteLine("");

            title.Show();
            author.Show();
            content.Show();
        }
    }
}