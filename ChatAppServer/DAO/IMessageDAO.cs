using System.Collections.Generic;
namespace ChatAppServer.DAO
{
    public interface IMessageDAO
    {
        List<ReferenceData.Entity.Message> GetMessagesByConversationId(string conversationId, int offset, int limit);
        List<ReferenceData.Entity.Message> GetAllMessagesByConversationId(string conversationId);
        void InsertMessage(ReferenceData.Entity.Message message);
    }
}
