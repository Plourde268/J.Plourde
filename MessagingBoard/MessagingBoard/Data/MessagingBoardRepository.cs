using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessagingBoard.Data
{
    public class MessagingBoardRepository : IMessagingBoardRepository
    {
        MessagingBoardContext _ctx;

        public MessagingBoardRepository(MessagingBoardContext ctx)
        {
            _ctx = ctx;
        }
        public IQueryable<Topic> GetTopiks()
        {
            return _ctx.Topiks;
        }

        public IQueryable<Reply> GetReplysByTopic(int topicId)
        {
            return _ctx.Replys.Where(m => m.TopicId == topicId);
        }
    }
}