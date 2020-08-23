using ChatApp.Handler;
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
    public partial class AddNewChat : Form
    {
        private Frame form;

        public AddNewChat()
        {
            InitializeComponent();
        }

        public AddNewChat(Frame form)
        {
            InitializeComponent();
            this.form = form;
            this.pnlResultList.flowLayoutPanel.Padding = new Padding(16, 0, 0, 0);
        }
        public void DisplaySearchResult(List<Account> list)
        {
            pnlResultList.flowLayoutPanel.Controls.Clear();
            foreach (var acc in list)
            {
                if (acc.id != form.User.id)
                {
                    SearchResult searchResult = new SearchResult(acc);
                    searchResult.Size = new Size(410, 62);
                    pnlResultList.flowLayoutPanel.Controls.Add(searchResult);
                    searchResult.SearchResultClick(new SearchResultClickHandler(form, acc).Handle2);
                }
            }
            pnlResultList.UpdateUi();
        }
        private void AddNewChat_Load(object sender, EventArgs e)
        {
            DisplayDefaultList();
        }
        public void DisplayDefaultList()
        {
            this.pnlResultList.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.pnlResultList.flowLayoutPanel.Controls.Clear();
            foreach (var c in form.ConversationList)
            {
                if (c.Cvst.memberList.Count == 2)
                {
                    foreach (var u in c.Cvst.memberList)
                    {
                        if (u.id != c.Acc.id)
                        {
                            SearchResult sr = new SearchResult(u);
                            sr.Size = new Size(410, 62);
                            this.pnlResultList.flowLayoutPanel.Controls.Add(sr);
                            sr.SearchResultClick(new SearchResultClickHandler(form, u).Handle2);
                        }
                    }

                }
            }
        }
        private void txtSearchAccount_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = this.txtSearchAccount.Text.Trim();
            if (e.KeyCode == Keys.Enter)
            {
                new SearchAccountHandler(form).Handle(keyword);
            }
            if (keyword.Length == 0)
            {
                DisplayDefaultList();
            }
        }
    }
}
