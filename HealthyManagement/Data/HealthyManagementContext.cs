using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HealthyManagement.Models;

namespace HealthyManagement.Data
{
    public class HealthyManagementContext : DbContext
    {
        public HealthyManagementContext (DbContextOptions<HealthyManagementContext> options)
            : base(options)
        {
        }

        public DbSet<HealthyManagement.Models.Cliente> Cliente { get; set; }
    }
}
