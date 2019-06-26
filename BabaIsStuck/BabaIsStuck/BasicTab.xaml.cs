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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class BasicTab : UserControl
    {
        public BasicTab()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            var nouns = stkNouns.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());
            var verbs = stkVerbs.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());
            var descriptors = stkDescriptors.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());

            var verbNounCombos = from n in nouns
                                 from v in verbs
                                 from d in descriptors
                                 select $"{n} {v} {d}";

            var nounNounCombos = from n in nouns
                                 from n2 in nouns
                                 from v in verbs
                                 where v == "Is"
                                 select $"{n} {v} {n2}"
                                 ;

            StringBuilder sb = new StringBuilder();
            foreach (string combo in verbNounCombos)
            {
                sb.AppendLine(combo);
            }

            foreach (string combo in nounNounCombos)
            {
                sb.AppendLine(combo);
            }

            tbxSolutions.Text = sb.ToString();
        }
    }
}
