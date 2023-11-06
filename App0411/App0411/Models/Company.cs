using App0411.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App0411.Models
{
    public class Company
    {
        public string name { get; set; }
        public List<Employee> employees { get; set; }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);

        }

        public Employee GetEmployeeById(uint id) 
        {
            Employee? emp = employees.Find(e => e.Id == id); // ЧЕКНУТЬ ЧTО ВОЗРВАЩАЮТ ЭТИ МЕТОДЫ !!!
            //Employee? emp = employees.SingleOrDefault(item => item.Id == id);
            if (emp != null)
            {
                return emp;
            }
            throw new EmployeeNotFound("Employee with this ID is not found");


            employees.FirstOrDefault();
            //foreach (Employee emp in employees)
            //{
            //    if ( emp.Id == id) return emp;
                
            //    else throw new EmployeeNotFound("Employee with this ID is not found");
            //}
            //return null; 
        }
        //public Employee UpdateEmployee(Employee emp) 
        //{
            
        //}
        public void RemoveEmployee(uint id) 
        {
            Employee employee = GetEmployeeById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
            
        }

        public void GetAllEmployee()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp); // need to override 
            }
        }


    }
}
