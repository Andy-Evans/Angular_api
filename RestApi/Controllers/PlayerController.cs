using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class Player
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class PlayerController : ApiController
    {
        private IList<Player> _players = new List<Player>
        {
            new Player {Age = 21, Name = "Barry"},
            new Player {Age = 18, Name = "Barkley"}
        }; 

        // GET: api/Player
        public IEnumerable<Player> Get()
        {
            return _players;
        }

        // GET: api/Player/5
        public Player Get(int id)
        {
            return _players[id];
        }

        // POST: api/Player
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Player/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Player/5
        public void Delete(int id)
        {
        }
    }
}
