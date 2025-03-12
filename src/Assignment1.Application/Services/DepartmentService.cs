using Assignment1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;


namespace Assignment1.Services
{
    public class DepartmentService : ApplicationService
    {
        private readonly IRepository<Department, Guid> _departmentservice;

        public DepartmentService(IRepository<Department, Guid> departmentservice)
        {
            _departmentservice = departmentservice;
        }

        public async Task<Department> CreateAsync(string name)
        {
           
            var depart = new Department
            {
               
                DepartmentName = name
            };

            // Save the employee to the repository
            await _departmentservice.InsertAsync(depart);

            // Return the created employee as a DTO
            return depart;
        }
    }
}
