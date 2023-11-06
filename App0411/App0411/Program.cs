

using App0411.Models;
using System.ComponentModel.Design;
using static App0411.Models.Employee;

namespace App0411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new();
            company.name = "Nvidia";
            Employee employee = new Employee();
            Menu:
            Console.WriteLine($"Choose from below options:\n");
            Console.WriteLine("1. Create employee");
            Console.WriteLine("2. Get employee details by id");
            Console.WriteLine("3. Get all employees");
            Console.WriteLine("4. Update employee details by id");
            Console.WriteLine("5. Delete employee records by id");
            Console.WriteLine("0. Exit\n");

            byte input;
            do
            {
                input = Convert.ToByte(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Name:");
                        employee.name = Console.ReadLine();
                        Console.WriteLine("Surname:");
                        employee.surname = Console.ReadLine();
                        Console.WriteLine("Age:");
                        employee.age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Position:");
                        employee.position = Console.ReadLine();
                        Console.WriteLine("Salary:");
                        employee.salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Choose gender\n");
                        Console.WriteLine($"m - Male\n" +
                            $"f - Female\n" +
                            $"o - other\n");
                        char inputGender;

                        do
                        {
                            inputGender = Convert.ToChar(Console.ReadLine());
                            switch (inputGender)
                            {
                                case (char)Gender.male:
                                    Console.WriteLine("You chose male");
                                    break;
                                   
                                case (char)Gender.female:
                                    Console.WriteLine("You chose female");
                                    break;
                                case (char)Gender.other:
                                    Console.WriteLine("You chose other");
                                    break;
                                default:
                                    Console.WriteLine("Please choose from options\n");
                                    break;
                            }
                        } while (inputGender != 'm' && inputGender != 'f' && inputGender != 'o');
                        Console.WriteLine("Employee created!\n");
                        goto Menu;

                        break;

                    case 2:

                        
                        Console.WriteLine("Type employee ID\n");
                        uint eId = Convert.ToUInt32(Console.ReadLine());

                        company.GetEmployeeById(eId);

                        break;
                    case 3:
                        break;
                    case 4:

                        break;
                    case 5:
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Please choose from options");
                        break;
                } 
            } while (input != 0);

            
            
        }
    }
}