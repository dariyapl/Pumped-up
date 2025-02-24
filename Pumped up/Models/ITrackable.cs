using System;

namespace PumpedUp.Models
{
    public interface ITrackable
    {


        int Id { get; }
        int UserId { get; }
        DateTime Date { get; }
        void DisplayInfo();
    }

    
}
