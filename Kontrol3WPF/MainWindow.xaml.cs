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
using Microsoft.VisualBasic;
using контрольная_2;

namespace Kontrol3WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBox1.Items.Add("Вычисление площади методом правых тре-ов");
        }
        Utilites utilites = new Utilites();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            
            int a = Convert.ToInt32(Interaction.InputBox("Введите A"));
            int b = Convert.ToInt32(Interaction.InputBox("Введите B")); 
            int n = Convert.ToInt32(Interaction.InputBox("Введите N")); 
            ListBox1.Items.Add("Площадь фигуры: "+utilites.RightTriangl(a,b,n));
        }
    }
}
