using ChatApp.Views;
using ReferenceData.Entity;
using System;

namespace ChatApp.Handler
{
    public class SelectMemberHandler
    {
        private AddNewGroup groupform;
        private Account acc;

        public SelectMemberHandler(AddNewGroup groupform, Account acc)
        {
            this.groupform = groupform;
            this.acc = acc;
        }
        public void HandleAdd(object senderr, EventArgs e)
        {
            int i = 0;
            foreach(var mb in groupform.MemberList)
            {
                if(mb.Acc.id == acc.id)
                {
                    i = 1;
                    break;
                }
            }
            if(i == 0)
            {
                groupform.AddMember(acc);
            }
        }
        public void HandleRemove(object senderr, EventArgs e)
        {
            groupform.RemoveMember(acc);
        }
    }
}
