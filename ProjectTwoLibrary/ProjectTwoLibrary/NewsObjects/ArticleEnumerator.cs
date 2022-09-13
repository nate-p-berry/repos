using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLibrary.NewsObjects
{
    internal class ArticleEnumerator : IEnumerator
    {
        public NewsResponse.Article[] _articles;
        int position = -1;
        public ArticleEnumerator(NewsResponse.Article[] list)
        {
            _articles = list;
        }

        public bool MoveNext()
        {
            position++;
            return position < _articles.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public NewsResponse.Article Current
        {
            get
            {
                try
                {
                    return _articles[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
