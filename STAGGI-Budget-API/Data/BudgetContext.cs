﻿using Microsoft.EntityFrameworkCore;
using STAGGI_Budget_API.Models;

namespace STAGGI_Budget_API.Data
{
    public class BudgetContext  : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BUser> BUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SavingGoal> Savings { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionCategory> TransactionsPerCategory { get; set; }
    }
}
