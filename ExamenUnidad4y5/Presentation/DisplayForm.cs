using System.Drawing;
using System.Windows.Forms;

namespace NotificacionesWinForms.Presentation
{
    public class DisplayForm : Form
    {
        private readonly RichTextBox _rtb = new RichTextBox();

        public DisplayForm(string titulo, string contenido)
        {
            Text = titulo;
            Width = 520;
            Height = 460;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            _rtb.Dock = DockStyle.Fill;
            _rtb.ReadOnly = true;
            _rtb.Font = new System.Drawing.Font("Consolas", 10);
            _rtb.WordWrap = false;

            var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(8) };
            panel.Controls.Add(_rtb);
            Controls.Add(panel);

            PreviewStyler.Apply(_rtb, contenido);
        }
    }
}
