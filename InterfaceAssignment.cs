/*In this exercise, you are going to write an IStudent interface and a PartTimeStudent class that implements it.
These may be used in a scenario where employees are allowed to register as part time students;
as such one can be an employee and a student at the same time.  
*/
 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwapp
{
    interface IStudent
    {
        void Register();

        void PostCourseWork(string work);


    }
    class Employee
    {

        string name { get; set; }
        int EmployeeId { get; set; }
        public Employee(string name, int EmployeeId)
        {
            this.name = name;
            this.EmployeeId = EmployeeId;
        }
        public void details(string name, int EmployeeId)
        {
            Console.WriteLine("the name and employeeid are "+name+" and "+EmployeeId);
        }
    }
    class PartTimeStudent: Employee,IStudent
    {
        public PartTimeStudent(string name, int EmployeeId): base(name,  EmployeeId)
        {
           
        }
        public void PostCourseWork(string work)
        {
            Console.WriteLine("you have completed your"+ work);
        }

        public void Register()
        {
            Console.Write("\nEnter LibCardNumber:");
            string LibCardNumber = Console.ReadLine();
            Console.Write("\nEnter Year:");
            int Year = int.Parse(Console.ReadLine());
            Console.WriteLine("You can register the course using card number "+ LibCardNumber+ " till " +Year);
        }
    }
  
    class Test
    {
        public static void Main()
        {
            Console.WriteLine("Your details are:\n");
            Employee e = new Employee("Employee1", 123);
             e.details("Employee1", 123);
            PartTimeStudent p = new PartTimeStudent("Employee1", 123);
            //Console.WriteLine("The Employee details are"+$"{ p.name},{p.Empl});
            p.Register();
            p.PostCourseWork("C# Course");
            
        }
    }
}
