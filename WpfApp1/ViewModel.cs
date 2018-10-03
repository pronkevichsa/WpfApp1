using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfApp1
{
    class ViewModel
    {
        public ObservableCollection<char> CmbContent { get; private set; }

        public ViewModel()
        {
            CmbContent = new ObservableCollection<char>
            {
                '+',
                '-',
                '*',
                '/'
            };
        }

        public bool Calculation(string operand1Input,string operand2Input,char operationInput, out double doubleResult)
        {
            double double1Input=0;
            double double2Input = 0;
            bool checkResults = false;
            doubleResult = 0;
            bool checkValue = Double.TryParse(operand1Input, out double1Input);
            if (checkValue)
            {
                checkValue = Double.TryParse(operand2Input, out double2Input);
                if (checkValue)
                {
                    if (operationInput == '+')
                    {
                        checkResults = true;
                        doubleResult = double1Input + double2Input;
                    }
                    if (operationInput == '-')
                    {
                        checkResults = true;
                        doubleResult = double1Input - double2Input;
                    }
                    if (operationInput == '*')
                    {
                        checkResults = true;
                        doubleResult = double1Input * double2Input;
                    }
                    if (operationInput == '/')
                    {
                        if (double2Input != 0)
                        {
                            checkResults = true;
                            doubleResult = double1Input / double2Input;
                        }
                        else
                        {
                            checkResults = false;
                            //throw new Exception("Something wrong");
                        }
                    }
                }
            }   
            return checkResults;
        }


        public bool Calculation2(string operand1Input, string operand2Input, char operationInput, out double doubleResult)
        {
            double double1Input = 0;
            double double2Input = 0;
            bool checkResults = false;
            doubleResult = 0;
            bool checkValue = Double.TryParse(operand1Input, out double1Input);
            if (checkValue)
            {
                checkValue = Double.TryParse(operand2Input, out double2Input);
                if (checkValue)
                {
                    switch (operationInput)
                    {

                        case '+':
                            checkResults = true;
                            doubleResult = double1Input + double2Input;
                            break;
                        case '-':
                            checkResults = true;
                            doubleResult = double1Input - double2Input;
                            break;
                        case '*':
                            checkResults = true;
                            doubleResult = double1Input * double2Input;
                            break;
                        case '/':
                            if (double2Input != 0)
                            {
                                checkResults = true;
                                doubleResult = double1Input / double2Input;
                            }
                            else
                            {
                                checkResults = false;
                                //throw new Exception("Something wrong");
                            }
                            break;
                    }            
                }
            }
            return checkResults;
        }

    }
}
