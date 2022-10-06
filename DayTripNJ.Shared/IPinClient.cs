using System.Threading.Tasks;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Shared
{
    public interface IPinClient
    {
        Task ReceivePin(PinPreview pin);
    }
}