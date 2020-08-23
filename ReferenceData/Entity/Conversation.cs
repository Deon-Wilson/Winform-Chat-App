using System;
using System.Collections.Generic;

namespace ReferenceData.Entity
{
    [Serializable]
    public class Conversation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conversation()
        {
            this.Messages = new HashSet<Message>();
            this.Participants = new HashSet<Participant>();
        }

        public string id { get; set; }
        public int creatorId { get; set; }
        public byte[] avatar { get; set; }
        public string avatar2 { get; set; } = null;
        public string title { get; set; }
        public string title2 { get; set; } = null;
        public int senderId { get; set; }
        public string messageType { get; set; }
        public string content { get; set; }
        public bool state { get; set; } = false;
        public List<Account> memberList {get;set;}
        public Nullable<System.DateTime> createdAt { get; set; }

        public virtual Account Creator { get; set; }
        public virtual Account Sender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participants { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Conversation)) {
                return false;
            }
            Conversation other = (Conversation)obj;
            if ((this.id == null && other.id != null) || (this.id != null && !this.id.Equals(other.id)))
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