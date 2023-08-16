using STAGGI_Budget_API.Models;
using STAGGI_Budget_API.Repositories;

namespace STAGGI_Budget_API.Services
{
    public class SavingGoalService
    {
        private readonly ISavingGoalRepository _repository;

        public SavingGoalService(ISavingGoalRepository repository)
        {
            _repository = repository;
        }

        public void CreateSavingGoal(SavingGoal goal)
        {
            // Realiza validaciones si es necesario
            _repository.AddSavingGoal(goal);
        }
    }
}
