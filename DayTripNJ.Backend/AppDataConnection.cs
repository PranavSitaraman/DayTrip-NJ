using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using DayTripNJ.Backend.Models;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Backend
{
    public class AppDataConnection : DataConnection
    {
        public ITable<PinPreview> Pins => GetTable<DbPinPreview>();
        public ITable<PinBody> PinBodies => GetTable<DbPinBody>();
        public ITable<PinType> PinTypes => GetTable<DbPinType>();
        public ITable<DbComment> Comments => GetTable<DbComment>();

        public AppDataConnection(LinqToDbConnectionOptions<AppDataConnection> options) : base(options)
        {
            
            
        }
    }
    

}