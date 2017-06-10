using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKP
{
    //总公司员工
    public class Employee
    {
        public string id { get; set; }
    }
    //分公司员工
    public class SubEmployee
    {
        public string id { get; set; }
    }
    
    public class SubCompanyManager
    {
        public List<SubEmployee> getAllEmployee()
        {
            List<SubEmployee> list = new List<SubEmployee>();
            for (int i = 0; i < 100; i++)
            {
                SubEmployee emp = new SubEmployee();
                //为分公司人员按顺序分配一个ID
                emp.id = "分公司" + i;
                list.Add(emp);
            }
            return list;
        }
    }

    public class CompanyManager
    {
        public List<Employee> getAllEmployee()
        {
            List<Employee> list = new List<Employee>();
            for (int i = 0; i < 30; i++)
            {
                Employee emp = new Employee();
                //为总公司人员按顺序分配一个ID
                emp.id = "总公司" + i;
                list.Add(emp);
            }
            return list;
        }

        public void printAllEmployee(SubCompanyManager sub)
        {
            List<SubEmployee> list1 = sub.getAllEmployee();
            foreach (var item in list1)
            {
                Console.WriteLine(item.id);
            }

            List<Employee> list2 = this.getAllEmployee();
            foreach (var item in list2)
            {
                Console.WriteLine(item.id);
            }
        }
    }

    
}

