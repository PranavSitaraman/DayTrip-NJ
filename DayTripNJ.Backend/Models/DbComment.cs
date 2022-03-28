using LinqToDB.Mapping;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Backend.Models
{
    [Table("comments")]
    [Column("id", nameof(Id))]
    [Column("author", nameof(Author))]
    [Column("pin", nameof(Pin))]
    [Column("created", nameof(Created))]
    [Column("text", nameof(Text))]
    public record DbComment : Comment
    {
    }
}