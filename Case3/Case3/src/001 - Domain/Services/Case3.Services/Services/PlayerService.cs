using Case3.Domain.Entities;
using Case3.Domain.Interfaces;
using System;

namespace Case3.Domain.Services {
    public class PlayerService : IDisposable
    {
        private readonly IRepository<Player, long> _repository;

        public PlayerService(IRepository<Player, long> repository)
        {
            _repository = repository;
        }

        public int CreatePlayer(Player player)
        {
            return _repository.Insert(player);
        }
        public int UpdatePlayer(Player player)
        {
            return _repository.Update(player);
        }
        public void Dispose()
        {
            _repository?.Dispose();
        }


    }
}
