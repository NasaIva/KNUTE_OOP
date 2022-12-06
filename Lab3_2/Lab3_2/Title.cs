namespace Lab3_2
{
    class Title
    {
        private string title = "";
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Title: {title}");
        }
    }
}