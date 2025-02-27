namespace WinFormsDisciplinas
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
            txtNomeDisciplina = new TextBox();
            txtIdDisciplina = new TextBox();
            EditarDisciplina = new Button();
            btnApagarDisciplina = new Button();
            DisciplinaListBox = new ListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(46, 126);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(644, 26);
            txtNomeDisciplina.TabIndex = 3;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(46, 56);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(263, 26);
            txtIdDisciplina.TabIndex = 2;
            // 
            // EditarDisciplina
            // 
            EditarDisciplina.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarDisciplina.Location = new Point(744, 343);
            EditarDisciplina.Name = "EditarDisciplina";
            EditarDisciplina.Size = new Size(222, 72);
            EditarDisciplina.TabIndex = 15;
            EditarDisciplina.Text = "Editar disciplina selecionada";
            EditarDisciplina.UseVisualStyleBackColor = true;
            EditarDisciplina.Click += btnEditarDisciplina_Click;
            // 
            // btnApagarDisciplina
            // 
            btnApagarDisciplina.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagarDisciplina.Location = new Point(744, 259);
            btnApagarDisciplina.Name = "btnApagarDisciplina";
            btnApagarDisciplina.Size = new Size(222, 78);
            btnApagarDisciplina.TabIndex = 14;
            btnApagarDisciplina.Text = "Apagar disciplina selecionada";
            btnApagarDisciplina.UseVisualStyleBackColor = true;
            btnApagarDisciplina.Click += btnApagarDisciplina_Click;
            // 
            // DisciplinaListBox
            // 
            DisciplinaListBox.FormattingEnabled = true;
            DisciplinaListBox.Location = new Point(46, 259);
            DisciplinaListBox.Name = "DisciplinaListBox";
            DisciplinaListBox.Size = new Size(660, 156);
            DisciplinaListBox.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(428, 169);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 67);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(578, 169);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 67);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 526);
            Controls.Add(EditarDisciplina);
            Controls.Add(btnApagarDisciplina);
            Controls.Add(DisciplinaListBox);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeDisciplina;
        private TextBox txtIdDisciplina;
        private Button EditarDisciplina;
        private Button btnApagarDisciplina;
        private ListBox DisciplinaListBox;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}
