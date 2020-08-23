using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using ChatApp.Utils;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class IncomingMessage : UserControl
    {

        public List<UserControl> UList { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public IncomingMessage()
        {
            InitializeComponent();
            UList = new List<UserControl>();
        }
        public IncomingMessage(byte[] avatar, int userId, string userName, DateTime time)
        {
            InitializeComponent();
            UList = new List<UserControl>();
            Time = time;
            UserId = userId;
            this.userAvatar.Image = ChatAppUtils.ByteToImage(avatar);
            this.info.Text = userName + " - " + Time.ToString("HH:mm dd/MM/yyyy");
        }


        private void setHeight()
        {
            bubbleArea.Height = bubbleArea.PreferredSize.Height;
            this.Height = info.Height + bubbleArea.Height + 12;
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
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != typeof(IncomingMessage))
            {
                return false;
            }
            IncomingMessage other = (IncomingMessage)obj;
            if (UserId != other.UserId || !Time.Equals(other.Time))
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
