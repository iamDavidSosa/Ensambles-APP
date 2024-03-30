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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            btnEnter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(737, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(489, 168);
            textBox1.Margin = new Padding(3, 6, 3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 28);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(489, 137);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 9;
            label7.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(489, 221);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 11;
            label1.Text = "Contraseña:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(489, 252);
            textBox2.Margin = new Padding(3, 6, 3, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 28);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.InactiveCaption;
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
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label7;
        private Label label1;
        private TextBox textBox2;
        private Button btnEnter;
    }
}