namespace BaseAPP.Formularios
{
    partial class VistaEnsamblesGenerados
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
            label2 = new Label();
            dgvEnsambles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEnsambles).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(21, 23);
            label2.Name = "label2";
            label2.Size = new Size(179, 23);
            label2.TabIndex = 28;
            label2.Text = "Ensambles generados:";
            // 
            // dgvEnsambles
            // 
            dgvEnsambles.AllowUserToAddRows = false;
            dgvEnsambles.AllowUserToDeleteRows = false;
            dgvEnsambles.AllowUserToResizeColumns = false;
            dgvEnsambles.AllowUserToResizeRows = false;
            dgvEnsambles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEnsambles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvEnsambles.Location = new Point(21, 60);
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
            dgvEnsambles.Size = new Size(1234, 535);
            dgvEnsambles.TabIndex = 52;
            // 
            // VistaEnsamblesGenerados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 46, 70);
            ClientSize = new Size(1283, 625);
            Controls.Add(dgvEnsambles);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VistaEnsamblesGenerados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista Ensambles Generados";
            Load += VistaEnsamblesGenerados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEnsambles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dgvEnsambles;
    }
}