using System;

namespace PumpedUp.Models
{
    public class FoodLog : LogEntry
    {
        public string FoodName { get; private set; }
        public double Calories { get; private set; }

        public FoodLog(int id, int userId, string foodName, double calories, DateTime date)
            : base(id, userId, date)
        {
            FoodName = foodName;
            Calories = calories;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Харчування] {FoodName} - {Calories} калорій, Дата: {Date.ToShortDateString()}");
        }
    }
}
