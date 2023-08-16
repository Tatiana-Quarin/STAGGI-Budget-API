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
    public class SavingGoalRepository : ISavingGoalRepository
    {
        private readonly DbContext _dbContext;

        public SavingGoalRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddSavingGoal(SavingGoal goal)
        {
            // Agrega la meta de ahorro a la base de datos
            _dbContext.SavingGoals.Add(goal);
            _dbContext.SaveChanges();
        }

        public void UpdateSavingGoal(SavingGoal goal)
        {
            // Actualiza la meta de ahorro en la base de datos
            _dbContext.SavingGoals.Update(goal);
            _dbContext.SaveChanges();
        }

        public void DeleteSavingGoal(int id)
        {
            // Elimina la meta de ahorro de la base de datos
            var goalToDelete = _dbContext.SavingGoals.Find(id);
            if (goalToDelete != null)
            {
                _dbContext.SavingGoals.Remove(goalToDelete);
                _dbContext.SaveChanges();
            }
        }

        public SavingGoal GetSavingGoalById(int id)
        {
            // Obtén la meta de ahorro por su ID
            return _dbContext.SavingGoals.FirstOrDefault(goal => goal.Id == id);
        }

        public List<SavingGoal> GetAllSavingGoals()
        {
            // Obtén todas las metas de ahorro de la base de datos
            return _dbContext.SavingGoals.ToList();
        }
    }
}
