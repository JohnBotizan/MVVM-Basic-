using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MVVM_Simple.Helpers
{
   public  class PropertyChangedHelper : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string parameterName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(parameterName));
        }
   
   }
}
