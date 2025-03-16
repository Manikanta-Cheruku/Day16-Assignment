using EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<UserLogin> Users { get; set; }  // Ensure User table exists
        public DbSet<Employee> Employees { get; set; }  // Employee table
    }
}
