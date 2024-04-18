namespace BaseAPP.Formularios
{
    partial class GeneradorEnsambles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneradorEnsambles));
            groupBox1 = new GroupBox();
            pbTiposEnsambles = new PictureBox();
            label2 = new Label();
            cbTipoEnsamble = new ComboBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            textBox1 = new TextBox();
            txtModelo = new TextBox();
            label3 = new Label();
            label1 = new Label();
            gbComponentes = new GroupBox();
            checkBox8 = new CheckBox();
            comboBox7 = new ComboBox();
            label11 = new Label();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            comboBox4 = new ComboBox();
            label8 = new Label();
            comboBox5 = new ComboBox();
            label9 = new Label();
            comboBox6 = new ComboBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            cbEspecificar = new CheckBox();
            btnEnsamble = new Button();
            groupBox4 = new GroupBox();
            label12 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTiposEnsambles).BeginInit();
            groupBox2.SuspendLayout();
            gbComponentes.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbTiposEnsambles);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbTipoEnsamble);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de ensamble";
            // 
            // pbTiposEnsambles
            // 
            pbTiposEnsambles.Image = (Image)resources.GetObject("pbTiposEnsambles.Image");
            pbTiposEnsambles.Location = new Point(445, 59);
            pbTiposEnsambles.Name = "pbTiposEnsambles";
            pbTiposEnsambles.Size = new Size(34, 35);
            pbTiposEnsambles.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTiposEnsambles.TabIndex = 28;
            pbTiposEnsambles.TabStop = false;
            pbTiposEnsambles.Click += pbTiposEnsambles_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 27;
            label2.Text = "Uso especifico:";
            // 
            // cbTipoEnsamble
            // 
            cbTipoEnsamble.BackColor = Color.FromArgb(13, 50, 76);
            cbTipoEnsamble.FlatStyle = FlatStyle.Popup;
            cbTipoEnsamble.Font = new Font("Segoe UI", 10.8F);
            cbTipoEnsamble.ForeColor = Color.WhiteSmoke;
            cbTipoEnsamble.FormattingEnabled = true;
            cbTipoEnsamble.Location = new Point(21, 61);
            cbTipoEnsamble.Name = "cbTipoEnsamble";
            cbTipoEnsamble.Size = new Size(418, 33);
            cbTipoEnsamble.TabIndex = 26;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtModelo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(12, 142);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(538, 117);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Presupuesto estimado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(240, 51);
            label4.Name = "label4";
            label4.Size = new Size(24, 38);
            label4.TabIndex = 32;
            label4.Text = ":";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(13, 50, 76);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 10.8F);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(268, 59);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 29);
            textBox1.TabIndex = 31;
            // 
            // txtModelo
            // 
            txtModelo.BackColor = Color.FromArgb(13, 50, 76);
            txtModelo.BorderStyle = BorderStyle.None;
            txtModelo.Font = new Font("Segoe UI", 10.8F);
            txtModelo.ForeColor = Color.WhiteSmoke;
            txtModelo.Location = new Point(21, 59);
            txtModelo.Multiline = true;
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(211, 29);
            txtModelo.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(265, 30);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 29;
            label3.Text = "Máximo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(18, 30);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 28;
            label1.Text = "Mínimo:";
            // 
            // gbComponentes
            // 
            gbComponentes.Controls.Add(checkBox8);
            gbComponentes.Controls.Add(comboBox7);
            gbComponentes.Controls.Add(label11);
            gbComponentes.Controls.Add(checkBox7);
            gbComponentes.Controls.Add(checkBox6);
            gbComponentes.Controls.Add(checkBox5);
            gbComponentes.Controls.Add(checkBox4);
            gbComponentes.Controls.Add(checkBox3);
            gbComponentes.Controls.Add(checkBox2);
            gbComponentes.Controls.Add(comboBox4);
            gbComponentes.Controls.Add(label8);
            gbComponentes.Controls.Add(comboBox5);
            gbComponentes.Controls.Add(label9);
            gbComponentes.Controls.Add(comboBox6);
            gbComponentes.Controls.Add(label10);
            gbComponentes.Controls.Add(comboBox3);
            gbComponentes.Controls.Add(label7);
            gbComponentes.Controls.Add(comboBox2);
            gbComponentes.Controls.Add(label6);
            gbComponentes.Controls.Add(comboBox1);
            gbComponentes.Controls.Add(label5);
            gbComponentes.Enabled = false;
            gbComponentes.ForeColor = SystemColors.ControlLight;
            gbComponentes.Location = new Point(12, 307);
            gbComponentes.Name = "gbComponentes";
            gbComponentes.Size = new Size(538, 328);
            gbComponentes.TabIndex = 2;
            gbComponentes.TabStop = false;
            gbComponentes.Text = "Componentes especificos";
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.ForeColor = SystemColors.ButtonFace;
            checkBox8.Location = new Point(244, 282);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(18, 17);
            checkBox8.TabIndex = 47;
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            comboBox7.BackColor = Color.FromArgb(13, 50, 76);
            comboBox7.FlatStyle = FlatStyle.Popup;
            comboBox7.Font = new Font("Segoe UI", 10.8F);
            comboBox7.ForeColor = Color.WhiteSmoke;
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(22, 272);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(211, 33);
            comboBox7.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.LightGray;
            label11.Location = new Point(18, 243);
            label11.Name = "label11";
            label11.Size = new Size(116, 23);
            label11.TabIndex = 46;
            label11.Text = "Power supply:";
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.ForeColor = SystemColors.ButtonFace;
            checkBox7.Location = new Point(503, 213);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(18, 17);
            checkBox7.TabIndex = 44;
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.ForeColor = SystemColors.ButtonFace;
            checkBox6.Location = new Point(503, 141);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(18, 17);
            checkBox6.TabIndex = 43;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.ForeColor = SystemColors.ButtonFace;
            checkBox5.Location = new Point(503, 70);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(18, 17);
            checkBox5.TabIndex = 42;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.ForeColor = SystemColors.ButtonFace;
            checkBox4.Location = new Point(244, 213);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(18, 17);
            checkBox4.TabIndex = 41;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.ForeColor = SystemColors.ButtonFace;
            checkBox3.Location = new Point(244, 141);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(18, 17);
            checkBox3.TabIndex = 40;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(244, 70);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(18, 17);
            checkBox2.TabIndex = 5;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.FromArgb(13, 50, 76);
            comboBox4.FlatStyle = FlatStyle.Popup;
            comboBox4.Font = new Font("Segoe UI", 10.8F);
            comboBox4.ForeColor = Color.WhiteSmoke;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(281, 203);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(211, 33);
            comboBox4.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(277, 174);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 39;
            label8.Text = "Case:";
            // 
            // comboBox5
            // 
            comboBox5.BackColor = Color.FromArgb(13, 50, 76);
            comboBox5.FlatStyle = FlatStyle.Popup;
            comboBox5.Font = new Font("Segoe UI", 10.8F);
            comboBox5.ForeColor = Color.WhiteSmoke;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(281, 131);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(211, 33);
            comboBox5.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGray;
            label9.Location = new Point(277, 102);
            label9.Name = "label9";
            label9.Size = new Size(121, 23);
            label9.TabIndex = 37;
            label9.Text = "Tarjeta gráfica:";
            // 
            // comboBox6
            // 
            comboBox6.BackColor = Color.FromArgb(13, 50, 76);
            comboBox6.FlatStyle = FlatStyle.Popup;
            comboBox6.Font = new Font("Segoe UI", 10.8F);
            comboBox6.ForeColor = Color.WhiteSmoke;
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(280, 60);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(211, 33);
            comboBox6.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.LightGray;
            label10.Location = new Point(276, 31);
            label10.Name = "label10";
            label10.Size = new Size(225, 23);
            label10.TabIndex = 35;
            label10.Text = "Unidad de almacenamiento:";
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(13, 50, 76);
            comboBox3.FlatStyle = FlatStyle.Popup;
            comboBox3.Font = new Font("Segoe UI", 10.8F);
            comboBox3.ForeColor = Color.WhiteSmoke;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(22, 203);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(211, 33);
            comboBox3.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(18, 174);
            label7.Name = "label7";
            label7.Size = new Size(126, 23);
            label7.TabIndex = 33;
            label7.Text = "Memoria RAM:";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(13, 50, 76);
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.Font = new Font("Segoe UI", 10.8F);
            comboBox2.ForeColor = Color.WhiteSmoke;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(22, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(211, 33);
            comboBox2.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(18, 102);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 31;
            label6.Text = "Procesador:";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(13, 50, 76);
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.Font = new Font("Segoe UI", 10.8F);
            comboBox1.ForeColor = Color.WhiteSmoke;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 33);
            comboBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(17, 31);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 29;
            label5.Text = "Motherboard:";
            // 
            // cbEspecificar
            // 
            cbEspecificar.AutoSize = true;
            cbEspecificar.ForeColor = SystemColors.ButtonFace;
            cbEspecificar.Location = new Point(17, 274);
            cbEspecificar.Name = "cbEspecificar";
            cbEspecificar.Size = new Size(196, 24);
            cbEspecificar.TabIndex = 3;
            cbEspecificar.Text = "Especificar componentes";
            cbEspecificar.UseVisualStyleBackColor = true;
            cbEspecificar.CheckedChanged += cbEspecificar_CheckedChanged;
            // 
            // btnEnsamble
            // 
            btnEnsamble.BackColor = Color.FromArgb(7, 111, 178);
            btnEnsamble.FlatStyle = FlatStyle.Popup;
            btnEnsamble.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEnsamble.ForeColor = SystemColors.ControlLight;
            btnEnsamble.Image = (Image)resources.GetObject("btnEnsamble.Image");
            btnEnsamble.ImageAlign = ContentAlignment.MiddleLeft;
            btnEnsamble.Location = new Point(142, 646);
            btnEnsamble.Name = "btnEnsamble";
            btnEnsamble.Padding = new Padding(20, 0, 0, 0);
            btnEnsamble.Size = new Size(268, 39);
            btnEnsamble.TabIndex = 4;
            btnEnsamble.Text = "Generar Ensamble";
            btnEnsamble.UseVisualStyleBackColor = false;
            btnEnsamble.Click += btnEnsamble_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label12);
            groupBox4.ForeColor = SystemColors.ControlLight;
            groupBox4.Location = new Point(584, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(538, 623);
            groupBox4.TabIndex = 29;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ensamble";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.LightGray;
            label12.Location = new Point(16, 30);
            label12.Name = "label12";
            label12.Size = new Size(165, 23);
            label12.TabIndex = 29;
            label12.Text = "Ensamble generado:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 111, 178);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ControlLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(727, 646);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(268, 39);
            button1.TabIndex = 30;
            button1.Text = "Imprimir cotización";
            button1.UseVisualStyleBackColor = false;
            // 
            // GeneradorEnsambles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(1153, 697);
            Controls.Add(button1);
            Controls.Add(groupBox4);
            Controls.Add(btnEnsamble);
            Controls.Add(cbEspecificar);
            Controls.Add(gbComponentes);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GeneradorEnsambles";
            Text = "GeneradorEnsambles";
            Load += GeneradorEnsambles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTiposEnsambles).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbComponentes.ResumeLayout(false);
            gbComponentes.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox gbComponentes;
        private CheckBox cbEspecificar;
        private Button btnEnsamble;
        private ComboBox cbTipoEnsamble;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtModelo;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pbTiposEnsambles;
        private ComboBox comboBox3;
        private Label label7;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private ComboBox comboBox4;
        private Label label8;
        private ComboBox comboBox5;
        private Label label9;
        private ComboBox comboBox6;
        private Label label10;
        private CheckBox checkBox8;
        private ComboBox comboBox7;
        private Label label11;
        private GroupBox groupBox4;
        private Label label12;
        private Button button1;
    }
}