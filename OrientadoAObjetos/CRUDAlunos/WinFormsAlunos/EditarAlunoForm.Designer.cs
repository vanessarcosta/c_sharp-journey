namespace WinFormsAlunos
{
    partial class EditarAlunoForm
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
            txtIdAluno = new TextBox();
            txtNomeAluno = new TextBox();
            txtApelido = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.ForeColor = SystemColors.HotTrack;
            txtIdAluno.Location = new Point(232, 165);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(263, 26);
            txtIdAluno.TabIndex = 0;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.ForeColor = SystemColors.HotTrack;
            txtNomeAluno.Location = new Point(232, 235);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(644, 26);
            txtNomeAluno.TabIndex = 1;
            // 
            // txtApelido
            // 
            txtApelido.ForeColor = SystemColors.HotTrack;
            txtApelido.Location = new Point(232, 302);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(644, 26);
            txtApelido.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.HotTrack;
            btnCancelar.Location = new Point(771, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 61);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.HotTrack;
            btnGuardar.Location = new Point(622, 369);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 61);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(36, 303);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 6;
            label2.Text = "Apelido do aluno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(36, 233);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 7;
            label1.Text = "Nome do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(36, 163);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 8;
            label3.Text = "Id do aluno:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 113);
            panel1.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(394, 33);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 5;
            label4.Text = "Editar Aluno";
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
            // EditarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 492);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtApelido);
            Controls.Add(txtNomeAluno);
            Controls.Add(txtIdAluno);
            Name = "EditarAlunoForm";
            Text = "Editar Aluno";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdAluno;
        private TextBox txtNomeAluno;
        private TextBox txtApelido;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox2;
    }
}