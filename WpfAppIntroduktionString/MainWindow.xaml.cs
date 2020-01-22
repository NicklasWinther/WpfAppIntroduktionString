using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppIntroduktionString.BIZ;

namespace WpfAppIntroduktionString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ classBIZ = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
            classBIZ.GetText(textBoxLeft);
        }

        //Opgave 1
        private void Opgave1_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = "Antal linjer med tekst: " + classBIZ.CountAllLines(textBoxLeft).ToString();
            
        }

        //Opgave 2
        private void Opgave2_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = "Antal tegn: " + classBIZ.CountAllChars(textBoxLeft);
        }

        //Opgave 3
        private void Opgave3_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = "Antal vokaler: " + classBIZ.CountAllVokals(textBoxLeft);
        }

        //Opgave 4
        private void Opgave4_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = classBIZ.RemoveAllVokals(textBoxLeft);
        }

        //Opgave 5
        private void Opgave5_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = classBIZ.MarkAndCountWord(textBoxLeft, textBoxBottom.Text);
        }

        //Opgave 6
        private void Opgave6_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = classBIZ.CountNumberOfWordLength(textBoxLeft);
        }

        //Opgave 7
        private void Opgave7_Click(object sender, RoutedEventArgs e)
        {
            textBoxRight.Clear();
            textBoxRight.Text = classBIZ.CountNumberOfWordAppearance(textBoxLeft);
        }
    }
}
