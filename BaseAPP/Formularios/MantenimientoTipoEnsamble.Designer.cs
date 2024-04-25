namespace BaseAPP.Formularios
{
    partial class MantenimientoTipoEnsamble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoTipoEnsamble));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtTipoEnsamble = new TextBox();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            btnEliminar = new Button();
            label8 = new Label();
            btnLimpiar = new Button();
            dgvEnsambles = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnsambles).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(361, 21);
            label9.Name = "label9";
            label9.Size = new Size(256, 23);
            label9.TabIndex = 56;
            label9.Text = "Listado de tipos de ensambles:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTipoEnsamble);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 413);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de tipos ensambles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(132, 23);
            label2.TabIndex = 43;
            label2.Text = "Tipo ensamble:";
            // 
            // txtTipoEnsamble
            // 
            txtTipoEnsamble.BackColor = Color.FromArgb(13, 50, 76);
            txtTipoEnsamble.BorderStyle = BorderStyle.None;
            txtTipoEnsamble.Font = new Font("Segoe UI", 10.8F);
            txtTipoEnsamble.ForeColor = Color.WhiteSmoke;
            txtTipoEnsamble.Location = new Point(18, 55);
            txtTipoEnsamble.Multiline = true;
            txtTipoEnsamble.Name = "txtTipoEnsamble";
            txtTipoEnsamble.Size = new Size(301, 29);
            txtTipoEnsamble.TabIndex = 48;
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
            // dgvEnsambles
            // 
            dgvEnsambles.AllowUserToAddRows = false;
            dgvEnsambles.AllowUserToDeleteRows = false;
            dgvEnsambles.AllowUserToResizeColumns = false;
            dgvEnsambles.AllowUserToResizeRows = false;
            dgvEnsambles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEnsambles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEnsambles.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvEnsambles.BorderStyle = BorderStyle.None;
            dgvEnsambles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEnsambles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEnsambles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEnsambles.ColumnHeadersHeight = 30;
            dgvEnsambles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEnsambles.EnableHeadersVisualStyles = false;
            dgvEnsambles.GridColor = SystemColors.MenuBar;
            dgvEnsambles.Location = new Point(361, 56);
            dgvEnsambles.MultiSelect = false;
            dgvEnsambles.Name = "dgvEnsambles";
            dgvEnsambles.ReadOnly = true;
            dgvEnsambles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEnsambles.RowHeadersVisible = false;
            dgvEnsambles.RowHeadersWidth = 51;
            dgvEnsambles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvEnsambles.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvEnsambles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEnsambles.Size = new Size(467, 369);
            dgvEnsambles.TabIndex = 54;
            dgvEnsambles.CellClick += dgvEnsambles_CellClick;
            // 
            // MantenimientoTipoEnsamble
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(840, 437);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(dgvEnsambles);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MantenimientoTipoEnsamble";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento Tipo Ensamble";
            Load += MantenimientoTipoEnsamble_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEnsambles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtTipoEnsamble;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Button btnEliminar;
        private Label label8;
        private Button btnLimpiar;
        private DataGridView dgvEnsambles;
    }
}