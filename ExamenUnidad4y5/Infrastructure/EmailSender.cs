using NotificacionesWinForms.Presentation;

namespace NotificacionesWinForms.Infrastructure
{
    public class EmailSender : ISender
    {
        public string Nombre => "Email";
        public void Send(string texto, string destino)
        {
            using (var f = new DisplayForm($"[Email a {destino}]", texto))
                f.ShowDialog();
        }
    }
}
