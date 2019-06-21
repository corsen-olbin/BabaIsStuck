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

namespace BabaIsStuck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            var nouns = stkNouns.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());
            var prepostions = stkPrepositions.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());
            var verbs = stkVerbs.Children.OfType<CheckBox>().Where(x => x.IsChecked.Value).Select(x => x.Content.ToString());

            var combos = from n in nouns
                         from p in prepostions
                         from v in verbs
                         select $"{n} {p} {v}";

            StringBuilder sb = new StringBuilder();
            foreach(string combo in combos)
            {
                sb.AppendLine(combo);
            }
            tbxSolutions.Text = sb.ToString();
        }
    }
}
