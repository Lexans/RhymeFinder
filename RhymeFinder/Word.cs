
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
        public RhymeType bestRhyme { get; set; }

        public WordType wordType { get; set; }


        public Word(string t)
        {
            Text = t;
            bestRhyme = RhymeType.NoRhyme;
        }

        public Word(string t, WordType wt)
        {
            Text = t;
            bestRhyme = RhymeType.NoRhyme;
            wordType = wt;
        }

        /// <summary>
        /// Проверка слова на рифму
        /// </summary>
        /// <param name="w">слово - рифма для проверки</param>
        /// <returns></returns>
        public RhymeType CheckRhyme(Word w)
        {
            RhymeType rt;

            if (Text.ToLower() == w.Text.ToLower())
                rt = RhymeType.NoRhyme;
            else if (w.Text.Length >= 3 && Text.Length >= 3 && Text.Substring(Text.Length - 3) == w.Text.Substring(w.Text.Length - 3))
                rt = RhymeType.ThreeLetter;
            else if (w.Text.Length >= 2 && Text.Length >= 2 && Text.Substring(Text.Length - 2) == w.Text.Substring(w.Text.Length - 2))
                rt = RhymeType.TwoLetter;
            else if (CheckSpecialRhyme(Text, w.Text))
                rt = RhymeType.Special;
            else
                rt = RhymeType.NoRhyme;

            //сохраняем сведения о лучшей рифме
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


            bool or = CheckOpenRhyme(word1, word2);
            if (or)
                return true;

            bool cr = CheckCloseRhyme(word1, word2);
            if (cr)
                return true;

            bool dv = CheckDoubleVowelMatch(word1, word2);
            if (dv)
                return true;

            return false;
        }


        /// <summary>
        /// проверка двух слов на открытую рифму (на конце согласная, потом гласная)
        /// </summary>
        private bool CheckOpenRhyme(string word1, string word2)
        {
            word1 = word1.TrimEnd(new char[] { 'й' });
            word2 = word2.TrimEnd(new char[] { 'й' });

            if (word1.Length < 2 || word2.Length < 2)
                return false;

            bool cm = СonsonantMatch(word1[word1.Length-2], word2[word2.Length - 2]);
            bool vm = VowelMatch(word1[word1.Length-1], word2[word2.Length-1]);
           
            return (cm && vm);
        }

        /// <summary>
        /// проверка двух слов на закрытую рифму (на конце гласная, потом согласная)
        /// </summary>
        private bool CheckCloseRhyme(string word1, string word2)
        {
            word1 = word1.TrimEnd(new char[] { 'ь' });
            word2 = word2.TrimEnd(new char[] { 'ь' });

            if (word1.Length < 2 || word2.Length < 2)
                return false;

            bool vm = VowelMatch(word1[word1.Length - 2], word2[word2.Length - 2]);
            bool cm = СonsonantMatch(word1[word1.Length - 1], word2[word2.Length - 1]);

            return (cm && vm);
        }

        /// <summary>
        /// Проверка двух слов на рифму слов с двумя гласными в конце, например струи, свои.
        /// </summary>
        private bool CheckDoubleVowelMatch(string word1, string word2)
        {
            char[] vowels = new char[]
            {'у', 'е', 'ё', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю'};

            if (word1.Length < 2 || word2.Length < 2)
                return false;

            if (vowels.Contains(word1[word1.Length - 2]) &&
                vowels.Contains(word2[word2.Length - 2]) &&
                word1[word1.Length - 1] == word2[word2.Length - 1] &&
                vowels.Contains(word1[word1.Length - 1]))
                return true;
            else return false;
        }

        /// <summary>
        /// проверка двух согласных на совпадение или парность
        /// </summary>
        private bool СonsonantMatch(char let1, char let2)
        {
            char[] consonants = new char[] 
            {'ц', 'к', 'н', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п',
                'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б' };
            string[] consonantsPaired = new string[]
            {
                "бп","пб","вф","фв","гк","кг","дт","тд","зс","сз","жш","шж","рл", "лр", "мн", "нм"
            };


            if (let1 == let2 && consonants.Contains(let1) ||
                consonantsPaired.Contains(let1.ToString() + let2.ToString()))
                return true;
            else
                return false;
        }

        /// <summary>
        /// проверка двух гласных на совпадение или парность
        /// </summary>
        private bool VowelMatch(char let1, char let2)
        {
           
            char[] vowels = new char[]
            {'у', 'е', 'ё', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю'};
            string[] vowelsPaired = new string[]
            {
                "ая","яа","ыи","иы","ую","юу","ёо","оё","еэ","эе"
            };


            if (let1 == let2 && vowels.Contains(let1) ||
                vowelsPaired.Contains(let1.ToString() + let2.ToString()))
                return true;
            else
                return false;
        }

    }
}
