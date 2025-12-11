using System;

namespace NotificacionesWinForms.Domain
{
    public class SimpleDecorator : IMessage
    {
        private readonly IMessage _inner;
        private readonly int _tema;
        private readonly bool _urgente;
        private readonly int _tamanio;

        public SimpleDecorator(IMessage inner, int tema, bool urgente, int tamanio)
        {
            _inner = inner;
            _tema = tema;
            _urgente = urgente;
            _tamanio = tamanio;
        }

        public string GetText()
        {
            string t = _inner.GetText();

            if (_tema != 0)
            {
                string marco = new string('*', Math.Max(10, t.Length));
                if (_tema == 1) t = $"[NAVIDAD]\n{marco}\nFELIZ NAVIDAD\n{t}\n{marco}";
                else if (_tema == 2) t = $"[HALLOWEEN]\n{marco}\nNOCHE DE HALLOWEEN\n{t}\n{marco}";
                else if (_tema == 3) t = $"[CUMPLEAÑOS]\n{marco}\nFELIZ CUMPLEAÑOS\n{t}\n{marco}";
            }

            if (_tamanio > 1)
            {
                var lineas = t.Split('\n');               
                for (int i = 0; i < lineas.Length; i++)
                    lineas[i] = string.Join(" ", lineas[i].ToUpperInvariant().ToCharArray());

                t = $"[Tamanio x{_tamanio}]\n" + string.Join("\n", lineas);  
            }

            if (_urgente)
            {
                string barra = new string('!', 24);
                t = "[URGENTE]\n" + t + "\n" + barra;     
            }
            else
            {
                t = "[NORMAL]\n" + t;                     
            }

            return t;
        }
    }
}
