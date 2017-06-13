using System.Collections;
using System.Collections.Generic;
using Model.Entity;

namespace Model.REST
{
    public class RestClient
    {
        public IEnumerable<Player> players;

        public IEnumerable<Player> GetPlayers()
        {
            return new List<Player>();
        }
    }
}