using System.Collections.Generic;
using System.Linq;

namespace solid_demo.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(1, "Mary", "HR", "mary@ewaoi.com"),
                new Employee(2, "Mary 2", "HR", "mary@ewaoi.com"),
                new Employee(3, "Mary 3", "HR", "mary@ewaoi.com")
            };
        }

        public Employee GetEmployeeById(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}