using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPISAP.Repositories
{
    public class EmployeeRepository
    {

        public bool IsValid()
        {
            return true;
        }

        public bool IsNotValid()
        {
            return false;
        }

        public bool IsFound()
        {
            return true;
        }

        public List<EmployeeRepository> GetEmployees()
        {
            return null;
        }

        public EmployeeRepository FindByCedula()
        {
            return null;
        }

        public EmployeeRepository FindByName()
        {
            return null;
        }

        public bool Save()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }

    }
}