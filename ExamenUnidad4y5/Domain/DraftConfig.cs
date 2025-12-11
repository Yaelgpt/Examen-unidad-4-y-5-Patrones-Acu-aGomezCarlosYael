namespace NotificacionesWinForms.Domain
{
    public class DraftConfig
    {
        public string Texto { get; set; } = "";
        public int Tema { get; set; } = 0;
        public bool Urgente { get; set; } = false;
        public int Tamanio { get; set; } = 1;
        public int Canal { get; set; } = 1;
        public string Destino { get; set; } = "";

        public DraftMemento CreateMemento()
            => new DraftMemento(Texto, Tema, Urgente, Tamanio, Canal, Destino);

        public void Restore(DraftMemento m)
        {
            if (m == null) return;
            Texto = m.Texto;
            Tema = m.Tema;
            Urgente = m.Urgente;
            Tamanio = m.Tamanio;
            Canal = m.Canal;
            Destino = m.Destino;
        }
    }
}
