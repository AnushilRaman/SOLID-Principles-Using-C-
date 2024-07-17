using LSPDemoConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public ContractEmployee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 12000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.Id, this.Name);
        }
    }
}
