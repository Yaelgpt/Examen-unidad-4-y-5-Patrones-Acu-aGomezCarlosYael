using System.Collections.Generic;

namespace NotificacionesWinForms.Domain
{
    public class History
    {
        private readonly Stack<DraftMemento> _stack = new Stack<DraftMemento>();
        public void Push(DraftMemento m) { if (m != null) _stack.Push(m); }
        public DraftMemento PopOrNull() => _stack.Count > 0 ? _stack.Pop() : null;
        public void Clear() => _stack.Clear();
    }
}
