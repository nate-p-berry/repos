using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLibrary.NewsObjects
{
    public class ArticleCollection : IEnumerable
    {
        private Article[] _articles;
        public ArticleCollection(Article[] articleArray)
        {
            _articles = new Article[articleArray.Length];
            for (int i = 0; i < articleArray.Length; i++)
            {
                _articles[i] = articleArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
        internal ArticleEnumerator GetEnumerator()
        {
            return new ArticleEnumerator(_articles);
        }

    }
}
