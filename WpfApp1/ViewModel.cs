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
        public ObservableCollection<string> CmbContent { get; private set; }

        public ViewModel()
        {
            CmbContent = new ObservableCollection<string>
            {
                "+",
                "-",
                "*",
                "/"
            };
        }

    }
}
