using Microsoft.AspNet.SignalR;
using System.Collections.Generic;

namespace Signal
{
    public class SignalService : Hub
    {
        public void EnviarMensagem(string apelido, string mensagem)
        {
            //IList<int> vet = new List<int>() { 1, 2, 3};
            int vet = 3;
            Clients.All.TransmitirMensagem(vet);
        }
    }
}