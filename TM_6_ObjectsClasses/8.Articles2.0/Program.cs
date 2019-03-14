using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.Articles
{
    class Article
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

    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Article> listArticles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string someArticle = Console.ReadLine();
                string[] input = someArticle.Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];
                var article = new Article(title, content, author);
                listArticles.Add(article);
            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                listArticles = listArticles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                listArticles = listArticles.OrderBy(x => x.Content).ToList();
            }
            else if (criteria == "author")
            {
                listArticles = listArticles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join(Environment.NewLine, listArticles));
        }
    }


}
