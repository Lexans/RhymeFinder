using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhymeFinder
{
    class Book
    {
        private string content;
        public List<Page> Pages { get; set; }
        const int SymPerPage = 2750;

        public Book(string _content)
        {
            content = _content;
            Pages = new List<Page>();
            splitBookToPages();
        }

        /// <summary>
        /// разделяет текст книги на страницы, но не разделяет страницы на слова
        /// </summary>
        private void splitBookToPages()
        {
            for(int i = 0; i < content.Length; i+=2750)
            {
                string pageText;
                Page p;
                if (content.Length < (i + SymPerPage))
                {
                    pageText = content.Substring(i, content.Length - i);
                    p = new Page(pageText, false);
                }
                else
                    p = new Page(content.Substring(i, SymPerPage), false);
                Pages.Add(p);
            }
        }
    }
}
