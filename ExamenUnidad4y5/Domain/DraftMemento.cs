namespace NotificacionesWinForms.Domain
{
    public class DraftMemento
    {
        public string Texto { get; }
        public int Tema { get; }
        public bool Urgente { get; }
        public int Tamanio { get; }
        public int Canal { get; }
        public string Destino { get; }

        internal DraftMemento(string texto, int tema, bool urgente, int tamanio, int canal, string destino)
        {
            Texto = texto;
            Tema = tema;
            Urgente = urgente;
            Tamanio = tamanio;
            Canal = canal;
            Destino = destino;
        }
    }
}
