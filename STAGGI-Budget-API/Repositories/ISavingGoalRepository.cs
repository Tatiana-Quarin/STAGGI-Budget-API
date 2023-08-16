using STAGGI_Budget_API.Models;

namespace STAGGI_Budget_API.Repositories
{
    public interface ISavingGoalRepository
    {
            void AddSavingGoal(SavingGoal goal);
            void UpdateSavingGoal(SavingGoal goal);
            void DeleteSavingGoal(int id);
            SavingGoal GetSavingGoalById(int id);
            List<SavingGoal> GetAllSavingGoals();
        
    }
}
