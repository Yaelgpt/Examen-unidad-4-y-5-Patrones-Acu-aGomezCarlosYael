using System;
using System.Windows.Forms;
using NotificacionesWinForms.Domain;
using NotificacionesWinForms.Application;
using NotificacionesWinForms.Infrastructure;

namespace NotificacionesWinForms.Presentation
{
    public partial class MainForm : Form
    {
        private readonly DraftConfig _config = new DraftConfig();
        private readonly History _history = new History();
        private readonly NotifierService _service = new NotifierService();

        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;

            cboTema.SelectedIndex = 0;
            cboCanal.SelectedIndex = 0;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                btnDeshacer.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void LoadConfigFromControls()
        {
            _config.Texto = txtTexto.Text ?? "";
            _config.Tema = Math.Max(0, cboTema.SelectedIndex);
            _config.Urgente = chkUrgente.Checked;
            _config.Tamanio = (int)numTamanio.Value;
            _config.Canal = cboCanal.SelectedIndex + 1;
            _config.Destino = txtDestino.Text ?? "";
        }

        private void ApplyConfigToControls()
        {
            txtTexto.Text = _config.Texto;
            cboTema.SelectedIndex = Math.Max(0, _config.Tema);
            chkUrgente.Checked = _config.Urgente;
            numTamanio.Value = Math.Max(1, Math.Min(3, _config.Tamanio));
            cboCanal.SelectedIndex = Math.Max(0, _config.Canal - 1);
            txtDestino.Text = _config.Destino;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTexto.Text))
            {
                MessageBox.Show("Por favor, ingresa un texto de notificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Por favor, ingresa un destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            LoadConfigFromControls();

            
            if (string.IsNullOrEmpty(_config.Texto))
            {
                MessageBox.Show("El texto de la notificación no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _history.Push(_config.CreateMemento());
            string preview = _service.BuildPreview(_config);

            
            PreviewStyler.Apply(rtbPreview, preview);
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtTexto.Text))
            {
                MessageBox.Show("Por favor, ingresa un texto de notificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDestino.Text))
            {
                MessageBox.Show("Por favor, ingresa un destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            LoadConfigFromControls();

            if (string.IsNullOrEmpty(_config.Texto))
            {
                MessageBox.Show("El texto de la notificación no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dr = MessageBox.Show("¿Estás seguro de enviar el mensaje?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr != DialogResult.Yes) return;
            _service.Send(_config);
        }


        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            var snap = _history.PopOrNull();
            if (snap == null)
            {
                MessageBox.Show("No hay cambios que deshacer", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _config.Restore(snap);
            ApplyConfigToControls();
            PreviewStyler.Apply(rtbPreview, _service.BuildPreview(_config));
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            cboTema.SelectedIndex = 0;
            chkUrgente.Checked = false;
            numTamanio.Value = 1;
            cboCanal.SelectedIndex = 0;
            txtDestino.Clear();
            rtbPreview.Clear();
            _history.Clear();
        }
    }
}
