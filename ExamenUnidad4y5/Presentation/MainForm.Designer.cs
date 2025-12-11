using System.Drawing;
using System.Windows.Forms;

namespace NotificacionesWinForms.Presentation
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.lblTema = new System.Windows.Forms.Label();
            this.chkUrgente = new System.Windows.Forms.CheckBox();
            this.numTamanio = new System.Windows.Forms.NumericUpDown();
            this.lblTamanio = new System.Windows.Forms.Label();
            this.cboCanal = new System.Windows.Forms.ComboBox();
            this.lblCanal = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTamanio)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(16, 32);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(440, 80);
            this.txtTexto.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 13);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(112, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto de notificacion";
            // 
            // cboTema
            // 
            this.cboTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Items.AddRange(new object[] {
            "0 Ninguna",
            "1 Navidad",
            "2 Halloween",
            "3 Cumpleaños"});
            this.cboTema.Location = new System.Drawing.Point(16, 137);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(180, 21);
            this.cboTema.TabIndex = 1;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(13, 121);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(40, 13);
            this.lblTema.TabIndex = 3;
            this.lblTema.Text = "Tema";
            // 
            // chkUrgente
            // 
            this.chkUrgente.AutoSize = true;
            this.chkUrgente.Location = new System.Drawing.Point(216, 139);
            this.chkUrgente.Name = "chkUrgente";
            this.chkUrgente.Size = new System.Drawing.Size(68, 17);
            this.chkUrgente.TabIndex = 2;
            this.chkUrgente.Text = "Urgente";
            this.chkUrgente.UseVisualStyleBackColor = true;
            // 
            // numTamanio
            // 
            this.numTamanio.Location = new System.Drawing.Point(310, 138);
            this.numTamanio.Minimum = new decimal(new int[] {1,0,0,0});
            this.numTamanio.Maximum = new decimal(new int[] {3,0,0,0});
            this.numTamanio.Value = new decimal(new int[] {1,0,0,0});
            this.numTamanio.Name = "numTamanio";
            this.numTamanio.Size = new System.Drawing.Size(86, 20);
            this.numTamanio.TabIndex = 3;
            // 
            // lblTamanio
            // 
            this.lblTamanio.AutoSize = true;
            this.lblTamanio.Location = new System.Drawing.Point(307, 121);
            this.lblTamanio.Name = "lblTamanio";
            this.lblTamanio.Size = new System.Drawing.Size(53, 13);
            this.lblTamanio.TabIndex = 7;
            this.lblTamanio.Text = "Tamaño";
            // 
            // cboCanal
            // 
            this.cboCanal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanal.FormattingEnabled = true;
            this.cboCanal.Items.AddRange(new object[] {
            "1 App",
            "2 Email"});
            this.cboCanal.Location = new System.Drawing.Point(16, 184);
            this.cboCanal.Name = "cboCanal";
            this.cboCanal.Size = new System.Drawing.Size(180, 21);
            this.cboCanal.TabIndex = 4;
            // 
            // lblCanal
            // 
            this.lblCanal.AutoSize = true;
            this.lblCanal.Location = new System.Drawing.Point(13, 168);
            this.lblCanal.Name = "lblCanal";
            this.lblCanal.Size = new System.Drawing.Size(39, 13);
            this.lblCanal.TabIndex = 9;
            this.lblCanal.Text = "Canal";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(216, 184);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(240, 20);
            this.txtDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(213, 168);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(51, 13);
            this.lblDestino.TabIndex = 11;
            this.lblDestino.Text = "Destino";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(16, 220);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(90, 28);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "Vista previa";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            this.toolTip1.SetToolTip(this.btnPreview, "Genera y guarda una vista previa (se guarda un punto para deshacer)");
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(122, 220);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(90, 28);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.toolTip1.SetToolTip(this.btnEnviar, "Enviar usando el canal seleccionado");
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(228, 220);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(120, 28);
            this.btnDeshacer.TabIndex = 8;
            this.btnDeshacer.Text = "Deshacer (Ctrl+Z)";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.BackColor = Color.MistyRose;
            this.btnDeshacer.ForeColor = Color.Firebrick;
            this.btnDeshacer.Font = new Font(this.btnDeshacer.Font, FontStyle.Bold);
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            this.toolTip1.SetToolTip(this.btnDeshacer, "Vuelve al último estado guardado (se guarda al generar Vista previa)");
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(96, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.toolTip1.SetToolTip(this.btnLimpiar, "Reinicia todos los campos");
            // 
            // rtbPreview
            // 
            this.rtbPreview.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbPreview.Location = new System.Drawing.Point(16, 276);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ReadOnly = true;
            this.rtbPreview.Size = new System.Drawing.Size(440, 220);
            this.rtbPreview.TabIndex = 12;
            this.rtbPreview.Text = "";
            this.rtbPreview.WordWrap = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(13, 258);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(71, 13);
            this.lblPreview.TabIndex = 13;
            this.lblPreview.Text = "Vista previa";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(476, 515);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.lblCanal);
            this.Controls.Add(this.cboCanal);
            this.Controls.Add(this.lblTamanio);
            this.Controls.Add(this.numTamanio);
            this.Controls.Add(this.chkUrgente);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificaciones  Decorator  Bridge  Factory  Memento";
            ((System.ComponentModel.ISupportInitialize)(this.numTamanio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtTexto;
        private Label lblTexto;
        private ComboBox cboTema;
        private Label lblTema;
        private CheckBox chkUrgente;
        private NumericUpDown numTamanio;
        private Label lblTamanio;
        private ComboBox cboCanal;
        private Label lblCanal;
        private TextBox txtDestino;
        private Label lblDestino;
        private Button btnPreview;
        private Button btnEnviar;
        private Button btnDeshacer;
        private Button btnLimpiar;
        private RichTextBox rtbPreview;
        private Label lblPreview;
        private ToolTip toolTip1;
    }
}
