using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml;
using System.ServiceModel.Syndication;

namespace MSSAProjectTwo.Shared.Models
{
    public class RSSFeedController : ControllerBase
    {
        [ResponseCache(Duration = 1200)]
        [HttpGet]
        [Route("feed.rss")]
        public async Task<IActionResult> GetRssFeed()
        {
            return Accepted();
        }
    }

    public class AuthorPosts
    {
        public string AuthorName { get; set; }
        public IEnumerable<Feed> Feeds { get; set; }
    }

    public class Feed
    {
        public Feed()
        {
            Link = "";
            Title = "";
            FeedType = "";
            Author = "";
            Content = "";
            PubDate = DateTime.Today;
            PublishDate = DateTime.Today.ToString("yyyy-MM-dd");
        }

        public string Link { get; set; }
        public string Title { get; set; }
        public string FeedType { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public string PublishDate { get; set; }
    }
}
