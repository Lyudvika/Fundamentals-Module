namespace _02._Articles
{
    public class Program
    {
        public const string SeparatorForInfo = ", ";
        public const string SeparatorForOperation = ": ";
        static void Main(string[] args)
        {
            string[] information = Console.ReadLine().Split(SeparatorForInfo, StringSplitOptions.RemoveEmptyEntries);
            string title = information[0];
            string content = information[1];
            string author = information[2];

            Article article = new Article(title, content, author);

            int numOfOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfOperations; i++)
            {
                string[] infoArray = Console.ReadLine().Split(SeparatorForOperation, StringSplitOptions.RemoveEmptyEntries);
                string cmdType = infoArray[0];
                string newText = infoArray[1];

                if (cmdType == "Edit")
                {
                    article.Edit(newText);
                }
                else if (cmdType == "ChangeAuthor")
                {
                    article.ChangeAuthor(newText);
                }
                else if (cmdType == "Rename")
                {
                    article.Rename(newText);
                }
            }

            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author) 
        { 
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}