using CursachCRUD.Global_news;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CursachCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            INewsRepository newsRep = new NewsRepository();
            List<NewsModel> news = newsRep.GetAllNews().ToList();

            foreach (NewsModel n in news)
            {
                Console.WriteLine(n.Id + " " + n.Content + " " + n.DocName);
            }

            //for (int i = 1; i < 9; i++)
            //{
            //    NewsModel another = new NewsModel();
            //    another.Content = i.ToString();
            //    newsRep.AddNews(another);
            //}

            news = newsRep.GetLastTenNews().ToList();
            foreach (NewsModel n in news)
            {
                Console.WriteLine(n.Id + " " + n.Content + " " + n.DocName);
            }

            newsRep.DeleteNews(10);
        }
    }
}
