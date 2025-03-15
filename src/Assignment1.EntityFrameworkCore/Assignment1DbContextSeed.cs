using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Assignment1.EntityFrameworkCore;
using Assignment1.Entities;
using Volo.Abp.Domain.Repositories;
using System.Xml.Linq;

public class DepartmentSeed : ITransientDependency
{
    private readonly IRepository<roles, Guid> _role;

    public DepartmentSeed(IRepository<roles, Guid> role_seed)
    {
        _role = role_seed;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        // Add entries to a specific table here
        if (_role == null)
        {
            return; // Skip seeding if data already exists
        }
        var ro = new roles
        {

            role_name = "Hr"
        };

        await _role.InsertAsync(ro);

       
    }
}
