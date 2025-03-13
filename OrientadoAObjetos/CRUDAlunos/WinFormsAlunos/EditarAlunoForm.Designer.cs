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
            SuspendLayout();
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Location = new Point(227, 73);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(263, 26);
            txtIdAluno.TabIndex = 0;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(227, 143);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(644, 26);
            txtNomeAluno.TabIndex = 1;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(227, 210);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(644, 26);
            txtApelido.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(766, 277);
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
            btnGuardar.Location = new Point(617, 277);
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
            label2.Location = new Point(31, 211);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 6;
            label2.Text = "Apelido do aluno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 141);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 7;
            label1.Text = "Nome do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 71);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 8;
            label3.Text = "Id do aluno:";
            // 
            // EditarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 417);
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
    }
}