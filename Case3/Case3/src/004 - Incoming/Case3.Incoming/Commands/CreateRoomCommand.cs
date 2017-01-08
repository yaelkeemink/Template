﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Case3.Incoming.Commands
{
    public class CreateRoomCommand
        : ICommand
    {
        public Guid CommandId { get; set; }

        public DateTime Timestamp { get; set; }

        public string RoomName { get; set; }
    }
}
