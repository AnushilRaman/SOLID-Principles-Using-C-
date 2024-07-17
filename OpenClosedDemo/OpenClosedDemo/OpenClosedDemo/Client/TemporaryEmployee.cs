using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo.Client
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() { }
        public TemporaryEmployee(int id, string Name) : base(id, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}
