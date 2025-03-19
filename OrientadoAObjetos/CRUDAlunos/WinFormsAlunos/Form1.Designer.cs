namespace WinFormsAlunos
{
    partial class Form1
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
            txtIdAluno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeAluno = new TextBox();
            txtApelidoAluno = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            AlunosListBox = new ListBox();
            btnEditarAluno = new Button();
            lbl = new Label();
            btnApagarAluno = new Button();
            btnInscricao = new Button();
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            txtIdAluno.ForeColor = SystemColors.HotTrack;
            txtIdAluno.Location = new Point(229, 132);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(179, 31);
            txtIdAluno.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(50, 194);
            label1.Name = "label1";
            label1.Size = new Size(158, 23);
            label1.TabIndex = 2;
            label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(50, 251);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 3;
            label2.Text = "Apelido do aluno:";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            txtNomeAluno.ForeColor = SystemColors.HotTrack;
            txtNomeAluno.Location = new Point(229, 193);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(371, 31);
            txtNomeAluno.TabIndex = 4;
            // 
            // txtApelidoAluno
            // 
            txtApelidoAluno.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            txtApelidoAluno.ForeColor = SystemColors.HotTrack;
            txtApelidoAluno.Location = new Point(229, 250);
            txtApelidoAluno.Name = "txtApelidoAluno";
            txtApelidoAluno.Size = new Size(371, 31);
            txtApelidoAluno.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.HotTrack;
            btnCancelar.Location = new Point(488, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 67);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.HotTrack;
            btnGuardar.Location = new Point(352, 318);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 67);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AlunosListBox
            // 
            AlunosListBox.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            AlunosListBox.ForeColor = SystemColors.HotTrack;
            AlunosListBox.FormattingEnabled = true;
            AlunosListBox.ItemHeight = 23;
            AlunosListBox.Location = new Point(50, 404);
            AlunosListBox.Name = "AlunosListBox";
            AlunosListBox.Size = new Size(836, 142);
            AlunosListBox.TabIndex = 8;
            // 
            // btnEditarAluno
            // 
            btnEditarAluno.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnEditarAluno.ForeColor = SystemColors.HotTrack;
            btnEditarAluno.Location = new Point(926, 493);
            btnEditarAluno.Name = "btnEditarAluno";
            btnEditarAluno.Size = new Size(222, 65);
            btnEditarAluno.TabIndex = 10;
            btnEditarAluno.Text = "Editar aluno selecionado";
            btnEditarAluno.UseVisualStyleBackColor = true;
            btnEditarAluno.Click += btnEditarAluno_Click;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            lbl.ForeColor = SystemColors.HotTrack;
            lbl.Location = new Point(50, 132);
            lbl.Name = "lbl";
            lbl.Size = new Size(120, 23);
            lbl.TabIndex = 0;
            lbl.Text = "Id de aluno:";
            // 
            // btnApagarAluno
            // 
            btnApagarAluno.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnApagarAluno.ForeColor = SystemColors.HotTrack;
            btnApagarAluno.Location = new Point(926, 404);
            btnApagarAluno.Name = "btnApagarAluno";
            btnApagarAluno.Size = new Size(222, 67);
            btnApagarAluno.TabIndex = 9;
            btnApagarAluno.Text = "Apagar aluno selecionado";
            btnApagarAluno.UseVisualStyleBackColor = true;
            btnApagarAluno.Click += btnApagarAluno_Click;
            // 
            // btnInscricao
            // 
            btnInscricao.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnInscricao.ForeColor = SystemColors.HotTrack;
            btnInscricao.Location = new Point(926, 318);
            btnInscricao.Name = "btnInscricao";
            btnInscricao.Size = new Size(222, 67);
            btnInscricao.TabIndex = 11;
            btnInscricao.Text = "Inscrições";
            btnInscricao.UseVisualStyleBackColor = true;
            btnInscricao.Click += btnInscricao_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1215, 113);
            panel1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(497, 37);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 5;
            label3.Text = "Alunos";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 572);
            Controls.Add(panel1);
            Controls.Add(btnInscricao);
            Controls.Add(btnEditarAluno);
            Controls.Add(btnApagarAluno);
            Controls.Add(AlunosListBox);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtApelidoAluno);
            Controls.Add(txtNomeAluno);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdAluno);
            Controls.Add(lbl);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIdAluno;
        private Label label1;
        private Label label2;
        private TextBox txtNomeAluno;
        private TextBox txtApelidoAluno;
        private Button btnCancelar;
        private Button btnGuardar;
        private ListBox AlunosListBox;
        private Button btnEditarAluno;
        private Label lbl;
        private Button btnApagarAluno;
        private Button btnInscricao;
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}
