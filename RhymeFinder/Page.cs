using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RhymeFinder
{
    class Page
    {
        private string Content;
        public List<Word> Words { get; set; }

        /// <summary>
        /// создание страницы книги
        /// </summary>
        /// <param name="text">текст страницы</param>
        /// <param name="isSplitToWords">разделять ли на слова</param>
        public Page(string text, bool isSplitToWords)
        {
            Words = new List<Word>();
            Content = text;

            if (isSplitToWords)
                splitContentToWords();
        }

        /// <summary>
        /// Разделяет текст страницы (content) на слова
        /// </summary>
        public void splitContentToWords()
        {
            Words = new List<Word>();
            string t = Content;
            //разделяем строку на слова пробельным символам
            string pattern = @"\s+";
            string[] result = Regex.Split(t, pattern,
                                          RegexOptions.IgnoreCase);

            foreach (string r in result)
            {
                string patternCEnd = @"\W+$";

                //ищем знаки препинания и выделяем их в отдельные слова
                Match m = Regex.Match(r, patternCEnd);
                if (m.Success)
                {
                    string wordWithoutC = Regex.Replace(r, patternCEnd, "");
                    Words.Add(new Word(wordWithoutC, WordType.Word));

                    Words.Add(new Word(m.Value, WordType.Char));
                }
                else //обычные слова добавляем в список
                    Words.Add(new Word(r, WordType.Word));
            }
        }

        /// <summary>
        /// ищет рифмы к словам в ближаших словах
        /// </summary>
        /// <param name="wordsForward">сколько слов вперед проверять на рифмы</param>
        public void FindRhyme(int wordsForward)
        {
            int wf = wordsForward;
            foreach (Word w in Words)
            {   
                if (w.wordType == WordType.Char)
                    continue;

                int index = Words.IndexOf(w);
                wordsForward = wf;

                for (int i = 0; i < wordsForward; i++)
                {
                    if (index + i + 1 < Words.Count)
                    {
                        Word wNext = Words[index + i + 1];
                        //в случае если очередной символ - знак препинания, то счетчик слов увеличиваем
                        if (wNext.wordType == WordType.Char)
                          wordsForward++;
                        else
                           w.CheckRhyme(wNext);
                    }
                }
            }
        }

    }
}
