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
    /// Interaction logic for ExperimentalTab.xaml
    /// </summary>
    public partial class ExperimentalTab : UserControl
    {
        public ExperimentalTab()
        {
            InitializeComponent();
            PrintSampleGrid();
        }

        private void PrintSampleGrid()
        {
            string[,] stringArr = new string[2, 10] { { " ", " ", "B", "I", "Y", " ", " ", " ", " ", " "}, { " ", " ", " ", "R", "I", "P", " ", " ", " ", " "} };

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append($" {stringArr[i, j]} ");
                }
                sb.AppendLine();
            }
        }

        private void DraggableTextBox_Drop(object sender, DragEventArgs e)
        {
            if (!e.Handled)
            {
                DraggableTextBox draggableTextBox = (DraggableTextBox)sender;

                DraggableTextBox element = (DraggableTextBox)e.Data.GetData("Object");

                if (draggableTextBox != null && element != null)
                {
                    string temp = draggableTextBox.Word;
                    draggableTextBox.Word = element.Word;
                    element.Word = temp;
                }
            }
        }
    }
}
