using App0411.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace App0411.Models
{
    public static class EmployeeService
    {
        public static void AddEmployee(List<Employee> employees, Employee employee)
        {
            employees.Add(employee);

        }

        public static Employee GetEmployeeById(int id)
        {
            Employee? emp = EmployeeDatabase.Employees.Find(e => e.Id == id); 
            if (emp != null)
            {
                return emp;
            }
            throw new EmployeeNotFound("Employee with this ID is not found");
        }

        public static void RemoveEmployee(int id)
        {
            EmployeeDatabase.Employees.Remove(GetEmployeeById(id));
           

        }
        public static void GetAllEmployee()
        {
            EmployeeDatabase.Employees.ForEach(e => Console.WriteLine(e));
        }
    }
}
