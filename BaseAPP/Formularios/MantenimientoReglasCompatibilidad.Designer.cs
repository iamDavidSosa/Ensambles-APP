namespace BaseAPP.Formularios
{
    partial class MantenimientoReglasCompatibilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoReglasCompatibilidad));
            cbCaracteristica2 = new ComboBox();
            cbCaracteristica1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            cbTipo1 = new ComboBox();
            label1 = new Label();
            cbTipo2 = new ComboBox();
            label4 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            label5 = new Label();
            cbOperador = new ComboBox();
            label6 = new Label();
            dgvReglas = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).BeginInit();
            SuspendLayout();
            // 
            // cbCaracteristica2
            // 
            cbCaracteristica2.BackColor = Color.FromArgb(13, 50, 76);
            cbCaracteristica2.FlatStyle = FlatStyle.Popup;
            cbCaracteristica2.Font = new Font("Segoe UI", 10.8F);
            cbCaracteristica2.ForeColor = Color.WhiteSmoke;
            cbCaracteristica2.FormattingEnabled = true;
            cbCaracteristica2.Location = new Point(578, 117);
            cbCaracteristica2.Name = "cbCaracteristica2";
            cbCaracteristica2.Size = new Size(361, 33);
            cbCaracteristica2.TabIndex = 30;
            // 
            // cbCaracteristica1
            // 
            cbCaracteristica1.BackColor = Color.FromArgb(13, 50, 76);
            cbCaracteristica1.FlatStyle = FlatStyle.Popup;
            cbCaracteristica1.Font = new Font("Segoe UI", 10.8F);
            cbCaracteristica1.ForeColor = Color.WhiteSmoke;
            cbCaracteristica1.FormattingEnabled = true;
            cbCaracteristica1.Location = new Point(16, 117);
            cbCaracteristica1.Name = "cbCaracteristica1";
            cbCaracteristica1.Size = new Size(365, 33);
            cbCaracteristica1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(574, 91);
            label3.Name = "label3";
            label3.Size = new Size(138, 23);
            label3.TabIndex = 28;
            label3.Text = "Caracteristica 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(138, 23);
            label2.TabIndex = 27;
            label2.Text = "Caracteristica 1:";
            // 
            // cbTipo1
            // 
            cbTipo1.BackColor = Color.FromArgb(13, 50, 76);
            cbTipo1.FlatStyle = FlatStyle.Popup;
            cbTipo1.Font = new Font("Segoe UI", 10.8F);
            cbTipo1.ForeColor = Color.WhiteSmoke;
            cbTipo1.FormattingEnabled = true;
            cbTipo1.Location = new Point(16, 51);
            cbTipo1.Name = "cbTipo1";
            cbTipo1.Size = new Size(365, 33);
            cbTipo1.TabIndex = 32;
            cbTipo1.SelectedIndexChanged += cbTipo1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 31;
            label1.Text = "Tipo de componente 1:";
            // 
            // cbTipo2
            // 
            cbTipo2.BackColor = Color.FromArgb(13, 50, 76);
            cbTipo2.FlatStyle = FlatStyle.Popup;
            cbTipo2.Font = new Font("Segoe UI", 10.8F);
            cbTipo2.ForeColor = Color.WhiteSmoke;
            cbTipo2.FormattingEnabled = true;
            cbTipo2.Location = new Point(578, 51);
            cbTipo2.Name = "cbTipo2";
            cbTipo2.Size = new Size(361, 33);
            cbTipo2.TabIndex = 34;
            cbTipo2.SelectedIndexChanged += cbTipo2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(574, 25);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 33;
            label4.Text = "Tipo de componente 2:";
            // 
            // txtValor1
            // 
            txtValor1.BackColor = Color.FromArgb(13, 50, 76);
            txtValor1.BorderStyle = BorderStyle.None;
            txtValor1.Font = new Font("Segoe UI", 10.8F);
            txtValor1.ForeColor = Color.WhiteSmoke;
            txtValor1.Location = new Point(16, 183);
            txtValor1.Multiline = true;
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(365, 29);
            txtValor1.TabIndex = 36;
            // 
            // txtValor2
            // 
            txtValor2.BackColor = Color.FromArgb(13, 50, 76);
            txtValor2.BorderStyle = BorderStyle.None;
            txtValor2.Font = new Font("Segoe UI", 10.8F);
            txtValor2.ForeColor = Color.WhiteSmoke;
            txtValor2.Location = new Point(578, 183);
            txtValor2.Multiline = true;
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(361, 29);
            txtValor2.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(574, 157);
            label5.Name = "label5";
            label5.Size = new Size(57, 23);
            label5.TabIndex = 37;
            label5.Text = "Valor:";
            // 
            // cbOperador
            // 
            cbOperador.BackColor = Color.FromArgb(13, 50, 76);
            cbOperador.FlatStyle = FlatStyle.Popup;
            cbOperador.Font = new Font("Segoe UI", 10.8F);
            cbOperador.ForeColor = Color.WhiteSmoke;
            cbOperador.FormattingEnabled = true;
            cbOperador.Items.AddRange(new object[] { "=", ">", "<" });
            cbOperador.Location = new Point(416, 101);
            cbOperador.Name = "cbOperador";
            cbOperador.Size = new Size(125, 33);
            cbOperador.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(429, 75);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 40;
            label6.Text = "Operador:";
            // 
            // dgvReglas
            // 
            dgvReglas.AllowUserToAddRows = false;
            dgvReglas.AllowUserToDeleteRows = false;
            dgvReglas.AllowUserToResizeColumns = false;
            dgvReglas.AllowUserToResizeRows = false;
            dgvReglas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReglas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReglas.BackgroundColor = Color.FromArgb(11, 33, 50);
            dgvReglas.BorderStyle = BorderStyle.None;
            dgvReglas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReglas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(7, 111, 178);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReglas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReglas.ColumnHeadersHeight = 30;
            dgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvReglas.EnableHeadersVisualStyles = false;
            dgvReglas.GridColor = SystemColors.MenuBar;
            dgvReglas.Location = new Point(18, 300);
            dgvReglas.MultiSelect = false;
            dgvReglas.Name = "dgvReglas";
            dgvReglas.ReadOnly = true;
            dgvReglas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReglas.RowHeadersVisible = false;
            dgvReglas.RowHeadersWidth = 51;
            dgvReglas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(13, 50, 76);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(14, 95, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvReglas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReglas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReglas.Size = new Size(1123, 374);
            dgvReglas.TabIndex = 41;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(7, 111, 178);
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEliminar.ForeColor = SystemColors.ControlLight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(204, 239);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(20, 0, 0, 0);
            btnEliminar.Size = new Size(177, 39);
            btnEliminar.TabIndex = 43;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(7, 111, 178);
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGuardar.ForeColor = SystemColors.ControlLight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(16, 239);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(20, 0, 0, 0);
            btnGuardar.Size = new Size(179, 39);
            btnGuardar.TabIndex = 42;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(12, 157);
            label7.Name = "label7";
            label7.Size = new Size(57, 23);
            label7.TabIndex = 44;
            label7.Text = "Valor:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(7, 111, 178);
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnLimpiar.ForeColor = SystemColors.ControlLight;
            btnLimpiar.Image = (Image)resources.GetObject("btnLimpiar.Image");
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(389, 239);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(20, 0, 0, 0);
            btnLimpiar.Size = new Size(177, 39);
            btnLimpiar.TabIndex = 45;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // MantenimientoReglasCompatibilidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(1153, 697);
            Controls.Add(btnLimpiar);
            Controls.Add(label7);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvReglas);
            Controls.Add(label6);
            Controls.Add(cbOperador);
            Controls.Add(txtValor2);
            Controls.Add(label5);
            Controls.Add(txtValor1);
            Controls.Add(cbTipo2);
            Controls.Add(label4);
            Controls.Add(cbTipo1);
            Controls.Add(label1);
            Controls.Add(cbCaracteristica2);
            Controls.Add(cbCaracteristica1);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MantenimientoReglasCompatibilidad";
            Text = "MantenimientoReglasCompatibilidad";
            Load += MantenimientoReglasCompatibilidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReglas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCaracteristica2;
        private ComboBox cbCaracteristica1;
        private Label label3;
        private Label label2;
        private ComboBox cbTipo1;
        private Label label1;
        private ComboBox cbTipo2;
        private Label label4;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label label5;
        private ComboBox cbOperador;
        private Label label6;
        private DataGridView dgvReglas;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label label7;
        private Button btnLimpiar;
    }
}