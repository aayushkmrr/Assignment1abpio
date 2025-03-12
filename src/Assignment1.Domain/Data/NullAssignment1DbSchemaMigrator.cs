using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Assignment1.Data;

/* This is used if database provider does't define
 * IAssignment1DbSchemaMigrator implementation.
 */
public class NullAssignment1DbSchemaMigrator : IAssignment1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
