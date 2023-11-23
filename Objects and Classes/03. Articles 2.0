using System;
using System.Collections.Generic;

class Article
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}

class Program
{
    static void Main()
    {
        int numberOfArticles = int.Parse(Console.ReadLine());
        List<Article> articles = new List<Article>();

        for (int i = 0; i < numberOfArticles; i++)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article
            {
                Title = title,
                Content = content,
                Author = author
            };

            articles.Add(article);
        }

        foreach (Article article in articles)
        {
            Console.WriteLine(article);
        }
    }
}
