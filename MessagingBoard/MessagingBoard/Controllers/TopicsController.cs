using MessagingBoard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessagingBoard.Controllers
{
    public class TopicsController : ApiController
    {
        private IMessagingBoardRepository _repo;
        public TopicsController(IMessagingBoardRepository repo)
        {
            _repo = repo;
        }
        public IEnumerable<Topic> Get()
        {
            var topics = _repo.GetTopiks()
                .OrderByDescending(m => m.Created)
                .Take(25)
                .ToList();

            return topics;
        }
    }
}
