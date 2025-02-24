using System;

namespace PumpedUp.Models
{
    public abstract class LogEntry : ITrackable
    {
        public int Id { get; private set; }  // закритий для змін зовні
        public int UserId { get; protected set; } // доступний у похідних класах
        public DateTime Date { get; set; }

        public LogEntry(int id, int userId, DateTime date)
        {
            Id = id;
            UserId = userId;
            Date = date;
        }

        public abstract void DisplayInfo();
    }
}
