namespace WinFormsAlunos
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItemAluno = new ToolStripMenuItem();
            toolStripMenuItemDisciplina = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Century Gothic", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemAluno, toolStripMenuItemDisciplina });
            menuStrip1.Location = new Point(352, 241);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(482, 108);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAluno
            // 
            toolStripMenuItemAluno.BackgroundImageLayout = ImageLayout.None;
            toolStripMenuItemAluno.Font = new Font("Century Gothic", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItemAluno.ForeColor = SystemColors.HotTrack;
            toolStripMenuItemAluno.Image = Properties.Resources.icons8_estudantes_100;
            toolStripMenuItemAluno.ImageAlign = ContentAlignment.MiddleLeft;
            toolStripMenuItemAluno.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemAluno.ImageTransparentColor = Color.White;
            toolStripMenuItemAluno.Name = "toolStripMenuItemAluno";
            toolStripMenuItemAluno.Size = new Size(210, 104);
            toolStripMenuItemAluno.Text = "Aluno";
            toolStripMenuItemAluno.Click += toolStripMenuItemAluno_Click;
            // 
            // toolStripMenuItemDisciplina
            // 
            toolStripMenuItemDisciplina.ForeColor = SystemColors.HotTrack;
            toolStripMenuItemDisciplina.Image = Properties.Resources.icons8_livros_100;
            toolStripMenuItemDisciplina.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemDisciplina.Name = "toolStripMenuItemDisciplina";
            toolStripMenuItemDisciplina.Size = new Size(264, 104);
            toolStripMenuItemDisciplina.Text = "Disciplina";
            toolStripMenuItemDisciplina.Click += toolStripMenuItemDisciplina_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 113);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(497, 37);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 5;
            label2.Text = "Escola da Luz";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_escola_100__1_;
            pictureBox2.Location = new Point(36, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Century Gothic", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Location = new Point(200, 200);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemAluno;
        private ToolStripMenuItem toolStripMenuItemDisciplina;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}