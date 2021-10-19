
using apicrud.Models;
using System;
using System.Collections.Generic;
namespace apicrud.EmployeesData
{
    public interface IEmployeeData
    {
        List<Employee> GetEmployees();

        Employee GetEmployee(Guid id);

        Employee AddEmployee(Employee employee);

        void DeleteEmployee(Employee emlpoyee);

        Employee EditEmployee(Employee employee);
    }
}
