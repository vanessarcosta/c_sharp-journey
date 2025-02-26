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
            SuspendLayout();
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Location = new Point(72, 61);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(263, 26);
            txtIdAluno.TabIndex = 0;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(72, 131);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(644, 26);
            txtNomeAluno.TabIndex = 1;
            // 
            // txtApelido
            // 
            txtApelido.Location = new Point(72, 198);
            txtApelido.Name = "txtApelido";
            txtApelido.Size = new Size(644, 26);
            txtApelido.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(611, 265);
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
            btnGuardar.Location = new Point(462, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 61);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // EditarAlunoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 392);
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
    }
}