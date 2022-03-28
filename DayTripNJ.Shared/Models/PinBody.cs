using System;

namespace DayTripNJ.Shared.Models
{
    public record PinBody
    {
        public Guid Id { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}