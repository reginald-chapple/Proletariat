﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proletariat.Web.Hubs
{
    public class ChatHub : Hub
    {
        public string GetConnectionId() => Context.ConnectionId;
    }
}
