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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int SelectedItem;
        public MainWindow()
        {
            InitializeComponent();
            SelectedItem = -1;
            ViewModel vm = new ViewModel();
            ifComboBox.ItemsSource = vm.CmbContent;
        }

        private void ifComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string str = comboBox.SelectedValue.ToString();
            SelectedItem = comboBox.SelectedIndex;
            MessageBox.Show(SelectedItem.ToString());
        }

        private void ifButtonResult_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            string operand1str = ifTextBoxNumber1.Text;
            if (SelectedItem == -1) MessageBox.Show("Select Operation");
            else
            {

            }


        }
    }
}
