using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class GroupMember : UserControl
    {
        public ReferenceData.Entity.Account Acc { get; set; }
        public GroupMember()
        {
            InitializeComponent();
        }
        public GroupMember(ReferenceData.Entity.Account acc)
        {
            InitializeComponent();
            Acc = acc;
        }

        private void GroupMember_Load(object sender, EventArgs e)
        {
            lbUserName.Text = Acc.lastName;
            pbAvatar.Image = ChatAppUtils.ByteToImage(Acc.avatar);
        }
        public void BtnRemoveClick(EventHandler e)
        {
            this.btnRemove.Click += e;
        }
    }
}
