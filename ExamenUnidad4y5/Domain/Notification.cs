namespace NotificacionesWinForms.Domain
{
    using NotificacionesWinForms.Infrastructure;

    public class Notification
    {
        private readonly ISender _sender;
        public Notification(ISender sender) { _sender = sender; }
        public void Publicar(IMessage contenido, string destino) => _sender.Send(contenido.GetText(), destino);
    }
}
