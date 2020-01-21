using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfAppIntroduktionString.IO
{
    class ClassIO
    {
        public ClassIO()
        {

        }
        //Opgave 1
        public void GetTestString(TextBox textBox)
        {
            textBox.Text = File.ReadAllText("../../Admiralen.txt");
        }

    }
}
