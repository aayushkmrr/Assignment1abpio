using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Assignment1.Entities;
using Volo.Abp;
using System.Collections;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization; // For ToListAsync and other EF Core extensions



namespace Assignment1.Services
{
    [Authorize]
    public class EmployeeService : ApplicationService
    {
        private readonly IRepository<Employee, Guid> _employeeservice;
   

        public EmployeeService(IRepository<Employee, Guid> employeeservice)
        {
            _employeeservice = employeeservice;
        }

        [Authorize("HR_employee_Create")]
        public async Task<Employee> CreateAsync(string name,Guid DId)
        {

            var emp = new Employee
            {

                EmployeeName = name,
                DepartmentId = DId
            };

            // Save the employee to the repository
            await _employeeservice.InsertAsync(emp);

            // Return the created employee as a DTO
            return emp;
        }

        public async Task<Employee> UpdateAsync(string name, Guid DId)
        {
            var emp = await _employeeservice.GetAsync(DId);

            if (emp == null)
            {
                throw new UserFriendlyException("Employee not found");
            }

             emp = new Employee
            {

                EmployeeName = name,
                DepartmentId = DId
            };

            // Save the employee to the repository
            await _employeeservice.UpdateAsync(emp);

            // Return the created employee as a DTO
            return emp;
        }

        public async Task<Employee> DeleteAsync(string name, Guid DId)
        {
            var emp = await _employeeservice.GetAsync(DId);

            if (emp == null)
            {
                throw new UserFriendlyException("Employee not found");
            }

           

            // Save the employee to the repository
            await _employeeservice.DeleteAsync(emp);

            // Return the created employee as a DTO
            return emp;
        }

        public async Task<List<Employee>> GetAllAsync(Guid? DId = null)
        {
            var query = await _employeeservice.GetQueryableAsync();

            if (DId.HasValue)
            {
                query = query.Where(e => e.DepartmentId == DId.Value); // Apply filtering
            }

            // Execute the query and return the results as a list
            return await query.ToListAsync();
        }

        public async Task<List<Employee>> GetbynameAsync(string name )
        {
            var query = await _employeeservice.GetQueryableAsync();

            var emp = await query
                .Where(e => e.EmployeeName.Contains(name)) // Filter by name (case-insensitive search)
                .ToListAsync();

            // Check if no employees were found
            if (emp == null )
            {
                throw new UserFriendlyException("Employee(s) not found");
            }

            return emp;
        }
    }
}
