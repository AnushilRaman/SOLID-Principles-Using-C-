using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Employee()
        {
            Console.WriteLine("Abstract Default");
        }

        static Employee()
        {
            Console.WriteLine("Abstract Static Constructor");
        }
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.Id, this.Name);
        }
    }
}
