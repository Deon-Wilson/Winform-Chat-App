using ChatAppServer.Models;

namespace ChatAppServer.DAO.Implements
{
    public class ParticipantDAO : IParticipantDAO
    {
        private ChatAppModels db;

        public ParticipantDAO()
        {
            this.db = new ChatAppModels();
        }

        public void InsertParticipant(ReferenceData.Entity.Participant p)
        {
            db.Usp_InsertParticipant(p.userId, p.conversationId);
        }
    }
}
