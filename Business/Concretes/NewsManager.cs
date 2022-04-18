using Business.Abstracts;
using Business.BusinessAspects.Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Business.Concretes
{
    public class NewsManager : INewsService
    {
        public List<string> MynetGetAllNewsTitle()
        {
            List<string> newsTitle = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            using (var reader = XmlReader.Create("https://www.mynet.com/haber/rss/gununozeti/"))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                newsTitle.Add(item.Summary.Text);
            }
            return newsTitle;
        }

        public string MynetNewsTitleSearch(string key)
        {
            var getAllNews = MynetGetAllNewsTitle();
            var matchingNews = getAllNews.Where(n => n.Contains(key));
            var value = "";
            foreach (var item in matchingNews)
            {
                value = item;
            }
            return value;
        }

       
        public List<string> NewYorkGetNews()
        {
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            List<string> news = new List<string>();

            string APIURL = "https://rss.nytimes.com/services/xml/rss/nyt/World.xml";


            using (var reader = XmlReader.Create(APIURL))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " FeedBurner");
            }

            return news;
        }

        public List<string> GetAllFeedburnerNews()
        {
            List<string> news = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            string APIURL = "http://feeds.feedburner.com/retaildetailbe";

            using (var reader = XmlReader.Create(APIURL))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " FeedBurner");
            }

            return news;
        }

        public List<string> GetAllRetaildetailbe()
        {
            List<string> news = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();

            string APIURLFeedBurner = "http://feeds.feedburner.com/retaildetailbe";
            using (var reader = XmlReader.Create(APIURLFeedBurner))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " Retail Detail");
            }
            return news;

        }

        public List<string> GetAllAcrossNews()
        {
            List<string> news = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            string APIURLAcross = "https://servicemodule.propertynl.com/api/export/GetRSSArticles?newsChannel=NL&ignoreSticky=true";
            using (var reader = XmlReader.Create(APIURLAcross))
            {

                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + " Across Magazine" + " - " + item.PublishDate.ToString());
            }
            return news;

        }

        public void GetAllNews()
        {
            NewYorkGetNews();
            GetAllFeedburnerNews();
            GetAllRetaildetailbe();
            GetAllAcrossNews();
        }
    }
}
