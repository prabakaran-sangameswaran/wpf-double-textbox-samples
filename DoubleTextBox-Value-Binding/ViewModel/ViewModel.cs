using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleTextBox_Value_Binding.ViewModel
{
    class ViewModel : NotificationObject
    {
        private double myValue;
        public double MyValue
        {
            get
            {
                return myValue;
            }
            set
            {
                myValue = value;
                RaisePropertyChanged("MyValue");
            }
        }
    }
}
