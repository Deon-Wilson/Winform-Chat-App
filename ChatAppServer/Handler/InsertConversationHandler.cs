using ChatAppServer.DAO.Implements;
using ChatAppServer.SocketServer;
using ReferenceData;
using System;
using System.Diagnostics;
using System.IO;

namespace ChatAppServer.Handler
{
    public class InsertConversationHandler : BaseThread
    {
        private ServerWorker worker;
        private SocketData data;

        public InsertConversationHandler(ServerWorker worker, SocketData data)
        {
            this.worker = worker;
            this.data = data;
        }

        public override void Run()
        {
            ReferenceData.Entity.Conversation cvst = (ReferenceData.Entity.Conversation)data.Data;
            if (cvst.avatar2 != null && cvst.avatar != null)
            {
                string imagesFolder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\Files\Images\";
                string[] info = getFileInfo(cvst.avatar2);
                cvst.avatar2 = info[0] + DateTime.Now.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds + "." + info[1];
                File.WriteAllBytes(imagesFolder + cvst.avatar2, cvst.avatar);
            }
            bool result = new ConversationDAO().InsertConversation(cvst);
            if(result)
            {
                foreach(var member in cvst.memberList)
                {
                    ReferenceData.Entity.Participant p = new ReferenceData.Entity.Participant();
                    p.conversationId = cvst.id;
                    p.userId = member.id;
                    new ParticipantDAO().InsertParticipant(p);
                }
                foreach (var onl in worker.Server.OnlineList)
                {
                    foreach (var mb in cvst.memberList)
                    {
                        if (onl.Acc.id == mb.id && mb.id != cvst.creatorId)
                        {
                            cvst.state = true;
                            onl.Worker.send(new SocketData("INSERTCONVERSATION", cvst));
                            if(cvst.memberList.Count == 2)
                            {
                                this.worker.send(new SocketData("ONLINE", mb));
                            }
                        }
                    }
                }
            }
        }

        private string[] getFileInfo(string fileName)
        {
            string[] info = new string[] { "", "" };
            string[] arrName = fileName.Split('.');
            if (arrName.Length >= 2)
            {
                info[1] = arrName[arrName.Length - 1];
                for (int i = 0; i < arrName.Length - 1; i++)
                {
                    if (i == arrName.Length - 2)
                    {
                        info[0] += arrName[i];
                    }
                    else
                    {
                        info[0] += arrName[i] + ".";
                    }
                }
            }
            else
            {
                info[0] = arrName[0];
            }
            return info;
        }
    }
}
