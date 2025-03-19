namespace WinFormsAlunos
{
    partial class FrmInscricao
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
            CancelarMatricula = new Button();
            btnMatricular = new Button();
            DisciplinasListBox = new ListBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdAluno = new TextBox();
            txtNomeAluno = new TextBox();
            txtApelido = new TextBox();
            DisciplinasIncritasListBox = new ListBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CancelarMatricula
            // 
            CancelarMatricula.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarMatricula.ForeColor = SystemColors.HotTrack;
            CancelarMatricula.Location = new Point(838, 508);
            CancelarMatricula.Name = "CancelarMatricula";
            CancelarMatricula.Size = new Size(222, 72);
            CancelarMatricula.TabIndex = 24;
            CancelarMatricula.Text = "Cancelar matricula";
            CancelarMatricula.UseVisualStyleBackColor = true;
            CancelarMatricula.Click += CancelarMatricula_Click;
            // 
            // btnMatricular
            // 
            btnMatricular.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMatricular.ForeColor = SystemColors.HotTrack;
            btnMatricular.Location = new Point(838, 424);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(222, 78);
            btnMatricular.TabIndex = 23;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // DisciplinasListBox
            // 
            DisciplinasListBox.ForeColor = SystemColors.HotTrack;
            DisciplinasListBox.FormattingEnabled = true;
            DisciplinasListBox.Location = new Point(12, 424);
            DisciplinasListBox.Name = "DisciplinasListBox";
            DisciplinasListBox.Size = new Size(401, 156);
            DisciplinasListBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 382);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 26;
            label2.Text = "Selecione a disciplina :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(45, 305);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 27;
            label1.Text = "Apelido do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(45, 235);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 28;
            label3.Text = "Nome do aluno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(45, 173);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 29;
            label4.Text = "Id do aluno:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.ForeColor = SystemColors.HotTrack;
            txtIdAluno.Location = new Point(214, 172);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(263, 26);
            txtIdAluno.TabIndex = 30;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Enabled = false;
            txtNomeAluno.ForeColor = SystemColors.HotTrack;
            txtNomeAluno.Location = new Point(214, 237);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(488, 26);
            txtNomeAluno.TabIndex = 31;
            // 
            // txtApelido
            // 
            txtApelido.Enabled = false;
            txtApelido.ForeColor = SystemColors.HotTrack;
            txtApelido.Location = new Point(214, 304);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(488, 26);
            txtApelido.TabIndex = 32;
            // 
            // DisciplinasIncritasListBox
            // 
            DisciplinasIncritasListBox.ForeColor = SystemColors.HotTrack;
            DisciplinasIncritasListBox.FormattingEnabled = true;
            DisciplinasIncritasListBox.Location = new Point(431, 424);
            DisciplinasIncritasListBox.Name = "DisciplinasIncritasListBox";
            DisciplinasIncritasListBox.Size = new Size(401, 156);
            DisciplinasIncritasListBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(431, 347);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 34;
            label5.Text = "Disciplinas inscritas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(431, 382);
            label6.Name = "label6";
            label6.Size = new Size(459, 25);
            label6.TabIndex = 35;
            label6.Text = "Se quiser cancelar a matricula selecione a disciplina :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 113);
            panel1.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(473, 33);
            label7.Name = "label7";
            label7.Size = new Size(140, 30);
            label7.TabIndex = 5;
            label7.Text = "Inscrições";
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
            // FrmInscricao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 613);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(DisciplinasIncritasListBox);
            Controls.Add(txtApelido);
            Controls.Add(txtNomeAluno);
            Controls.Add(txtIdAluno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(DisciplinasListBox);
            Controls.Add(CancelarMatricula);
            Controls.Add(btnMatricular);
            Name = "FrmInscricao";
            Text = "Inscriçâo";
            FormClosing += FrmInscricao_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button CancelarMatricula;
        private Button btnMatricular;
        private ListBox DisciplinasListBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtIdAluno;
        private TextBox txtNomeAluno;
        private TextBox txtApelido;
        private ListBox DisciplinasIncritasListBox;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox2;
    }
}