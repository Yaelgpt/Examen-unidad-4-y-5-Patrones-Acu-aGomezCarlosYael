using NotificacionesWinForms.Presentation;

namespace NotificacionesWinForms.Infrastructure
{
    public class AppSender : ISender
    {
        public string Nombre => "App";
        public void Send(string texto, string destino)
        {
            using (var f = new DisplayForm($"[App a {destino}]", texto))
                f.ShowDialog();
        }
    }
}
