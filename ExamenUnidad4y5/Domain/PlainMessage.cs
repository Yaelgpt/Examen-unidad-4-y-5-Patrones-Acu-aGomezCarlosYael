namespace NotificacionesWinForms.Domain
{
    public class PlainMessage : IMessage
    {
        private readonly string _text;
        public PlainMessage(string text) { _text = text; }
        public string GetText() => _text;
    }
}
