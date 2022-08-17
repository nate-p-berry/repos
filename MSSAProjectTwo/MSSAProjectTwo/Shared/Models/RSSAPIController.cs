using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Xml.Linq;

namespace MSSAProjectTwo.Shared.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class RSSAPIController : ControllerBase
    {
        readonly CultureInfo culture = new CultureInfo("en-US");

        [Route("allposts/{authorId}")]
        [HttpGet]
        public AuthorPosts AllPosts(string authorId)
        {
            AuthorPosts authorPosts = new AuthorPosts();
            try
            {
                XDocument doc = XDocument.Load("https://www.c-sharpcorner.com/members/" + authorId + "/rss");
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i =>
                               i.Name.LocalName == "item")
                              select new Feed
                              {
                                  Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = item.Elements().First(i => i.Name.LocalName == "link").Value.StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                                  PublishDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("dd-MMM-yyyy"),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  FeedType = item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("blog") ? "Blog" : item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("news") ? "News" : "Article",
                                  Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                              };

                authorPosts.AuthorName = entries.FirstOrDefault().Author;
                authorPosts.Feeds = entries.OrderByDescending(o => o.PubDate);
                return authorPosts;
            }
            catch
            {
                authorPosts.AuthorName = "NOT FOUND!";
                List<Feed> feeds = new List<Feed>();
                Feed feed = new Feed();
                feeds.Add(feed);
                authorPosts.Feeds = feeds;
                return authorPosts;
            }
        }

        [Route("latestposts")]
        [HttpGet]
        public IEnumerable<Feed> LatestPosts()
        {
            try
            {
                XDocument doc = XDocument.Load("https://www.c-sharpcorner.com/rss/latestcontentall.aspx");
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new Feed
                              {
                                  Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = item.Elements().First(i => i.Name.LocalName == "link").Value.StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                                  PublishDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("dd-MMM-yyyy"),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  FeedType = item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("blog") ? "Blog" : item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("news") ? "News" : "Article",
                                  Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                              };

                return entries.OrderByDescending(o => o.PubDate);
            }
            catch
            {
                List<Feed> feeds = new List<Feed>();
                Feed feed = new Feed();
                feeds.Add(feed);
                return feeds;
            }
        }

        [Route("featuredposts")]
        [HttpGet]
        public IEnumerable<Feed> FeaturedPosts()
        {
            try
            {
                XDocument doc = XDocument.Load("https://www.c-sharpcorner.com/rss/featuredarticles.aspx");
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new Feed
                              {
                                  Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = item.Elements().First(i => i.Name.LocalName == "link").Value.StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                                  PublishDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("dd-MMM-yyyy"),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  FeedType = item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("blog") ? "Blog" : item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("news") ? "News" : "Article",
                                  Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                              };

                return entries.OrderByDescending(o => o.PubDate);
            }
            catch
            {
                List<Feed> feeds = new List<Feed>();
                Feed feed = new Feed();
                feeds.Add(feed);
                return feeds;
            }
        }

        [Route("topposts")]
        [HttpGet]
        public IEnumerable<Feed> TrendingPosts()
        {
            try
            {
                XDocument doc = XDocument.Load("https://www.c-sharpcorner.com/rss/toparticles.aspx");
                var entries = from item in doc.Root.Descendants().First(i => i.Name.LocalName == "channel").Elements().Where(i => i.Name.LocalName == "item")
                              select new Feed
                              {
                                  Content = item.Elements().First(i => i.Name.LocalName == "description").Value,
                                  Link = item.Elements().First(i => i.Name.LocalName == "link").Value.StartsWith("/") ? "https://www.c-sharpcorner.com" + item.Elements().First(i => i.Name.LocalName == "link").Value : item.Elements().First(i => i.Name.LocalName == "link").Value,
                                  PubDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture),
                                  PublishDate = Convert.ToDateTime(item.Elements().First(i => i.Name.LocalName == "pubDate").Value, culture).ToString("dd-MMM-yyyy"),
                                  Title = item.Elements().First(i => i.Name.LocalName == "title").Value,
                                  FeedType = item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("blog") ? "Blog" : item.Elements().First(i => i.Name.LocalName == "link").Value.ToLowerInvariant().Contains("news") ? "News" : "Article",
                                  Author = item.Elements().First(i => i.Name.LocalName == "author").Value
                              };

                return entries;
            }
            catch
            {
                List<Feed> feeds = new List<Feed>();
                Feed feed = new Feed();
                feeds.Add(feed);
                return feeds;
            }
        }


    }
}