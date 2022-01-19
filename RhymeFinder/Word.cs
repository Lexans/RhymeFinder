using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhymeFinder
{
    class Word
    {
        public string Text { get; set; }

        /// <summary>
        /// лучшая подобранная рифма для слова
        /// </summary>
        public RhymeType bestRhyme { get; set;}

        public Word(string t)
        {
            Text = t;
            bestRhyme = RhymeType.NoRhyme;
        }

        /// <summary>
        /// Проверка слова на рифму
        /// </summary>
        /// <param name="w">слово - рифма для проверки</param>
        /// <returns></returns>
        public RhymeType CheckRhyme(Word w)
        {
            RhymeType rt;

            if (w.Text.Length >= 3 && Text.Length >= 3 && Text.Substring(Text.Length - 3) == w.Text.Substring(w.Text.Length - 3))
                rt =  RhymeType.ThreeLetter;
            else if (w.Text.Length >= 2 && Text.Length >= 2 && Text.Substring(Text.Length - 2) == w.Text.Substring(w.Text.Length - 2))
                rt = RhymeType.TwoLetter;
            else if (CheckSpecialRhyme(Text, w.Text))
                rt = RhymeType.Special;
            else if(Text.ToLower() == w.Text.ToLower())
                rt = RhymeType.NoRhyme;
            else
                rt = RhymeType.NoRhyme;

            if (rt < bestRhyme)
                bestRhyme = rt;

            return rt;

        }


        /// <summary>
        /// проверка слов на специальную рифму
        /// </summary>
        /// <returns></returns>
        private bool CheckSpecialRhyme(string word1, string word2)
        {
            List<string[]> rhymes = new List<string[]>();

            rhymes.Add(new string[] { "сно", "сный" });

            foreach(string[] r in rhymes)
            {
                if (word1.EndsWith(r[0]) && word2.EndsWith(r[1])
                    || word1.EndsWith(r[1]) && word2.EndsWith(r[0]))
                    return true;
            }

            return false;
        }

    }
}
