namespace BaseAPP.Formularios
{
    partial class MantenimientoCaracteristicasComponentes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCaracteristicasComponentes));
            dgvCaracteristicas = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            pbCaracteristica = new PictureBox();
            cbCaracteristicas = new ComboBox();
            label2 = new Label();
            txtValor = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCaracteristicas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaracteristica).BeginInit();
            SuspendLayout();
            // 
            // dgvCaracteristicas
            // 
            dgvCaracteristicas.AllowUserToAddRows = false;
            dgvCaracteristicas.AllowUserToDeleteRows = false;
            dgvCaracteristicas.AllowUserToResizeColumns = false;
            dgvCaracteristicas.AllowUserToResizeRows = false;
            dgvCaracteristicas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCaracteristicas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCaracteristicas.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvCaracteristicas.BorderStyle = BorderStyle.None;
            dgvCaracteristicas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCaracteristicas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCaracteristicas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCaracteristicas.ColumnHeadersHeight = 30;
            dgvCaracteristicas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCaracteristicas.EnableHeadersVisualStyles = false;
            dgvCaracteristicas.GridColor = SystemColors.MenuBar;
            dgvCaracteristicas.Location = new Point(26, 111);
            dgvCaracteristicas.MultiSelect = false;
            dgvCaracteristicas.Name = "dgvCaracteristicas";
            dgvCaracteristicas.ReadOnly = true;
            dgvCaracteristicas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCaracteristicas.RowHeadersVisible = false;
            dgvCaracteristicas.RowHeadersWidth = 51;
            dgvCaracteristicas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCaracteristicas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCaracteristicas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCaracteristicas.Size = new Size(684, 235);
            dgvCaracteristicas.TabIndex = 32;
            dgvCaracteristicas.CellClick += dgvCaracteristicas_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(7, 111, 178);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(260, 369);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(20, 0, 0, 0);
            btnEliminar.Size = new Size(217, 39);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(7, 111, 178);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(26, 369);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(20, 0, 0, 0);
            btnGuardar.Size = new Size(223, 39);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(7, 111, 178);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnLimpiar.ForeColor = SystemColors.ControlLight;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(487, 369);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(20, 0, 0, 0);
            btnLimpiar.Size = new Size(223, 39);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pbCaracteristica
            // 
            pbCaracteristica.Image = (Image)resources.GetObject("pbCaracteristica.Image");
            pbCaracteristica.Location = new Point(353, 58);
            pbCaracteristica.Name = "pbCaracteristica";
            pbCaracteristica.Size = new Size(34, 35);
            pbCaracteristica.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCaracteristica.TabIndex = 36;
            pbCaracteristica.TabStop = false;
            pbCaracteristica.Click += pbCaracteristica_Click;
            // 
            // cbCaracteristicas
            // 
            cbCaracteristicas.BackColor = Color.FromArgb(13, 50, 76);
            cbCaracteristicas.FlatStyle = FlatStyle.Popup;
            cbCaracteristicas.Font = new Font("Segoe UI", 10.8F);
            cbCaracteristicas.ForeColor = Color.WhiteSmoke;
            cbCaracteristicas.FormattingEnabled = true;
            cbCaracteristicas.Location = new Point(26, 61);
            cbCaracteristicas.Name = "cbCaracteristicas";
            cbCaracteristicas.Size = new Size(321, 33);
            cbCaracteristicas.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(22, 32);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 34;
            label2.Text = "Caracteristica:";
            // 
            // txtValor
            // 
            txtValor.BackColor = Color.FromArgb(13, 50, 76);
            txtValor.BorderStyle = BorderStyle.None;
            txtValor.Font = new Font("Segoe UI", 10.8F);
            txtValor.ForeColor = Color.WhiteSmoke;
            txtValor.Location = new Point(409, 64);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(301, 29);
            txtValor.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(409, 35);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 37;
            label8.Text = "Valor:";
            // 
            // MantenimientoCaracteristicasComponentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(735, 437);
            Controls.Add(txtValor);
            Controls.Add(label8);
            Controls.Add(pbCaracteristica);
            Controls.Add(cbCaracteristicas);
            Controls.Add(label2);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvCaracteristicas);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MantenimientoCaracteristicasComponentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caracteristicas Componentes";
            Load += MantenimientoCaracteristicasComponentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCaracteristicas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaracteristica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCaracteristicas;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private PictureBox pbCaracteristica;
        private ComboBox cbCaracteristicas;
        private Label label2;
        private TextBox txtValor;
        private Label label8;
    }
}