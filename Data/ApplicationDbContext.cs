using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftwareII.Models;

namespace SoftwareII.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SoftwareII.Models.Empleado> Empleado { get; set; }
        public DbSet<SoftwareII.Models.Proyecto> Proyecto { get; set; }
        public DbSet<SoftwareII.Models.Stakeholder> Stakeholder { get; set; }
    }
}