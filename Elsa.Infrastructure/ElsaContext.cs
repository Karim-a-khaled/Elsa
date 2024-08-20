using Elsa.API.Domain;
using Microsoft.EntityFrameworkCore;

namespace Elsa.Infrastructure;

public class ElsaContext : DbContext
{
    public ElsaContext(DbContextOptions<ElsaContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }

    public DbSet<Country> Countries { get; set; }

    public DbSet<LeaveRequest> LeaveRequest { get; set; }

    public DbSet<Tenant> Tenants { get; set; }

    public DbSet<Unit> Units { get; set; }
}
