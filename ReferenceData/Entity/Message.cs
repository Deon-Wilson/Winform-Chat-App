using System;

namespace ReferenceData.Entity
{
    [Serializable]
    public class Message
    {
        public string id { get; set; }
        public string conversationId { get; set; }
        public int senderId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public byte[] avatar { get; set; }
        public string content { get; set; }
        public byte[] file { get; set; }
        public string messageType { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }

        public virtual Account Account { get; set; }
        public virtual Conversation Conversation { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Message))
            {
                return false;
            }
            Message other = (Message)obj;
            if ((id == null && other.id != null) || (id != null && !id.Equals(other.id)))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            int hash = 0;
            hash += (id != null ? id.GetHashCode() : 0);
            return hash;
        }
    }
}
