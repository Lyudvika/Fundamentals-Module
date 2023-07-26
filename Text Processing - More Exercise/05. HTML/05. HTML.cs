string titleOfArticle = Console.ReadLine();
Console.WriteLine("<h1>");
Console.WriteLine($"    {titleOfArticle}");
Console.WriteLine("</h1>");

string contentOfTheArticle = Console.ReadLine();
Console.WriteLine("<article>");
Console.WriteLine($"    {contentOfTheArticle}");
Console.WriteLine("</article>");

string input;

while ((input = Console.ReadLine()) != "end of comments")
{
    Console.WriteLine("<div>");
    Console.WriteLine($"    {input}");
    Console.WriteLine("</div>");
}