using System.Collections;
using System.Collections.Generic;
using Model.DAO;
using Model.Entity;

namespace Model.Service
{
    public class PlayerService
    {
        private readonly PlayerDao _playerDao;
        private IEnumerable<Player> _players;

        public PlayerService(PlayerDao playerDao)
        {
            _playerDao = playerDao;
        }

        public IEnumerable GetPlayers()
        {
            return _players;
        }

        public void UpdatePlayers()
        {
            _players = _playerDao.GetPlayers();
        }
    }
}