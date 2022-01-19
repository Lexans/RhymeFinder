using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RhymeFinder
{
    class Text
    {
        public List<Word> Words { get; set; }

        public Text(string t)
        {
            Words = new List<Word>();
            splitTextToWords(t);
        }

        /// <summary>
        /// ищет рифмы к словам в ближаших словах
        /// </summary>
        /// <param name="wordsForward">сколько слов вперед проверять на рифмы</param>
        public void FindRhyme(int wordsForward)
        {
            foreach(Word w in Words)
            {
                for(int i = 0; i < wordsForward; i++)
                {
                    int index = Words.IndexOf(w);
                    if(index + i + 1 < Words.Count)
                        w.CheckRhyme(Words[index + i + 1]);   
                }
            }
        }

        private void splitTextToWords(string t)
        {
            //разделяем строку на слова пробельным символам
            string pattern = @"\s+";
            string[] result = Regex.Split(t, pattern,
                                          RegexOptions.IgnoreCase);

            foreach(string r in result)
            {
                string patternCEnd = @"\W+$";

                //ищем знаки препинания и выделяем их в отдельные слова
                Match m = Regex.Match(r, patternCEnd);
                if (m.Success)
                {
                    string wordWithoutC = Regex.Replace(r, patternCEnd, "");
                    Words.Add(new Word(wordWithoutC));

                    Words.Add(new Word(m.Value)); 
                }
                else //обычные слова добавляем в список
                    Words.Add(new Word(r));
            }
        }
    }
}
