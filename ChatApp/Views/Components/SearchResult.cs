using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceData.Entity;
using ReferenceData.Utils;

namespace ChatApp.Views.Components
{
    public partial class SearchResult : UserControl
    {
        public Account Account { get; set; }
        public SearchResult()
        {
            InitializeComponent();
        }
        public SearchResult(Account acc)
        {
            InitializeComponent();
            Account = acc;
            this.pbAvatar.Image = ChatAppUtils.ByteToImage(acc.avatar);
            this.lbInfo.Text = acc.email;
            this.lbTitle.Text = acc.firstName + " " + acc.lastName;
        }
        public void SearchResultClick(EventHandler e)
        {
            this.bg.Click += e;
            this.lbInfo.Click += e;
            this.lbTitle.Click += e;
            this.pbAvatar.Click += e;
        }
    }
}
