using LinqToDB.Mapping;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Backend.Models
{
    public static class PinExt
    {
        public static (DbPinPreview, DbPinBody) Deconstruct(this Pin pin)
        {
            DbPinPreview preview = new()
            {
                Author = pin.Author,
                Expires = pin.Expires,
                Id = pin.Id,
                Kind = pin.Kind,
                KindId = pin.KindId,
                Lat = pin.Lat,
                Lon = pin.Lon,
                Status = pin.Status,
                Title = pin.Title,
                Created = pin.Created
            };

            DbPinBody body = new()
            {
                Id = pin.Id,
                Description = pin.Description,
                Image = pin.Image
            };
            return (preview, body);
        }
    }
}