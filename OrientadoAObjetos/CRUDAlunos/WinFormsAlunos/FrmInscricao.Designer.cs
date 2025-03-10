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
            SuspendLayout();
            // 
            // CancelarMatricula
            // 
            CancelarMatricula.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelarMatricula.Location = new Point(838, 399);
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
            btnMatricular.Location = new Point(838, 315);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(222, 78);
            btnMatricular.TabIndex = 23;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // DisciplinasListBox
            // 
            DisciplinasListBox.FormattingEnabled = true;
            DisciplinasListBox.Location = new Point(12, 315);
            DisciplinasListBox.Name = "DisciplinasListBox";
            DisciplinasListBox.Size = new Size(401, 156);
            DisciplinasListBox.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 273);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 26;
            label2.Text = "Selecione a disciplina :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 196);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 27;
            label1.Text = "Apelido do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 126);
            label3.Name = "label3";
            label3.Size = new Size(148, 25);
            label3.TabIndex = 28;
            label3.Text = "Nome do aluno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 64);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 29;
            label4.Text = "Id do aluno:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Location = new Point(214, 63);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(263, 26);
            txtIdAluno.TabIndex = 30;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Enabled = false;
            txtNomeAluno.Location = new Point(214, 128);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(488, 26);
            txtNomeAluno.TabIndex = 31;
            // 
            // txtApelido
            // 
            txtApelido.Enabled = false;
            txtApelido.Location = new Point(214, 195);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(488, 26);
            txtApelido.TabIndex = 32;
            // 
            // DisciplinasIncritasListBox
            // 
            DisciplinasIncritasListBox.FormattingEnabled = true;
            DisciplinasIncritasListBox.Location = new Point(431, 315);
            DisciplinasIncritasListBox.Name = "DisciplinasIncritasListBox";
            DisciplinasIncritasListBox.Size = new Size(401, 156);
            DisciplinasIncritasListBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(431, 238);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 34;
            label5.Text = "Disciplinas inscritas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(431, 273);
            label6.Name = "label6";
            label6.Size = new Size(459, 25);
            label6.TabIndex = 35;
            label6.Text = "Se quiser cancelar a matricula selecione a disciplina :";
            // 
            // FrmInscricao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 483);
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
    }
}