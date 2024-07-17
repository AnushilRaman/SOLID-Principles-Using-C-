using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPDemoConsole.DataFactory;
using DIPDemoConsole.Interface;

namespace DIPDemoConsole
{
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        public EmployeeBusinessLogic()
        {
            _IEmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
