using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingBoard.Data
{
    public interface IMessagingBoardRepository
    {
        IQueryable<Topic> GetTopiks();

        IQueryable<Reply> GetReplysByTopic(int topicId);
    }
}
