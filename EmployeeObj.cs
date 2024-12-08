using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysPrograms
{
    public class EmployeeObj
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id ={Id} , Name= {Name} , Salary={Salary}";
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = new int[] { 1, 2, 3, 4, 5 };
        //    EmployeeObj[] employees = new EmployeeObj[5]
        //    {
        //        new EmployeeObj{Id=1,Name="Amol",Salary=45000},//0
        //        new EmployeeObj{Id=2,Name="Akshay",Salary=15000},
        //        new EmployeeObj{Id=3,Name="Suraj",Salary=55000},
        //        new EmployeeObj{Id=4,Name="Rohan",Salary=25700},
        //        new EmployeeObj{Id=5,Name="Vishal",Salary=35000},
        //    };
        //    // Console.WriteLine(employees[3]);

        //    //for (int i = 0; i < employees.Length; i++)
        //    //{
        //    //    Console.WriteLine(employees[i]);
        //    //}
        //    Console.WriteLine("----------using foreach-------------");
        //    foreach (EmployeeObj emp in employees)
        //    {
        //        Console.WriteLine(emp);

        //    }

        //}
    }

}
