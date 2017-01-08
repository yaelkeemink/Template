using System;

namespace Case3.Incoming.Commands
{
    public class EndGameCommand : ICommand
    {
        public Guid CommandId { get; set; }

        public DateTime Timestamp { get; set; }

        public long RoomId { get; set; }

        public string RoomName { get; set; }
    }
}