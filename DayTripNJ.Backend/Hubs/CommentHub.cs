﻿using System;
using System.Threading.Tasks;
using DayTripNJ.Shared;
using Microsoft.AspNetCore.SignalR;

namespace DayTripNJ.Backend.Hubs
{
    public class CommentHub: Hub<ICommentClient>
    {
        public async Task JoinPinRoom(Guid pinId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, GetGroupName(pinId));
        }
 
        public static string GetGroupName(Guid pinId)
        {
            return $"PNG|{pinId}";
        }
        
    }
}