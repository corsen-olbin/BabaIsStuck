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

namespace BabaIsStuck.UserControls
{
    /// <summary>
    /// Interaction logic for AdvancedTab.xaml
    /// </summary>
    public partial class AdvancedTab : UserControl
    {
        public AdvancedTab()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            IEnumerable<string> nouns = stkNouns.Children.OfType<IntegerUpDownWLabel>().Select(x => Enumerable.Repeat(x.Title, x.Number)).SelectMany(x => x);

            IEnumerable<string> prepositions = stkPrepositions.Children.OfType<IntegerUpDownWLabel>().Select(x => Enumerable.Repeat(x.Title, x.Number)).SelectMany(x => x);


            StringBuilder sb = new StringBuilder();
            var tempNouns = new List<string>(nouns);
            while (tempNouns.Count > 0)
            {
                string noun = tempNouns.First();
                tempNouns.Remove(noun);
                var tempPrepositions = new List<string>(prepositions);
                while (tempPrepositions.Count > 0)
                {
                    var tempNouns2 = new List<string>(tempNouns);
                    while (tempNouns2.Count > 0)
                    {

                    }

                }
            }

            foreach (var pair in nouns)
            {
                foreach (var prep in prepositions)
                {
                    foreach (var str in nouns.Where(x => x != pair))
                    {
                        sb.AppendLine($"{pair} {prep} {str}");
                    }              
                }

                var tb = new TextBlock();
                tb.Text = sb.ToString();
                tb.Margin = new Thickness(10);
                tb.Background = Brushes.LightGray;
                wrpSets.Children.Add(tb);
                sb.Clear();
            }
        }
    }
}
