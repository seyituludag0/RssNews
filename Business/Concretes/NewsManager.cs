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
        public List<string> GetAllAcrossNews()
        {
            List<string> news = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            string APIURLFeedBurner = "https://servicemodule.propertynl.com/api/export/GetRSSArticles?newsChannel=NL&ignoreSticky=true";
            using (var reader = XmlReader.Create(APIURLFeedBurner))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " Across Magazine");
            }
            return news;
        }

       

        public List<string> GetAllNews()
        {
            List<string> news = new List<string>();

            string APIURL = "https://rss.nytimes.com/services/xml/rss/nyt/World.xml";

            SyndicationFeed syndicationFeed = new SyndicationFeed();
            using (var reader = XmlReader.Create(APIURL))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " New York Times");
            }


            string APIURLFeedBurner = "http://feeds.feedburner.com/retaildetailbe";
            using (var reader = XmlReader.Create(APIURLFeedBurner))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " Retail Detail");
            }
           
            string APIURLAcross = "https://servicemodule.propertynl.com/api/export/GetRSSArticles?newsChannel=NL&ignoreSticky=true";
            using (var reader = XmlReader.Create(APIURLAcross))
            {

                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() +" Across Magazine");
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

        
        public List<string> NewYorkGetNews()
        {
            List<string> news = new List<string>();
            SyndicationFeed syndicationFeed = new SyndicationFeed();
            string APIURL = "https://rss.nytimes.com/services/xml/rss/nyt/World.xml";
            using (var reader = XmlReader.Create(APIURL))
            {
                syndicationFeed = SyndicationFeed.Load(reader);
            }
            foreach (SyndicationItem item in syndicationFeed.Items)
            {
                news.Add(item.Title.Text + " - " + item.PublishDate.ToString() + " New York Times");
            }
            return news;
        }

        public string NewYorkTimesNewsTitleSearch(string key)
        {
            var getAllNews = NewYorkGetNews();
            var matchingNews = getAllNews.Where(n => n.Contains(key));
            var value = "";
            foreach (var item in matchingNews)
            {
                value = item;
            }
            return value;
        }
    }
}
