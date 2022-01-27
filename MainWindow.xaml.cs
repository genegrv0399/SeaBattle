using SeaBattle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace SeaBattle
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeRectangle();
        }   
        
        public void InitializeRectangle()
        {
            double x = 10;
            double y = 10;
            var vm = new ViewModel
            {
                Field = new ObservableCollection<Field>()
            };
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    vm.Field.Add(new Field(i, j, new RectangleGeometry(new Rect(10 + x, 10 + y, 20, 20)), Brushes.Azure, Brushes.Black));
                    x += 25;
                }
                x = 10;
                y += 25;
            }
            DataContext = vm;
        }

    }

    public class ViewModel
    {
        public ObservableCollection<Field> Field { get; set; }
    }
}
