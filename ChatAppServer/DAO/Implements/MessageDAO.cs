using ChatAppServer.Models;
using ReferenceData.Utils;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ChatAppServer.DAO.Implements
{
    public class MessageDAO : IMessageDAO
    {
        private ChatAppModels db;

        public MessageDAO()
        {
            this.db = new ChatAppModels();
        }

        public List<ReferenceData.Entity.Message> GetAllMessagesByConversationId(string conversationId)
        {
            string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
            string otherFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Another_Files\";
            var resultSet = db.Usp_GetAllMessageByConversationId(conversationId).ToList();
            List<ReferenceData.Entity.Message> list = null;
            if (resultSet.Count > 0)
            {
                list = new List<ReferenceData.Entity.Message>();
                foreach (var m in resultSet)
                {
                    ReferenceData.Entity.Message message = new ReferenceData.Entity.Message();
                    message.id = m.id;
                    message.conversationId = m.conversationId;
                    message.senderId = m.senderId;
                    message.content = m.content;
                    message.messageType = m.messageType;
                    if (m.messageType.Equals("FILE"))
                    {
                        if (getFileType(m.content).Equals("IMAGE"))
                        {
                            message.file = ChatAppUtils.ConvertFileToByte(imagesFolder + m.content);
                        }
                        else
                        {
                            message.file = ChatAppUtils.ConvertFileToByte(otherFolder + m.content);
                        }
                    }
                    message.createdAt = m.createdAt;
                    message.firstName = m.firstName;
                    message.lastName = m.lastName;
                    message.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + m.avatar);
                    list.Add(message);
                }
            }
            return list;
        }

        public List<ReferenceData.Entity.Message> GetMessagesByConversationId(string conversationId, int offset, int limit)
        {
            string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
            string otherFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Another_Files\";
            var resultSet = db.Usp_GetMessagesByConversationId(conversationId, offset, limit).ToList();
            List<ReferenceData.Entity.Message> list = null;
            if (resultSet.Count > 0)
            {
                list = new List<ReferenceData.Entity.Message>();
                foreach(var m in resultSet)
                {
                    ReferenceData.Entity.Message message = new ReferenceData.Entity.Message();
                    message.id = m.id;
                    message.conversationId = m.conversationId;
                    message.senderId = m.senderId;
                    message.content = m.content;
                    message.messageType = m.messageType;
                    if(m.messageType.Equals("FILE"))
                    {
                        if(getFileType(m.content).Equals("IMAGE"))
                        {
                            message.file = ChatAppUtils.ConvertFileToByte(imagesFolder + m.content);
                        } else
                        {
                            message.file = ChatAppUtils.ConvertFileToByte(otherFolder + m.content);
                        }
                    }
                    message.createdAt = m.createdAt;
                    message.firstName = m.firstName;
                    message.lastName = m.lastName;
                    message.avatar = ChatAppUtils.ConvertFileToByte(imagesFolder + m.avatar);
                    list.Add(message);
                }
            }
            return list;
        }

        public void InsertMessage(ReferenceData.Entity.Message message)
        {
            db.Usp_InsertMessage(message.id, message.conversationId, message.senderId, message.content, message.messageType, message.createdAt);
            if(message.messageType.Equals("FILE"))
            {
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                string otherFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Another_Files\";
                if(getFileType(message.content).Equals("IMAGE"))
                {
                    File.WriteAllBytes(imagesFolder + message.content, message.file);
                } else
                {
                    File.WriteAllBytes(otherFolder + message.content, message.file);
                }
            }
        }
        private string getFileType(string fileName)
        {
            string[] arrName = fileName.Split('_');
            string ex = arrName[arrName.Length - 1].ToUpper();
            string type = "OTHER";
            if(ex.Equals(".JPG") || ex.Equals(".JPEG") || ex.Equals(".PNG") || ex.Equals(".GIF"))
            {
                type = "IMAGE";
            } else
            {
                type = "OTHER";
            }
            return type;
        }
    }
}
