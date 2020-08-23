using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatApp.Views.Components
{
    public partial class OutgoingMessage : UserControl
    {
        public List<UserControl> UList { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public OutgoingMessage()
        {
            InitializeComponent();
            UList = new List<UserControl>();
        }
        public OutgoingMessage(int userId, DateTime time)
        {
            UserId = userId;
            Time = time;
            InitializeComponent();
            UList = new List<UserControl>();
            this.time.Text = Time.ToString("HH:mm dd/MM/yyyy");
        }
        private void setHeight()
        {
            bubbleArea.Height = bubbleArea.PreferredSize.Height;
            this.Height = time.Height + bubbleArea.Height + 12;
        }
        public void AddBubble(UserControl userControl)
        {
            UList.Add(userControl);
            this.bubbleArea.Controls.Add(userControl);
            setHeight();
        }
        public void RemoveBubble(UserControl userControl)
        {
            UList.Remove(userControl);
            this.bubbleArea.Controls.Remove(userControl);
            setHeight();
            if (UList.Count == 0)
            {
                this.Dispose();
            }
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(obj.GetType() != typeof(OutgoingMessage))
            {
                return false;
            }
            OutgoingMessage other = (OutgoingMessage)obj;
            if(UserId != other.UserId || !Time.Equals(other.Time))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return UserId.GetHashCode();
        }
    }
}
