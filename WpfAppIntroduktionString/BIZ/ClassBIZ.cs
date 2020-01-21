using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
