namespace BaseAPP
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pSuperior = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pbSalir = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            button6 = new Button();
            btnInventario = new Button();
            button4 = new Button();
            btnReglas = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            pbTitulo = new PictureBox();
            lblTitulo = new Label();
            pnlPrincipal = new Panel();
            pSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).BeginInit();
            SuspendLayout();
            // 
            // pSuperior
            // 
            pSuperior.BackColor = Color.FromArgb(13, 50, 76);
            pSuperior.Controls.Add(label2);
            pSuperior.Controls.Add(pictureBox1);
            pSuperior.Controls.Add(label1);
            pSuperior.Controls.Add(pbSalir);
            pSuperior.Dock = DockStyle.Top;
            pSuperior.Location = new Point(0, 0);
            pSuperior.Name = "pSuperior";
            pSuperior.Size = new Size(1390, 47);
            pSuperior.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 4;
            label2.Text = "Base APP";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1319, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(1222, 13);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 3;
            label1.Text = "Cerrar Sesión";
            // 
            // pbSalir
            // 
            pbSalir.Image = (Image)resources.GetObject("pbSalir.Image");
            pbSalir.Location = new Point(1352, 8);
            pbSalir.Name = "pbSalir";
            pbSalir.Size = new Size(32, 32);
            pbSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSalir.TabIndex = 2;
            pbSalir.TabStop = false;
            pbSalir.Click += pbSalir_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(13, 50, 76);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btnInventario);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(btnReglas);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 738);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(66, 712);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 7;
            label6.Text = "Versión: 1.0.0";
            // 
            // button6
            // 
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.LightGray;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleRight;
            button6.Location = new Point(0, 417);
            button6.Name = "button6";
            button6.Padding = new Padding(8, 0, 25, 0);
            button6.Size = new Size(237, 60);
            button6.TabIndex = 6;
            button6.Text = "Configuración";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.TextBeforeImage;
            button6.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Dock = DockStyle.Top;
            btnInventario.FlatAppearance.BorderSize = 0;
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.LightGray;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageAlign = ContentAlignment.MiddleRight;
            btnInventario.Location = new Point(0, 357);
            btnInventario.Name = "btnInventario";
            btnInventario.Padding = new Padding(8, 0, 25, 0);
            btnInventario.Size = new Size(237, 60);
            btnInventario.TabIndex = 5;
            btnInventario.Text = "Inventario";
            btnInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnInventario.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.LightGray;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(0, 297);
            button4.Name = "button4";
            button4.Padding = new Padding(8, 0, 25, 0);
            button4.Size = new Size(237, 60);
            button4.TabIndex = 4;
            button4.Text = "Contabilidad";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnReglas
            // 
            btnReglas.Dock = DockStyle.Top;
            btnReglas.FlatAppearance.BorderSize = 0;
            btnReglas.FlatStyle = FlatStyle.Flat;
            btnReglas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReglas.ForeColor = Color.LightGray;
            btnReglas.Image = (Image)resources.GetObject("btnReglas.Image");
            btnReglas.ImageAlign = ContentAlignment.MiddleRight;
            btnReglas.Location = new Point(0, 237);
            btnReglas.Name = "btnReglas";
            btnReglas.Padding = new Padding(8, 0, 25, 0);
            btnReglas.Size = new Size(237, 60);
            btnReglas.TabIndex = 3;
            btnReglas.Text = "Soporte";
            btnReglas.TextAlign = ContentAlignment.MiddleLeft;
            btnReglas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReglas.UseVisualStyleBackColor = true;
            btnReglas.Click += btnReglas_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.LightGray;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 177);
            button2.Name = "button2";
            button2.Padding = new Padding(8, 0, 25, 0);
            button2.Size = new Size(237, 60);
            button2.TabIndex = 2;
            button2.Text = "Ventas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightGray;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(0, 117);
            button1.Name = "button1";
            button1.Padding = new Padding(8, 0, 25, 0);
            button1.Size = new Size(237, 60);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(13, 50, 76);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 117);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.ForeColor = Color.DarkGray;
            panel4.Location = new Point(9, 116);
            panel4.Name = "panel4";
            panel4.Size = new Size(220, 1);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 7;
            label5.Text = "MENÚ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(77, 39);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Administrador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(77, 16);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 5;
            label3.Text = "A. David Sosa";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(15, 46, 70);
            panel5.Controls.Add(pbTitulo);
            panel5.Controls.Add(lblTitulo);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(237, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(1153, 41);
            panel5.TabIndex = 2;
            // 
            // pbTitulo
            // 
            pbTitulo.Image = Properties.Resources.dashboardT;
            pbTitulo.Location = new Point(6, 2);
            pbTitulo.Name = "pbTitulo";
            pbTitulo.Size = new Size(37, 36);
            pbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTitulo.TabIndex = 0;
            pbTitulo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.LightGray;
            lblTitulo.Location = new Point(47, 6);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(114, 28);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Dashboard";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(237, 88);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1153, 697);
            pnlPrincipal.TabIndex = 3;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(1390, 785);
            Controls.Add(pnlPrincipal);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(pSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pSuperior.ResumeLayout(false);
            pSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSalir).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTitulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSuperior;
        private PictureBox pictureBox1;
        private PictureBox pbSalir;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label5;
        private Button button6;
        private Button btnInventario;
        private Button button4;
        private Button btnReglas;
        private Button button2;
        private Label label6;
        private Panel panel4;
        private Panel panel5;
        private Label lblTitulo;
        private Panel pnlPrincipal;
        private PictureBox pbTitulo;
    }
}
