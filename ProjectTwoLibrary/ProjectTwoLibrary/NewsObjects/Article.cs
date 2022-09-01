using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLibrary.NewsObjects
{
    public class Article
    {
        private string _author;
        private string _title;
        private string _description;
        private string _url;
        private string _urlToImage;
        private string _publishedAt;
        private string _content;

        public string Author { get => _author; set => _author = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public string Url { get => _url; set => _url = value; }
        public string UrlToImage { get => _urlToImage; set => _urlToImage = value; }
        public string PublishedAt { get => _publishedAt; set => _publishedAt = value; }
        public string Content { get => _content; set => _content = value; }
    }
}
