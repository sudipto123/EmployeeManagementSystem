using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeesList;

        public MockEmployeeRepository()
        {
            _employeesList = new List<Employee>()
            {
                new Employee() {Id = 1, Department = Dept.HR, Name = "Sudipto", Email = "sudipto@gmail.com"},
                new Employee() {Id = 2, Department = Dept.IT, Name = "Pradipto", Email = "pradiptoo@gmail.com"},
                new Employee() {Id = 3, Department = Dept.None, Name = "Deepak", Email = "deepak@gmail.com"},
                new Employee() {Id = 4, Department = Dept.Payroll, Name = "Reena", Email = "reena@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeesList.Max(e => e.Id) + 1;
            _employeesList.Add(employee);
            return employee;
        }

        public Employee Delete(int Id)
        {
            Employee employee = _employeesList.FirstOrDefault(e => e.Id == Id);
            if(employee != null)
            {
                _employeesList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeesList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeesList.FirstOrDefault(emp => emp.Id == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
           Employee employee = _employeesList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if(employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Department = employeeChanges.Department;
                employee.Email = employeeChanges.Email;
            }
            return employee; 
        }
    }
}
