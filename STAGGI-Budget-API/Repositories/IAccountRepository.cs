using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;
using STAGGI_Budget_API.Data;
using STAGGI_Budget_API.Repositories.Interfaces;
using STAGGI_Budget_API.Models;


namespace STAGGI_Budget_API.Repositories
{
    public class IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts();
        Account FindById(long id);
        void Save(Account account);
        IEnumerable<Account> GetAccountsByClient(long clientId);
        Account FindByNumber(string number);
    }
}
