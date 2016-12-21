using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading;

namespace SendNotifications
{
    public class NotificationHub : Hub
    {
        public void Hello(string nombreUsuario, string tipoMensaje, string mensaje)
        {
            Clients.All.mostrarNotificacion(nombreUsuario + mensaje, tipoMensaje);
            /*
            for (int i = 0; i < 4; i++)
            {
                Clients.All.mostrarNotificacion(nombre + mensaje, tipoMensaje);
                Thread.Sleep(10000);
            }*/
        }
    }
}