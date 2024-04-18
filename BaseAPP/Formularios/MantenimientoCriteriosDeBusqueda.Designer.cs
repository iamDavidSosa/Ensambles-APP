namespace BaseAPP.Formularios
{
    partial class MantenimientoCriteriosDeBusqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCriteriosDeBusqueda));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label3 = new Label();
            pbTiposEnsambles = new PictureBox();
            cbCaracteristica1 = new ComboBox();
            label2 = new Label();
            cbTipo1 = new ComboBox();
            cbTipoUso = new ComboBox();
            groupBox2 = new GroupBox();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            dgvCriterios = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTiposEnsambles).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriterios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pbTiposEnsambles);
            groupBox1.Controls.Add(cbCaracteristica1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbTipo1);
            groupBox1.Controls.Add(cbTipoUso);
            groupBox1.Font = new Font("Segoe UI", 7.8F);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(973, 186);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de ensamble";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(18, 99);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 35;
            label1.Text = "Tipo de componente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(410, 99);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 33;
            label3.Text = "Caracteristica:";
            // 
            // pbTiposEnsambles
            // 
            pbTiposEnsambles.Image = (Image)resources.GetObject("pbTiposEnsambles.Image");
            pbTiposEnsambles.Location = new Point(350, 56);
            pbTiposEnsambles.Name = "pbTiposEnsambles";
            pbTiposEnsambles.Size = new Size(34, 35);
            pbTiposEnsambles.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTiposEnsambles.TabIndex = 28;
            pbTiposEnsambles.TabStop = false;
            // 
            // cbCaracteristica1
            // 
            cbCaracteristica1.BackColor = Color.FromArgb(13, 50, 76);
            cbCaracteristica1.FlatStyle = FlatStyle.Popup;
            cbCaracteristica1.Font = new Font("Segoe UI", 10.8F);
            cbCaracteristica1.ForeColor = Color.WhiteSmoke;
            cbCaracteristica1.FormattingEnabled = true;
            cbCaracteristica1.Location = new Point(414, 127);
            cbCaracteristica1.Name = "cbCaracteristica1";
            cbCaracteristica1.Size = new Size(365, 33);
            cbCaracteristica1.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(18, 29);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 27;
            label2.Text = "Tipo de uso:";
            // 
            // cbTipo1
            // 
            cbTipo1.BackColor = Color.FromArgb(13, 50, 76);
            cbTipo1.FlatStyle = FlatStyle.Popup;
            cbTipo1.Font = new Font("Segoe UI", 10.8F);
            cbTipo1.ForeColor = Color.WhiteSmoke;
            cbTipo1.FormattingEnabled = true;
            cbTipo1.Location = new Point(22, 127);
            cbTipo1.Name = "cbTipo1";
            cbTipo1.Size = new Size(365, 33);
            cbTipo1.TabIndex = 36;
            cbTipo1.SelectedIndexChanged += cbTipo1_SelectedIndexChanged;
            // 
            // cbTipoUso
            // 
            cbTipoUso.BackColor = Color.FromArgb(13, 50, 76);
            cbTipoUso.FlatStyle = FlatStyle.Popup;
            cbTipoUso.Font = new Font("Segoe UI", 10.8F);
            cbTipoUso.ForeColor = Color.WhiteSmoke;
            cbTipoUso.FormattingEnabled = true;
            cbTipoUso.Location = new Point(21, 56);
            cbTipoUso.Name = "cbTipoUso";
            cbTipoUso.Size = new Size(323, 33);
            cbTipoUso.TabIndex = 26;
            cbTipoUso.SelectedIndexChanged += cbTipoUso_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtHasta);
            groupBox2.Controls.Add(txtDesde);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 7.8F);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(12, 202);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(610, 102);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rango";
            // 
            // txtHasta
            // 
            txtHasta.BackColor = Color.FromArgb(13, 50, 76);
            txtHasta.BorderStyle = BorderStyle.None;
            txtHasta.Font = new Font("Segoe UI", 10.8F);
            txtHasta.ForeColor = Color.WhiteSmoke;
            txtHasta.Location = new Point(310, 55);
            txtHasta.Multiline = true;
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(268, 29);
            txtHasta.TabIndex = 38;
            // 
            // txtDesde
            // 
            txtDesde.BackColor = Color.FromArgb(13, 50, 76);
            txtDesde.BorderStyle = BorderStyle.None;
            txtDesde.Font = new Font("Segoe UI", 10.8F);
            txtDesde.ForeColor = Color.WhiteSmoke;
            txtDesde.Location = new Point(21, 55);
            txtDesde.Multiline = true;
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(268, 29);
            txtDesde.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(310, 27);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 35;
            label4.Text = "Hasta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(18, 27);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 27;
            label6.Text = "Desde:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(7, 111, 178);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(813, 229);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(10, 0, 0, 0);
            btnEliminar.Size = new Size(177, 57);
            btnEliminar.TabIndex = 45;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(7, 111, 178);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(628, 229);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 0, 0, 0);
            btnGuardar.Size = new Size(179, 57);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvCriterios
            // 
            dgvCriterios.AllowUserToAddRows = false;
            dgvCriterios.AllowUserToDeleteRows = false;
            dgvCriterios.AllowUserToResizeColumns = false;
            dgvCriterios.AllowUserToResizeRows = false;
            dgvCriterios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCriterios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCriterios.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvCriterios.BorderStyle = BorderStyle.None;
            dgvCriterios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCriterios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCriterios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCriterios.ColumnHeadersHeight = 30;
            dgvCriterios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCriterios.EnableHeadersVisualStyles = false;
            dgvCriterios.GridColor = SystemColors.MenuBar;
            dgvCriterios.Location = new Point(12, 321);
            dgvCriterios.MultiSelect = false;
            dgvCriterios.Name = "dgvCriterios";
            dgvCriterios.ReadOnly = true;
            dgvCriterios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCriterios.RowHeadersVisible = false;
            dgvCriterios.RowHeadersWidth = 51;
            dgvCriterios.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvCriterios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCriterios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCriterios.Size = new Size(973, 207);
            dgvCriterios.TabIndex = 46;
            dgvCriterios.CellClick += dgvCriterios_CellClick;
            // 
            // MantenimientoCriteriosDeBusqueda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(997, 540);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGuardar);
            Controls.Add(dgvCriterios);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MantenimientoCriteriosDeBusqueda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Criterios de Busqueda";
            Load += MantenimientoTiposDeEnsambles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTiposEnsambles).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCriterios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pbTiposEnsambles;
        private Label label2;
        private ComboBox cbTipoUso;
        private Label label1;
        private Label label3;
        private ComboBox cbCaracteristica1;
        private ComboBox cbTipo1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label6;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView dgvCriterios;
    }
}