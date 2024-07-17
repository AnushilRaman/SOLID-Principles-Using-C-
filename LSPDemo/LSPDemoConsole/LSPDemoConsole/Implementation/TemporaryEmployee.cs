using LSPDemoConsole.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string Name) : base(id, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }
}
