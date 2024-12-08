using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysPrograms
{
     public class Product
    {
        public int pid { get; set; }
        public string pname { get; set; }

        public int price {  get; set; }

        public override string ToString()
        {
            return $"Id ={pid} , Name= {pname} , Salary={price}";
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            Product[] pr = new Product[5];
            {
                new Product{ pid = 1, pname = "Chocolate", price = 300 };
                new Product{ pid = 2, pname = "Mouse", price = 1500 };
                new Product{ pid = 3, pname = "Keyboard", price = 1800 };
                new Product{ pid = 4, pname = "Monitor", price = 15000 };
                new Product{ pid = 5, pname = "Pendrive", price = 800 };
            };


            //for (int i = 0; i < pr.Length; i++)
            //{
            //    Console.WriteLine(pr[i]);
            //}

            foreach (Pr emp in pr)
            {
                Console.WriteLine(emp);

            }
        }
    }
}
