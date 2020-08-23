using ChatApp.Views.Components;
using ReferenceData.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApp.Views
{
    public partial class MemberForm : Form
    {
        private List<Account> memberList;

        public MemberForm()
        {
            InitializeComponent();
        }
        public MemberForm(List<ReferenceData.Entity.Account> list)
        {
            InitializeComponent();
            this.memberList = list;
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            this.pnlMemberList.flowLayoutPanel.Padding = new Padding(16, 0, 0, 0);
            this.pnlMemberList.flowLayoutPanel.Controls.Clear();
            foreach(var acc in memberList)
            {
                SearchResult sr = new SearchResult(acc);
                sr.Size = new Size(410, 62);
                this.pnlMemberList.flowLayoutPanel.Controls.Add(sr);
            }
            this.pnlMemberList.UpdateUi();
        }
    }
}
