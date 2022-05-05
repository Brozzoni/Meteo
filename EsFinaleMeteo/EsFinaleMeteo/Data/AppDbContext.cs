using EsFinaleMeteo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsFinaleMeteo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<DMeteo> DatiMeteo { get; set; }
        public DbSet<DCitta> DatiCittà { get; set; }
        public DbSet<MeteoCittà> MetCitta { get; set; }
    }
}
