namespace _02._Articles
{
    public class Program
    {
        public const string Separator = ", ";
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfArticles; i++)
            {
                string[] infoArray = Console.ReadLine().Split(Separator, StringSplitOptions.RemoveEmptyEntries);
                string title = infoArray[0];
                string content = infoArray[1];
                string author = infoArray[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
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


        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}