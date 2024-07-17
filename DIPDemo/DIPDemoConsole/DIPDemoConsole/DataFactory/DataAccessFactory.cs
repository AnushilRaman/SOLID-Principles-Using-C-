using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPDemoConsole.DataLogic;
using DIPDemoConsole.Interface;

namespace DIPDemoConsole.DataFactory
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
    }
}
