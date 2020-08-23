using ChatAppServer.Models;
using ReferenceData.Utils;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ChatAppServer.DAO.Implements
{
    public class AccountDAO : IAccountDAO
    {
        private ChatAppModels db;

        public AccountDAO()
        {
            this.db = new ChatAppModels();
        }

        public List<ReferenceData.Entity.Account> GetAccountByConversationId(string conversationId)
        {
            List<ReferenceData.Entity.Account> list = null;
            var resultSet = db.Usp_GetMembersOfConversation(conversationId).ToList();
            if(resultSet.Count > 0)
            {
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                list = new List<ReferenceData.Entity.Account>();
                foreach (var a in resultSet)
                {
                    ReferenceData.Entity.Account acc = new ReferenceData.Entity.Account();
                    acc.id = (int)a.id;
                    acc.email = a.email;
                    acc.password = a.password;
                    acc.firstName = a.firstName;
                    acc.lastName = a.lastName;
                    acc.birthday = a.birthday;
                    acc.createdAt = a.createdAt;
                    acc.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + a.avatar);
                    list.Add(acc);
                }
            }
            return list;
        }

        public ReferenceData.Entity.Account GetAccountBySignInInfo(string email, string password)
        {
            var list = db.Usp_GetAccountBySignInInfo(email, password).ToList();
            ReferenceData.Entity.Account acc = null;
            if (list.Count > 0)
            {
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                acc = new ReferenceData.Entity.Account();
                foreach (var u in list)
                {
                    acc.id = u.id;
                    acc.email = u.email;
                    acc.password = u.password;
                    acc.firstName = u.firstName;
                    acc.lastName = u.lastName;
                    acc.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + u.avatar);
                    acc.birthday = u.birthday;
                    acc.createdAt = u.createdAt;
                }
            }
            return acc;
        }
        public List<ReferenceData.Entity.Account> SearchAccount(string keyword)
        {
            List<ReferenceData.Entity.Account> list = null;
            var resultSet = db.Usp_SearchAccountByEmailOrName(keyword).ToList();
            if (resultSet.Count > 0)
            {
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                list = new List<ReferenceData.Entity.Account>();
                foreach (var a in resultSet)
                {
                    ReferenceData.Entity.Account acc = new ReferenceData.Entity.Account();
                    acc.id = (int)a.id;
                    acc.email = a.email;
                    acc.password = a.password;
                    acc.firstName = a.firstName;
                    acc.lastName = a.lastName;
                    acc.birthday = a.birthday;
                    acc.createdAt = a.createdAt;
                    acc.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + a.avatar);
                    list.Add(acc);
                }
            }
            return list;
        }

        public ReferenceData.Entity.Account UpdateAccount(ReferenceData.Entity.Account acc)
        {
            string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
            string avatar = "avatar" + acc.id + ".png";
            int result = db.Usp_UpdateAccount(acc.id, acc.email, acc.password, acc.firstName, acc.lastName, acc.birthday, avatar);
            if (result == 1)
            {
                File.WriteAllBytes(imagesFolder + avatar, acc.avatar);
                return acc;
            }
            return null;
        }
    }
}
