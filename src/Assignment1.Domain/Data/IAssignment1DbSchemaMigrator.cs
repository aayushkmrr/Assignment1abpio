using System.Threading.Tasks;

namespace Assignment1.Data;

public interface IAssignment1DbSchemaMigrator
{
    Task MigrateAsync();
}
