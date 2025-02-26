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
            lbl = new Label();
            txtIdAluno = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeAluno = new TextBox();
            txtApelidoAluno = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            AlunosListBox = new ListBox();
            btnApagarAluno = new Button();
            btnEditarAluno = new Button();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(88, 94);
            lbl.Name = "lbl";
            lbl.Size = new Size(113, 25);
            lbl.TabIndex = 0;
            lbl.Text = "Id de aluno:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Location = new Point(267, 94);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(179, 26);
            txtIdAluno.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 156);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome do aluno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(88, 213);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 3;
            label2.Text = "Apelido do aluno:";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(267, 155);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(371, 26);
            txtNomeAluno.TabIndex = 4;
            // 
            // txtApelidoAluno
            // 
            txtApelidoAluno.Location = new Point(267, 212);
            txtApelidoAluno.Name = "txtApelidoAluno";
            txtApelidoAluno.Size = new Size(371, 26);
            txtApelidoAluno.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(526, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 67);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(390, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 67);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AlunosListBox
            // 
            AlunosListBox.FormattingEnabled = true;
            AlunosListBox.Location = new Point(88, 366);
            AlunosListBox.Name = "AlunosListBox";
            AlunosListBox.Size = new Size(836, 156);
            AlunosListBox.TabIndex = 8;
            // 
            // btnApagarAluno
            // 
            btnApagarAluno.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagarAluno.Location = new Point(964, 366);
            btnApagarAluno.Name = "btnApagarAluno";
            btnApagarAluno.Size = new Size(222, 67);
            btnApagarAluno.TabIndex = 9;
            btnApagarAluno.Text = "Apagar aluno selecionado";
            btnApagarAluno.UseVisualStyleBackColor = true;
            btnApagarAluno.Click += btnApagarAluno_Click;
            // 
            // btnEditarAluno
            // 
            btnEditarAluno.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarAluno.Location = new Point(964, 455);
            btnEditarAluno.Name = "btnEditarAluno";
            btnEditarAluno.Size = new Size(222, 65);
            btnEditarAluno.TabIndex = 10;
            btnEditarAluno.Text = "Editar aluno selecionado";
            btnEditarAluno.UseVisualStyleBackColor = true;
            btnEditarAluno.Click += btnEditarAluno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 572);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtIdAluno;
        private Label label1;
        private Label label2;
        private TextBox txtNomeAluno;
        private TextBox txtApelidoAluno;
        private Button btnCancelar;
        private Button btnGuardar;
        private ListBox AlunosListBox;
        private Button btnApagarAluno;
        private Button btnEditarAluno;
    }
}
