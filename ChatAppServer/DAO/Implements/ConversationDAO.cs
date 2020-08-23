using ChatAppServer.Models;
using ChatAppServer.SocketServer;
using ReferenceData.Utils;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ChatAppServer.DAO.Implements
{
    class ConversationDAO : IConversationDAO
    {
        private ChatAppModels db;
        private HashSet<OnlineAccount> onlineList;

        public ConversationDAO()
        {
            this.db = new ChatAppModels();
        }

        public ConversationDAO(HashSet<OnlineAccount> onlineList)
        {
            this.db = new ChatAppModels();
            this.onlineList = onlineList;
        }
        public List<ReferenceData.Entity.Conversation> GetConversationListOfAccount(int accId)
        {
            var resultSet = db.Usp_GetConversationsByUserId(accId).ToList();
            List<ReferenceData.Entity.Conversation> list = null;
            if(resultSet.Count > 0)
            {
                list = new List<ReferenceData.Entity.Conversation>();
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                foreach (var c in resultSet)
                {
                    ReferenceData.Entity.Conversation cvst = new ReferenceData.Entity.Conversation();
                    cvst.id = c.id;
                    cvst.creatorId = c.creatorId;
                    cvst.senderId = c.senderId;
                    cvst.messageType = c.messageType;
                    cvst.content = c.content;
                    cvst.title = c.title;
                    cvst.memberList = new AccountDAO().GetAccountByConversationId(cvst.id);
                    if(cvst.memberList != null)
                    {
                        if(cvst.memberList.Count > 2)
                        {
                            cvst.state = true;
                            cvst.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + c.avatar);
                        } else
                        {
                            foreach(var u in cvst.memberList)
                            {
                                if(u.id != accId)
                                {
                                    foreach(var onl in onlineList)
                                    {
                                        if(onl.Acc.Equals(u))
                                        {
                                            cvst.state = true;
                                            break;
                                        }
                                    }
                                    cvst.title = u.firstName + " " + u.lastName;
                                    cvst.avatar = u.avatar;
                                }
                            }
                        }
                    }
                    cvst.createdAt = c.createdAt;
                    list.Add(cvst);
                }
            }
            return list;
        }
        public bool InsertConversation(ReferenceData.Entity.Conversation c)
        {
            int result = db.Usp_InsertConversation(c.id, c.creatorId, c.avatar2, c.title2);
            if(result == 1)
            {
                return true;
            }
            return false;
        }
    }
}
