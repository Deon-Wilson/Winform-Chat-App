using ChatApp.Views;
using ReferenceData;
using ReferenceData.Entity;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChatApp.Handler
{
    public class ReadResponseHandler
    {
        private delegate void AddConversationListDelegate(List<ReferenceData.Entity.Conversation> list);
        private delegate void StateDelegate(ReferenceData.Entity.Account acc);
        private delegate void GenarateMessageDelegate(List<ReferenceData.Entity.Message> list, FlowLayoutPanel fl);
        private delegate void AddInMessageDelegate(ReferenceData.Entity.Message message);
        private delegate void InitLatestMessageDelegate(Views.Components.Conversation cvst, ReferenceData.Entity.Message message);
        private delegate void DisplaySearchResultDelegate(List<ReferenceData.Entity.Account> list);
        private delegate void InsertConversationListDelegate(ReferenceData.Entity.Conversation cv);
        private delegate void LoadMoreMessageDelegate(List<ReferenceData.Entity.Message> list);
        private delegate void NoArgumentDelegate();
        private Frame form;

        public ReadResponseHandler(Frame form)
        {
            this.form = form;
        }
        public void readResponseLoop()
        {
            while (true)
            {
                SocketData data = form.Client.receive();
                if (data != null)
                {
                    string dataType = data.DataType.ToUpper();
                    switch (dataType)
                    {
                        case "CONVERSATIONLIST":
                            handleConversationList(data.Data);
                            break;
                        case "ONLINE":
                            handleOnline(data.Data);
                            break;
                        case "OFFLINE":
                            handleOffline(data.Data);
                            break;
                        case "MESSAGELIST":
                            handleMessageList(data.Data);
                            break;
                        case "MESSAGE":
                            handleMessage(data.Data);
                            break;
                        case "SEARCHRESULT":
                            handleSearchResult(data.Data);
                            break;
                        case "INSERTCONVERSATION":
                            handleInsertConversation(data.Data);
                            break;
                        case "LOADMOREMESSAGE":
                            handleLoadMoreMessage(data.Data);
                            break;
                        case "RESULTUPDATE":
                            handleResultUpdate(data.Data);
                            break;
                    }
                }
            }
        }

        private void handleResultUpdate(object data)
        {
            if (data == null)
            {
                form.Invoke(new NoArgumentDelegate(form.FailUpdate), new object[] { });
            }
            else
            {
                Account acc = (Account)data;
                form.Invoke(new StateDelegate(form.SuccessUpdate), new object[] { acc });
            }
        }

        private void handleLoadMoreMessage(object data)
        {
            List<ReferenceData.Entity.Message> list = (List<ReferenceData.Entity.Message>)data;
            if (form.ChatBox != null)
            {
                form.ChatBox.Invoke(new LoadMoreMessageDelegate(form.ChatBox.LoadMoreMessage), new object[] { list });
            }
        }

        private void handleInsertConversation(object data)
        {
            ReferenceData.Entity.Conversation cvst = (ReferenceData.Entity.Conversation)data;
            form.Invoke(new InsertConversationListDelegate(form.InsertConversationList), new object[] { cvst });
            form.Invoke(new NoArgumentDelegate(form.DisplayNewConversation), new object[] { });
        }

        private void handleSearchResult(object data)
        {
            List<ReferenceData.Entity.Account> list = (List<ReferenceData.Entity.Account>)data;
            if (list != null && form.NewChat == null)
            {
                form.Invoke(new DisplaySearchResultDelegate(form.DisplaySearchResult), new object[] { list });
            }
            else if (list != null && form.NewChat != null)
            {
                form.NewChat.Invoke(new DisplaySearchResultDelegate(form.NewChat.DisplaySearchResult), new object[] { list });
            }
        }

        private void handleConversationList(object data)
        {
            List<ReferenceData.Entity.Conversation> list = (List<ReferenceData.Entity.Conversation>)data;
            if (list != null)
            {
                form.Invoke(new AddConversationListDelegate(form.AddConversationList), new object[] { list });
            }
        }

        private void handleOnline(object data)
        {
            ReferenceData.Entity.Account acc = (ReferenceData.Entity.Account)data;
            form.Invoke(new StateDelegate(form.Online), new object[] { acc });
        }
        private void handleOffline(object data)
        {
            ReferenceData.Entity.Account acc = (ReferenceData.Entity.Account)data;
            form.Invoke(new StateDelegate(form.Offline), new object[] { acc });
        }
        private void handleMessageList(object data)
        {
            List<ReferenceData.Entity.Message> messageList = (List<ReferenceData.Entity.Message>)data;
            form.ChatBox.Invoke(new GenarateMessageDelegate(form.ChatBox.GenarateMessage), new object[] { messageList, form.ChatBox.FPMessage1 });
        }
        private void handleMessage(object data)
        {
            ReferenceData.Entity.Message message = (ReferenceData.Entity.Message)data;
            if (form.ChatBox != null && form.ChatBox.Conversation.id.Equals(message.conversationId))
            {
                form.ChatBox.Invoke(new AddInMessageDelegate(form.ChatBox.AddInMessage), new object[] { message });

            }
            else
            {
                foreach (var c in form.ConversationList)
                {
                    if (c.Cvst.id.Equals(message.conversationId))
                    {
                        form.Invoke(new InitLatestMessageDelegate(form.InitLatestMessage), new object[] { c, message });
                        break;
                    }
                }
            }

        }
    }
}
