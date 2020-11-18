using System;
using System.Text;
using System.Text.RegularExpressions;

namespace WorkWithStrings
{
    /// <summary>
    /// String handling class
    /// </summary>
    public static class Words
    {
        /// <summary>
        /// Method of removing duplicate words
        /// </summary>
        /// <param name="myString">String of input</param>
        /// <returns>String without duplicate words</returns>
        public static string DelRepeatedWord(string myString)
        {
            string symbols = Regex.Replace(myString, "[^!.]", "");
            int numSymbol = 0;
            string newString = "";
            string[] sentences = myString.Split(new char[] { '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
            bool flag = true;
            if (symbols.Length != sentences.Length)
            {
                newString = "Неверно введена строка";
                flag = false;
            }
            if (flag == true)
            {
                foreach (var sentence in sentences)
                {
                    string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    newString += CheckRepeatWords(words) + symbols[numSymbol];
                    numSymbol++;

                }
            }
            return newString;
        }


        /// <summary>
        /// Method of checking duplicate words
        /// </summary>
        /// <param name="words">String of input</param>
        /// <returns>Flag(is or isnt duplicate words)</returns>
        public static string CheckRepeatWords(string[] words)
        {
            string newString = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                bool flag = true;
                int j = i + 1;
                while (flag == true && j < words.Length)
                {
                    int compareWords = string.Compare(words[i].ToLower(), words[j].ToLower());
                    if (compareWords == 0)
                    {
                        words[j] = "";
                    }
                    else
                    {
                        if (words[j] != "")
                        {
                            flag = false;
                        }
                    }
                    j++;
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    newString += words[i] + " ";
                    

                }

            }
            return newString;
        }


        /// <summary>
        /// Check internet adress
        /// </summary>
        /// <param name="sentences">Array of sentences</param>
        /// <returns>Flag(suitable sentence or not)</returns>
        public static bool CheckAdressAndDate(string[] sentences)
        {
            bool flag = true;// Check correсting input
            string pattern = @"^\w+\.\w+\s+(\d{2}\.\d{2}\.\d{4}|\d{2}/\d{2}/\d{2}|\d{2}\.\d{2}\.\d{2})\s+([0-2][0-3]-[0-5][0-9]|[0-1][0-9]-[0-5][0-9])$";
            foreach (var sentence in sentences)
            {
                if (!Regex.IsMatch(sentence.Trim(), pattern, RegexOptions.IgnoreCase))
                {
                    flag = false;
                }
            }
            return flag;
        }
        /// <summary>
        ///  String processing method
        /// </summary>
        /// <param name="myString">string of input</param>
        /// <returns>Suitable  string</returns>
        public static StringBuilder GetString(string myString)
        {
            string[] separator = { ". " };
            myString += " ";
            string[] sentences = myString.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(sentences.Length);
            bool flag = CheckAdressAndDate(sentences);
            StringBuilder newString = null;

            if (flag == true)
            {
                newString = new StringBuilder();

                foreach (var sentence in sentences)
                {
                    string[] empty = { " " };
                    string[] items = sentence.Split(empty, StringSplitOptions.RemoveEmptyEntries);
                    int counterNeedSentences = 0;
                    for (int i = 0; i < sentences.Length; i++)
                    {
                        string[] needItem = sentences[i].Split(empty, StringSplitOptions.RemoveEmptyEntries);

                        if (needItem[0] == items[0])
                        {
                            counterNeedSentences++;
                        }

                    }
                    if (counterNeedSentences == 1)
                    {
                        newString.Append(sentence + separator[0]);
                    }

                }

            }
            return newString;
        }

    }
}
