namespace BaseAPP.Formularios
{
    partial class MantenimientoMarcas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMarcas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtMarca = new TextBox();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            btnEliminar = new Button();
            label8 = new Label();
            btnLimpiar = new Button();
            dgvMarcas = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(361, 21);
            label9.Name = "label9";
            label9.Size = new Size(154, 23);
            label9.TabIndex = 53;
            label9.Text = "Listado demarcas:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 413);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de tipos marcas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 43;
            label2.Text = "Marca:";
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(13, 50, 76);
            txtMarca.BorderStyle = BorderStyle.None;
            txtMarca.Font = new Font("Segoe UI", 10.8F);
            txtMarca.ForeColor = Color.WhiteSmoke;
            txtMarca.Location = new Point(18, 55);
            txtMarca.Multiline = true;
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(301, 29);
            txtMarca.TabIndex = 48;
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
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(13, 50, 76);
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI", 10.8F);
            txtDescripcion.ForeColor = Color.WhiteSmoke;
            txtDescripcion.Location = new Point(18, 125);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(301, 123);
            txtDescripcion.TabIndex = 47;
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
            // dgvMarcas
            // 
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.AllowUserToDeleteRows = false;
            dgvMarcas.AllowUserToResizeColumns = false;
            dgvMarcas.AllowUserToResizeRows = false;
            dgvMarcas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMarcas.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvMarcas.BorderStyle = BorderStyle.None;
            dgvMarcas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMarcas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMarcas.ColumnHeadersHeight = 30;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMarcas.EnableHeadersVisualStyles = false;
            dgvMarcas.GridColor = SystemColors.MenuBar;
            dgvMarcas.Location = new Point(361, 56);
            dgvMarcas.MultiSelect = false;
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.ReadOnly = true;
            dgvMarcas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMarcas.RowHeadersVisible = false;
            dgvMarcas.RowHeadersWidth = 51;
            dgvMarcas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvMarcas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.Size = new Size(467, 369);
            dgvMarcas.TabIndex = 51;
            dgvMarcas.CellClick += dgvMarcas_CellClick;
            // 
            // MantenimientoMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(840, 437);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(dgvMarcas);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MantenimientoMarcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Marcas";
            Load += MantenimientoMarcas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtMarca;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Label label8;
        private Button btnLimpiar;
        private DataGridView dgvMarcas;
    }
}