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
using System.Collections.ObjectModel;


namespace MyCompany
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Employee> items_employee = new ObservableCollection<Employee>();
        ObservableCollection<Department> items_department = new ObservableCollection<Department>();
        public MainWindow()
        {
            InitializeComponent();

            items_employee.Add(new Employee("xx","xxx"));
            items_department.Add(new Department("xxx"));

            ListEmployee.ItemsSource = items_employee;
            ListDepartment.ItemsSource = items_department;
            cbDepartment.ItemsSource = items_department;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string new_name;
            string new_dep;

            new_name = txName.Text;
            new_dep = cbDepartment.Text;

            items_employee.Add(new Employee(new_name, new_dep));
            txName.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        { 
            items_employee.Remove((Employee)ListEmployee.SelectedItem);
        }

        private void btnAddDep_Click(object sender, RoutedEventArgs e)
        {
            string new_dep;

            new_dep = txNameDep.Text;

            items_department.Add(new Department(new_dep));
            txNameDep.Clear();
        }

        private void btnDelDep_Click(object sender, RoutedEventArgs e)
        {
            items_department.Remove((Department)ListDepartment.SelectedItem);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            string new_name;
            string new_dep;

            Employee pers = (Employee)ListEmployee.SelectedItem;
            new_name = pers.name;
            new_dep = cbDepartment.Text;

            items_employee.Remove((Employee)ListEmployee.SelectedItem);
            items_employee.Add(new Employee(new_name, new_dep));
            txName.Clear();
        }
    }

}

