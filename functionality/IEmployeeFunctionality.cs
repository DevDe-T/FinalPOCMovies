
using finalPOCService.models;
using Microsoft.EntityFrameworkCore;

namespace finalPOCService.functionality
{
    public interface IEmployeeFunctionality
    {
        public DbSet<Employee> getEmployeeDetails();

        public Employee searchEmployee(int i);

        public int addEmployee(Employee emp);
    }
}