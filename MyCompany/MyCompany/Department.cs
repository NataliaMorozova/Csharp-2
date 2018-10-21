using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyCompany
{
    public class Department: INotifyPropertyChanged
    {

        string department;
        public string DepartmentName {
            get => this.department;
            set {
                if (this.department != value)
                {
                    this.department = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.DepartmentName)));
                }
                }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    
        public override string ToString()
        {
            return department;
        }
    }
}
