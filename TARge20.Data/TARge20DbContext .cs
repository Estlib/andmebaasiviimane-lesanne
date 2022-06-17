using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ClearanceLV> ClearanceLVs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Equiptment> Equiptments { get; set; }
        public DbSet<Medicalrecord> Medicalrecords { get; set; }
        public DbSet<Permissiontype> Permissiontypes { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Sickleave> Sickleaves { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
    }
}