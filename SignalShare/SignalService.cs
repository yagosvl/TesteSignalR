using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalShare
{
    class SignalService : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {
            int vet = 3;
            Clients.All.TransmitirMensagem(vet);
        }
    }
}