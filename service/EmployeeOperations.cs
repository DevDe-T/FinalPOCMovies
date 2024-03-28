using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;

namespace finalPOCService.service
{
    public class EmployeeOperations : IEmployeeFunctionality
    {
        DatabaseContext db;

        public EmployeeOperations(DatabaseContext _db)
        {
            db = _db;
        }

        int IEmployeeFunctionality.addEmployee(Employee emp)
        {
            db.employee.Add(emp);
            return db.SaveChanges();
        }

        DbSet<Employee> IEmployeeFunctionality.getEmployeeDetails()
        {
            var e = db.employee;
            return e;
        }

        Employee IEmployeeFunctionality.searchEmployee(int i)
        {
            var res = db.employee.Where(x => x.empid == i).First();
            if(res != null)
            {
                return res;
            }
            else
            {
                return null;
            }
        }
    }
}