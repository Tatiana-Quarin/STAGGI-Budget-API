﻿using Microsoft.EntityFrameworkCore;
using STAGGI_Budget_API.Data;
using STAGGI_Budget_API.Models;
using STAGGI_Budget_API.Repositories.Interfaces;

namespace STAGGI_Budget_API.Repositories
{
    public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
    {
        public TransactionRepository(BudgetContext repositoryContext) : base(repositoryContext) { }

        public IEnumerable<Transaction> GetAll()
        {
            return FindAll()
             .ToList();
        }

        public Transaction? FindById(long id)
        {
            return FindByCondition(tr => tr.Id == id)
                .FirstOrDefault();
        }

        public void Save(Transaction transaction)
        {
            Create(transaction);
            SaveChanges();
        }
    }
}