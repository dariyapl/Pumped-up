using System;

namespace PumpedUp.Models
{
    public class Goals : ITrackable
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public double TargetCalories { get; private set; }
        protected double TargetWeight { get; set; } // Доступний у похідних класах
        public DateTime Deadline { get; private set; }

        public DateTime Date { get; set; }


        public Goals(int id, int userId, double targetCalories, double targetWeight, DateTime deadline)
        {
            Id = id;
            UserId = userId;
            TargetCalories = targetCalories;
            TargetWeight = targetWeight;
            Deadline = deadline;
            Date = deadline; // Додаємо значення для Date
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"[Ціль] Споживати {TargetCalories} калорій, Досягти ваги {TargetWeight} кг до {Deadline.ToShortDateString()}");
        }
    }
}
