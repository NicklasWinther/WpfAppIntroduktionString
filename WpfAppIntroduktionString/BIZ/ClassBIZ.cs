using System;
using System.Collections.Generic;
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
    }
}
