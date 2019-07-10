using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DraggableTextBox.xaml
    /// </summary>
    public partial class DraggableTextBox : UserControl, INotifyPropertyChanged
    {
        public DraggableTextBox()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data = new DataObject();
                data.SetData(DataFormats.StringFormat, Word);
                data.SetData("Object", this);

                DragDrop.DoDragDrop(this, data, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }

        private string _word;
        public string Word
        {
            get
            {
                return _word;
            }
            set
            {
                if (_word != value)
                {
                    _word = value;
                    this.NotifyPropertyChanged("Word");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

    }
}
