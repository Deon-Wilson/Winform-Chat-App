using System.Collections.Generic;

namespace ChatAppServer.DAO
{
    interface IConversationDAO
    {
        List<ReferenceData.Entity.Conversation> GetConversationListOfAccount(int accId);
        bool InsertConversation(ReferenceData.Entity.Conversation c);
    }
}
