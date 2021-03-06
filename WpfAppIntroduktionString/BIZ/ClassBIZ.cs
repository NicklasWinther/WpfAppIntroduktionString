﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfAppIntroduktionString.IO;

namespace WpfAppIntroduktionString.BIZ
{
    class ClassBIZ
    {
        public ClassBIZ()
        {

        }
        ClassIO classIO = new ClassIO();

        public void GetText(TextBox textBox)
        {
            classIO.GetTestString(textBox);
        }

        //Opgave 1
        public int CountAllLines(TextBox textBox)
        {
            int counter = textBox.LineCount;
            for (int i = 0; i < counter; i++)
            {
                if (textBox.GetLineText(i).Trim().Length == 0)
                {
                    counter--;
                }
            }
            return counter;
        }

        //Opgave 2
        public int CountAllChars(TextBox textBox)
        {
            return textBox.Text.Length;
        }

        //Opgave 3
        public int CountAllVokals(TextBox textBox)
        {
            int counter = 0;
            foreach (char c in textBox.Text.ToLower())
            {
                switch (c)
                {
                    case 'a':
                        counter++;
                            break;

                    case 'e':
                        counter++;
                        break;

                    case 'i':
                        counter++;
                        break;

                    case 'o':
                        counter++;
                        break;

                    case 'u':
                        counter++;
                        break;

                    case 'y':
                        counter++;
                        break;

                    case 'æ':
                        counter++;
                        break;

                    case 'ø':
                        counter++;
                        break;

                    case 'å':
                        counter++;
                        break;

                    default:
                        break;
                }
            }
            return counter;
        }

        //Opgave 4
        public string RemoveAllVokals(TextBox textBox)
        {
            return Regex.Replace(textBox.Text, "[aeiouyæøå]", "");
        }

        //Opgave 5
        public string MarkAndCountWord(TextBox textBox, string searchString)
        {
            int counter = 0;
            string text = textBox.Text;
            int index = text.IndexOf(searchString);
            while(index != -1)
            {
                text = text.Insert(index, "#>");
                counter++;
                index = text.IndexOf(searchString, index + 3);
            }


            return $"Ordet {searchString} blev fundet {counter} gang(e) og er blevet markeret med #>\n\n{text}";
        }

        //Opgave 6
        public string CountNumberOfWordLength(TextBox textBox)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            string text = textBox.Text;
            string result = "";

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (dictionary.TryGetValue(word.Length, out int value))
                {
                    value++;
                    dictionary[word.Length] = value;
                }
                else
                {
                    dictionary.Add(word.Length, 1);
                }
            }

            List<int> keys = dictionary.Keys.ToList();
            keys.Sort();

            foreach (int key in keys)
            {
                result = result + $"Ord med længden {key}: {dictionary[key]} stk\n";
            }

            return result;
        }

        //Opgave 7
        public  string CountNumberOfWordAppearance(TextBox textBox)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string[] words = textBox.Text.Split().Select(x => x.TrimEnd(",.;:-".ToCharArray())).ToArray();
            string result = "";

            foreach (string word in words)
            {
                if (dictionary.TryGetValue(word, out int value))
                {
                    value++;
                    dictionary[word] = value;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            List<string> dictionaryWords = dictionary.Keys.ToList();
            dictionaryWords.Sort();

            foreach (string dictionaryWord in dictionaryWords)
            {
                result = result + $"Ordet >> {dictionaryWord} << forekommer : {dictionary[dictionaryWord]} gang(e)\n";
            }

            return result;
        }

        //Opgave 8
        public void CutAwayLastLetterWhereWordIsLongerThan3Chars(TextBox oldText, TextBox newText)
        {
            StringCollection lines = new StringCollection();
            string result = "";

            int lineCount = oldText.LineCount;

            for (int i = 0; i < lineCount; i++)
            {
                lines.Add(oldText.GetLineText(i));
            }

            foreach (string line in lines)
            {
                string newLine = "";
                string[] words = line.Split().Select(x => x.Trim(",;.:-".ToCharArray())).ToArray();
                foreach (string word in words)
                {
                    if (word.Length > 3)
                    {
                        newLine += $" {word.Substring(0, word.Length - 1)}";
                    }
                    else
                    {
                        newLine += $" {word}";
                    }
                }
                result += newLine + System.Environment.NewLine;
            }
            newText.Text = result;

        }
    }
}
