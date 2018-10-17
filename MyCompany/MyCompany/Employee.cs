using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany
{
    class Employee
    {

            public string name;
            public string department;

        public Employee (string name, string department)
        {
            this.name = name;
            this.department = department;
        }

        public override string ToString()
        {
            return name + " (" + department + ")";
        }

        public static List<Employee> pers = new List<Employee>();

        //public static string Write()
        //{
        //    string text;
        //    text = "";
        //    foreach (Person p in pers)
        //        text =  text + "Сотрудник " + p.name + " департамента '" + p.department + "'/n";
        //    return text;
        //}

        //public static void AddPerson(string n, string d)
        //{
        //    Person p;
        //    p.name = n;
        //    p.department = d;
        //    pers.Add(p);
        //}

        //public static void ChangeDepartment(Person p, string d)
        //{
        //    Person p_new;
        //    p_new.name = p.name;
        //    p_new.department = d;
        //    pers.Remove(p);
        //    pers.Add(p_new);
        //}



    }
}
