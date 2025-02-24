using System;

namespace PumpedUp.Models
{
    public class WorkoutLog : LogEntry
    {
        public string WorkoutType { get; private set; }
        public double CaloriesBurned { get; private set; }

        public WorkoutLog(int id, int userId, string workoutType, double caloriesBurned, DateTime date)
            : base(id, userId, date)
        {
            WorkoutType = workoutType;
            CaloriesBurned = caloriesBurned;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Тренування] {WorkoutType} - {CaloriesBurned} калорій спалено, Дата: {Date.ToShortDateString()}");
        }
    }
}
