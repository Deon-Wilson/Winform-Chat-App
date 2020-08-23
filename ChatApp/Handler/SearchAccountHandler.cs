using ChatApp.Views;
using ReferenceData;

namespace ChatApp.Handler
{
    public class SearchAccountHandler
    {
        private Frame form;

        public SearchAccountHandler(Frame form)
        {
            this.form = form;
        }
        public void Handle(string keyword)
        {
            form.Client.send(new SocketData("SEARCHACCOUNT", keyword));
        }
    }
}
