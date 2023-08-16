using Microsoft.EntityFrameworkCore;
using STAGGI_Budget_API.Repositories;

namespace STAGGI_Budget_API.Models
{
    public class DBInitializer
    {
        public static void Initialize(YourDbContext dbContext)
        {
            // Aplicar las migraciones pendientes
            dbContext.Database.Migrate();

            // Verificar si ya hay datos en la base de datos
            if (!dbContext.SavingGoals.Any())
            {
                // Agregar datos iniciales de ejemplo
                dbContext.SavingGoals.Add(new SavingGoal
                {
                    Name = "Meta de Ahorro 1",
                    TargetAmount = 1000,
                    SavedAmount = 0,
                    Deadline = DateTime.Now.AddMonths(3)
                });

                dbContext.SavingGoals.Add(new SavingGoal
                {
                    Name = "Meta de Ahorro 2",
                    TargetAmount = 500,
                    SavedAmount = 200,
                    Deadline = DateTime.Now.AddMonths(6)
                });

                dbContext.SaveChanges();
            }
        }
    }
}
