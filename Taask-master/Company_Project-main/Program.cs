using Company_Project;

/*Employee e = new Employee("vugar","sariyev","vugar123");

Company company1 = new Company("Socar kbr");*/




/*while (true) // quit
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Add employee");
    char option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':

            break;
        case '2':
            company1.AddUser(e);

            break;
        case '3':

            break;
    }
}*/
Company company1 = new Company("Socar kbr");
Employee e = new Employee("vugar", "sariyev", "vugar123");
char option;
do 
{
    Console.WriteLine("1. Create a company");
    Console.WriteLine("2. Create an employee");
    Console.WriteLine("3. Add employee");
    Console.WriteLine("4. Get one employee");
    Console.WriteLine("5. To update employee data");
    Console.WriteLine("6. To see all users");
    Console.WriteLine("7. To remove user\n");
    option = Convert.ToChar(Console.ReadLine());

    switch (option)
    {
        case '1':
            company1 = new Company("Socar kbr");
            break;
        case '2':
            e = new Employee("vugar", "sariyev", "vugar123");
            break;
        case '3':
            company1.AddUser(e);
            break;
        case '4':
            company1.GetUser(e.Username);
            break;
        case '5':
            company1.UpdateUser(e.Username);
            break;
        case '6':
            company1.GetAllUser();
            break;
        case '7':
            company1.RemoveUser(e.Username);
            break;
        default:
            Console.WriteLine("Choose from options");
            break;
    }
} while (option != 'q');
