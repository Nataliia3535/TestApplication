using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Models;

namespace TestApplication.DATA
{
    public class IncidentContext:DbContext
    {
        public IncidentContext(DbContextOptions<IncidentContext> options) : base(options)
        {

        }
        public DbSet<Incident> Incidents { get; set; }
    }
}
