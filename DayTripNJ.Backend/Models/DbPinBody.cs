using System;
using LinqToDB.Mapping;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Backend.Models
{
    [Table(Name = "pin_bodies")]
    [Column("id", nameof(Id))]
    [Column("image", nameof(Image))]
    [Column("description", nameof(Description))]
    public record DbPinBody : PinBody
    {
    }
}