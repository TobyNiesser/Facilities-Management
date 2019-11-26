using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FACILITIES.Models;

namespace FACILITIES.Models
{
    public class FACILITIESContext : DbContext
    {
        public FACILITIESContext(DbContextOptions<FACILITIESContext> options)
            : base(options)
        {
        }



        public DbSet<FACILITIES.Models.Company> Company { get; set; }

        public DbSet<FACILITIES.Models.Status> Status { get; set; }

        public DbSet<FACILITIES.Models.File> File { get; set; }

        public DbSet<FACILITIES.Models.Frequency> Frequency { get; set; }

        public DbSet<FACILITIES.Models.Permission> Permission { get; set; }

        public DbSet<FACILITIES.Models.Responsibility> Responsibility { get; set; }

        public DbSet<FACILITIES.Models.Office> Office { get; set; }

        public DbSet<FACILITIES.Models.Manager> Manager { get; set; }

        public DbSet<FACILITIES.Models.Setting> Setting { get; set; }

        public DbSet<FACILITIES.Models.Item> Item { get; set; }

        public DbSet<FACILITIES.Models.ItemConfig> ItemConfig { get; set; }


    }
}
