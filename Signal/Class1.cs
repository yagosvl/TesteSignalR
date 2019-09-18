using Microsoft.AspNet.SignalR;
using System.Collections;
using System.Collections.Generic;

namespace Signal
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
