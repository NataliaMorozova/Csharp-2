﻿using System;
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
using System.ComponentModel;

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

            items_employee.Add(new Employee() { EmployeeName = "xx", DepartmentName = "xxx"});
            ListEmployee.ItemsSource = items_employee;

            items_department.Add(new Department() { DepartmentName = "xxx" });
            ListDepartment.ItemsSource = items_department;
            cbDepartment.ItemsSource = items_department;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string new_name;
            string new_dep;

            new_name = txName.Text;
            new_dep = cbDepartment.Text;

            items_employee.Add(new Employee() { EmployeeName = new_name, DepartmentName = new_dep });
            //txName.Clear();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        { 
            items_employee.Remove((Employee)ListEmployee.SelectedItem);
        }

        private void btnAddDep_Click(object sender, RoutedEventArgs e)
        {
            string new_dep;

            new_dep = txNameDep.Text;

            items_department.Add(new Department() { DepartmentName = new_dep });
            //txNameDep.Clear();
        }

        private void btnDelDep_Click(object sender, RoutedEventArgs e)
        {
            items_department.Remove((Department)ListDepartment.SelectedItem);
        }

        public void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            items_employee[ListEmployee.SelectedIndex].DepartmentName = cbDepartment.Text;
        }

        private void ListEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }

}

