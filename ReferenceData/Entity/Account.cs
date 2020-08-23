using System;
using System.Collections.Generic;

namespace ReferenceData.Entity
{

    [Serializable]
    public class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            this.Conversations = new HashSet<Conversation>();
            this.Messages = new HashSet<Message>();
            this.Participants = new HashSet<Participant>();
        }

        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> birthday { get; set; }
        public byte[] avatar { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conversation> Conversations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participants { get; set; }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(Account)) {
                return false;
            }
            Account other = (Account)obj;
            if (id != other.id)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return id.GetHashCode();
        }
    }
}
