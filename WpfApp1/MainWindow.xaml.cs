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
        private int SelectedItem2;
        private ViewModel vm;
        private char selectedChar;
        private char selected2Char;
        public MainWindow()
        {
            InitializeComponent();
            SelectedItem = -1;
            vm = new ViewModel();
            ifComboBox.ItemsSource = vm.CmbContent;
            switchListBox.ItemsSource = vm.CmbContent;
        }

        private void ifComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;            
            selectedChar = (char)comboBox.SelectedValue;
            SelectedItem = comboBox.SelectedIndex;           
        }

        private void ifButtonResult_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            double result = 0;
            string operand1str = ifTextBoxNumber1.Text;
            string operand2str = ifTextBoxNumber2.Text;
            if (SelectedItem == -1) MessageBox.Show("Please, Select Operation");
            else
            {
                bool res = vm.Calculation(operand1str, operand2str, selectedChar, out result);
                if (res)
                    ifTextBoxResult.Text = result.ToString();
                else ifTextBoxResult.Text = "Error";
            }  
        }

        private void switchListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            ListBox listBox = (ListBox)sender;
            selected2Char = (char)listBox.SelectedValue;
            SelectedItem2 = listBox.SelectedIndex;  
        }

        private void switchButtonResult_Click(object sender, RoutedEventArgs e)
        {            
            double result = 0;
            string operand1str = switchTextBoxNumber1.Text;
            string operand2str = switchTextBoxNumber2.Text;
            if (SelectedItem2 == -1) MessageBox.Show("Please, Select Operation");
            else
            {
                bool res = vm.Calculation2(operand1str, operand2str, selected2Char, out result);
                if (res)
                    switchTextBoxResult.Text = result.ToString();
                else switchTextBoxResult.Text = "Error";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string strIn = InputWord.Text;
            string strOut = "";
            for (int i = strIn.Length; i > 0; i--)
                strOut += strIn[i-1];
            OutputWord.Text = strOut;
        }
    }
}
