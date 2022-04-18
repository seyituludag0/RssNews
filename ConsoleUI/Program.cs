

using System.ServiceModel.Syndication;
using System.Xml;

SyndicationFeed feed = new SyndicationFeed();

using (var reader = XmlReader.Create("https://www.mynet.com/haber/rss/gununozeti/"))
{
    feed = SyndicationFeed.Load(reader);
}

if (feed != null)
{
    foreach (var item in feed.Items)
    {
        Console.WriteLine($"Title:   {item.Title.Text}");
        Console.WriteLine($"Summary: {item.Summary.Text}");
    }
}