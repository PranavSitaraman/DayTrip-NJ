using System.Threading.Tasks;
using DayTripNJ.Shared.Models;

namespace DayTripNJ.Shared
{
    public interface ICommentClient
    {
        Task ReceiveComment(Comment comment);
    }
}