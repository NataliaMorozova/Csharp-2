using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyCompany
{
    public class Employee: INotifyPropertyChanged
    {
  
        public event PropertyChangedEventHandler PropertyChanged;

        string department, name;
        public string DepartmentName
        {
            get => this.department;
            set
            {
                if (this.department != value)
                {
                    this.department = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.DepartmentName)));
                }
            }
        }

        public string EmployeeName
        {
            get => this.name;
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.EmployeeName)));
                }
            }
        }

        public override string ToString()
        {
            return name;
        }


    }
}
