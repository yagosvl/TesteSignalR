using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalShare
{
    public class Class1
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {
            IHubContext hub = GlobalHost.ConnectionManager.GetHubContext<SignalService>();
            hub.Clients.All.EnviarMensagem("Oi", "Mundo");
        }
    }
}