using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bitsoncrmdemo.Models;
using Microsoft.EntityFrameworkCore;

namespace bitsoncrmdemo.Data
{
    public class BitsonCRMDbContext : DbContext
    {
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Lead> Leads { get; set; }
    public DbSet<AppTask> AppTasks { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Email> Emails { get; set; }
    public DbSet<Quote> Quotes { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Deal> Deals { get; set; }
    public BitsonCRMDbContext(DbContextOptions<BitsonCRMDbContext> options) : base(options){}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>()
            .HasMany(a => a.Leads)
            .WithOne(l => l.Account)
            .HasForeignKey(l => l.AccountId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.AppTasks)
            .WithOne(at => at.Lead)
            .HasForeignKey(at => at.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Activities)
            .WithOne(a => a.Lead)
            .HasForeignKey(a => a.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Emails)
            .WithOne(e => e.Lead)
            .HasForeignKey(e => e.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Quotes)
            .WithOne(q => q.Lead)
            .HasForeignKey(q => q.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Invoices)
            .WithOne(i => i.Lead)
            .HasForeignKey(i => i.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Contacts)
            .WithOne(c => c.Lead)
            .HasForeignKey(c => c.LeadId);

        modelBuilder.Entity<Lead>()
            .HasMany(l => l.Deals)
            .WithOne(d => d.Lead)
            .HasForeignKey(d => d.LeadId);

        modelBuilder.Entity<Deal>()
            .Property(d => d.Amount)
            .HasColumnType("decimal(18, 2)") // specify the SQL Server type
            .HasPrecision(18, 2); // precision and scale

        modelBuilder.Entity<Invoice>()
            .Property(i => i.TotalAmount)
            .HasColumnType("decimal(18, 2)")
            .HasPrecision(18, 2);

        modelBuilder.Entity<Quote>()
            .Property(q => q.TotalAmount)
            .HasColumnType("decimal(18, 2)")
            .HasPrecision(18, 2);
    }

    }
}