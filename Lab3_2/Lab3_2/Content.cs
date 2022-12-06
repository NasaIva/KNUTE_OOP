namespace Lab3_2
{
    class Content
    {
        private string content = "";
        public void SetContent(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Content: {content}");
        }
    }
}