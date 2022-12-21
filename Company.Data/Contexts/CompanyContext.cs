using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entities;
using Company.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Contexts
{
    public class CompanyContext : DbContext
    {
        public DbSet<CompanyClass> Companies => Set<CompanyClass>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<EmployeePosition> EmployeePositions => Set<EmployeePosition>();
        public DbSet<Position> Positions => Set<Position>();

        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EmployeePosition>().HasKey(ep => new { ep.EmployeeId, ep.PositionId });

            //SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var Companies = new List<CompanyClass>
            {
                new CompanyClass
                {
                    Id = 1,
                    CompanyName = "Wibergs AB",
                    Location = "Sweden",
                    OrgNumber = "5542-1243"
                },
                new CompanyClass
                {
                    Id = 2,
                    CompanyName = "Wibergs AB",
                    Location = "Denmark",
                    OrgNumber = "4254-2213",
                }

                

        };

            builder.Entity<CompanyClass>().HasData(Companies);

            var Departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    DepartmentName = "Head of Sales",
                    CompanyClassId = 1,
                },
                  new Department
                {
                    Id = 2,
                    DepartmentName = "Production",
                    CompanyClassId = 2,
                  },
                    new Department
                {
                    Id = 3,
                    DepartmentName = "Mechanic",
                    CompanyClassId = 2,
                    },
                      new Department
                {
                    Id = 4,
                    DepartmentName = "Accountant",
                    CompanyClassId = 1,
                      },

                     new Department
                    {
                    Id = 5,
                    DepartmentName = "Head of Production",
                    CompanyClassId = 2,
                     },
                       new Department
                {
                    Id = 6,
                    DepartmentName = "Human Resources",
                    CompanyClassId = 1,
                       }
            };
            builder.Entity<Department>().HasData(Departments);

        }
    }
}

        
            
    

    
