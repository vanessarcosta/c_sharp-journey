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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(19, 19);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemAluno, toolStripMenuItemDisciplina });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(706, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAluno
            // 
            toolStripMenuItemAluno.Name = "toolStripMenuItemAluno";
            toolStripMenuItemAluno.Size = new Size(62, 24);
            toolStripMenuItemAluno.Text = "Aluno";
            toolStripMenuItemAluno.Click += toolStripMenuItemAluno_Click;
            // 
            // toolStripMenuItemDisciplina
            // 
            toolStripMenuItemDisciplina.Name = "toolStripMenuItemDisciplina";
            toolStripMenuItemDisciplina.Size = new Size(88, 24);
            toolStripMenuItemDisciplina.Text = "Disciplina";
            toolStripMenuItemDisciplina.Click += toolStripMenuItemDisciplina_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 353);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemAluno;
        private ToolStripMenuItem toolStripMenuItemDisciplina;
    }
}