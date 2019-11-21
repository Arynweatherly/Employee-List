using System;
using System.Collections.Generic;

namespace EmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //create an instance of a company. name it whatever you like

            Company PupperTime = new Company("PupperTime", 2019);

            //create three employees
            Employee Phil = new Employee()
            {
                FirstName = "Phil",
                LastName = "Griswold",
                Title = "Boss Man",
            };
            Employee Dylan = new Employee()
            {
                FirstName = "Dylan",
                LastName = "Griffin",
                Title = "Boss Lady",
            };

            Employee Keaton = new Employee()
            {
                FirstName = "keaton",
                LastName = "Williamson",
                Title = "Boss Man #2",
            };

            //assign the employees to the company 

            PupperTime.NewEmployee.Add(Phil);
            PupperTime.NewEmployee.Add(Dylan);
            PupperTime.NewEmployee.Add(Keaton);
            PupperTime.Description();
        }
    }
}