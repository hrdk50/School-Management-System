using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SchoolManagementWebApplication.Models
{
    public class StudentDeatilContext : DbContext
    {
        public StudentDeatilContext(DbContextOptions<StudentDeatilContext> options) : base(options)
        {

        }
        public DbSet<Installments> Installments { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<StudentType> StudentType { get; set; }
        public DbSet<Standards> Standard { get; set; }
        public DbSet<Guardians> Guardian { get; set; }
        public DbSet<Fees> Fees { get; set; }
        public DbSet<AdmissionForm> AdmissionForm { get; set; }

    }
}
