namespace NotificacionesWinForms.Infrastructure
{
    public interface ISender
    {
        string Nombre { get; }
        void Send(string texto, string destino);
    }
}
