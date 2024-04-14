namespace BaseAPP.Formularios
{
    partial class MantenimientoTiposComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoTiposComponentes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            txtDescripcion = new TextBox();
            label8 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            dgvTipos = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(13, 50, 76);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI", 10.8F);
            txtDescripcion.ForeColor = Color.WhiteSmoke;
            txtDescripcion.Location = new Point(18, 125);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(301, 121);
            txtDescripcion.TabIndex = 47;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(18, 94);
            label8.Name = "label8";
            label8.Size = new Size(108, 23);
            label8.TabIndex = 46;
            label8.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 43;
            label2.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(7, 111, 178);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnLimpiar.ForeColor = SystemColors.ControlLight;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(18, 355);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(20, 0, 0, 0);
            btnLimpiar.Size = new Size(301, 39);
            btnLimpiar.TabIndex = 42;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvTipos
            // 
            dgvTipos.AllowUserToAddRows = false;
            dgvTipos.AllowUserToDeleteRows = false;
            dgvTipos.AllowUserToResizeColumns = false;
            dgvTipos.AllowUserToResizeRows = false;
            dgvTipos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTipos.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvTipos.BorderStyle = BorderStyle.None;
            dgvTipos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTipos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTipos.ColumnHeadersHeight = 30;
            dgvTipos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTipos.EnableHeadersVisualStyles = false;
            dgvTipos.GridColor = SystemColors.MenuBar;
            dgvTipos.Location = new Point(361, 56);
            dgvTipos.MultiSelect = false;
            dgvTipos.Name = "dgvTipos";
            dgvTipos.ReadOnly = true;
            dgvTipos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTipos.RowHeadersVisible = false;
            dgvTipos.RowHeadersWidth = 51;
            dgvTipos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvTipos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvTipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipos.Size = new Size(467, 369);
            dgvTipos.TabIndex = 41;
            dgvTipos.CellClick += dgvTipos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(7, 111, 178);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(18, 310);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(20, 0, 0, 0);
            btnEliminar.Size = new Size(301, 39);
            btnEliminar.TabIndex = 40;
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
            btnGuardar.Location = new Point(18, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(20, 0, 0, 0);
            btnGuardar.Size = new Size(301, 39);
            btnGuardar.TabIndex = 39;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(13, 50, 76);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Segoe UI", 10.8F);
            txtNombre.ForeColor = Color.WhiteSmoke;
            txtNombre.Location = new Point(18, 55);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 29);
            txtNombre.TabIndex = 48;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 413);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de tipos de componentes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(361, 21);
            label9.Name = "label9";
            label9.Size = new Size(280, 23);
            label9.TabIndex = 50;
            label9.Text = "Listado de tipos de componentes:";
            // 
            // MantenimientoTiposComponentes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(840, 437);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(dgvTipos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MantenimientoTiposComponentes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Tipos de Componentes";
            Load += MantenimientoTiposComponentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label8;
        private Label label2;
        private Button btnLimpiar;
        private DataGridView dgvTipos;
        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtNombre;
        private GroupBox groupBox1;
        private Label label9;
    }
}