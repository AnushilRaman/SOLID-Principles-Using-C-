using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo.Client
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }
        public PermanentEmployee(int id, string Name) : base(id, Name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
