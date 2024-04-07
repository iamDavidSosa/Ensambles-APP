namespace BaseAPP.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pbCerrar = new PictureBox();
            label2 = new Label();
            txt_usuario = new TextBox();
            label7 = new Label();
            label1 = new Label();
            txt_clave = new TextBox();
            btnEnter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(13, 50, 76);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pbCerrar
            // 
            pbCerrar.Image = (Image)resources.GetObject("pbCerrar.Image");
            pbCerrar.Location = new Point(737, 0);
            pbCerrar.Name = "pbCerrar";
            pbCerrar.Size = new Size(32, 32);
            pbCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrar.TabIndex = 3;
            pbCerrar.TabStop = false;
            pbCerrar.Click += pbCerrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(489, 69);
            label2.Name = "label2";
            label2.Size = new Size(254, 38);
            label2.TabIndex = 5;
            label2.Text = "INICIO DE SESIÓN";
            // 
            // txt_usuario
            // 
            txt_usuario.BackColor = SystemColors.InactiveCaption;
            txt_usuario.BorderStyle = BorderStyle.None;
            txt_usuario.Font = new Font("Segoe UI", 12F);
            txt_usuario.ForeColor = Color.Black;
            txt_usuario.Location = new Point(489, 168);
            txt_usuario.Margin = new Padding(3, 3, 10, 3);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(258, 27);
            txt_usuario.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(482, 137);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 9;
            label7.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(482, 221);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 11;
            label1.Text = "Contraseña:";
            // 
            // txt_clave
            // 
            txt_clave.BackColor = SystemColors.InactiveCaption;
            txt_clave.BorderStyle = BorderStyle.None;
            txt_clave.Font = new Font("Segoe UI", 12F);
            txt_clave.ForeColor = Color.Black;
            txt_clave.Location = new Point(489, 252);
            txt_clave.Margin = new Padding(3, 3, 10, 3);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(258, 27);
            txt_clave.TabIndex = 10;
            txt_clave.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(7, 111, 178);
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEnter.Image = (Image)resources.GetObject("btnEnter.Image");
            btnEnter.ImageAlign = ContentAlignment.MiddleRight;
            btnEnter.Location = new Point(542, 347);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(146, 37);
            btnEnter.TabIndex = 12;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 33, 50);
            ClientSize = new Size(769, 456);
            Controls.Add(btnEnter);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(label7);
            Controls.Add(txt_usuario);
            Controls.Add(label2);
            Controls.Add(pbCerrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbCerrar;
        private Label label2;
        private TextBox txt_usuario;
        private Label label7;
        private Label label1;
        private TextBox txt_clave;
        private Button btnEnter;
    }
}