namespace NotificacionesWinForms.Application
{
    using NotificacionesWinForms.Domain;
    using NotificacionesWinForms.Infrastructure;

    public class NotifierService
    {
        private IMessage BuildMessage(DraftConfig cfg)
        {
            IMessage msg = new PlainMessage(cfg.Texto);
            if (cfg.Tema != 0 || cfg.Urgente || cfg.Tamanio > 1)
                msg = new SimpleDecorator(msg, cfg.Tema, cfg.Urgente, cfg.Tamanio);
            return msg;
        }

        public string BuildPreview(DraftConfig cfg) => BuildMessage(cfg).GetText();

        public void Send(DraftConfig cfg)
        {
            var sender = SenderFactory.Create(cfg.Canal);
            var noti = new Notification(sender);
            noti.Publicar(BuildMessage(cfg), cfg.Destino);
        }
    }
}
