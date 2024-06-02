﻿using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions options):base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Transaction> Transaction { get; set; }
}
