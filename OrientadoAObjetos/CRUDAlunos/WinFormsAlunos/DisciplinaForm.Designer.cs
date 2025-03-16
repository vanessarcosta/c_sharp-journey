namespace WinFormsAlunos
{
    partial class DisciplinaForm
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
            EditarDisciplina = new Button();
            btnApagarDisciplina = new Button();
            DisciplinaListBox = new ListBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNomeDisciplina = new TextBox();
            txtIdDisciplina = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // EditarDisciplina
            // 
            EditarDisciplina.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditarDisciplina.Location = new Point(723, 338);
            EditarDisciplina.Name = "EditarDisciplina";
            EditarDisciplina.Size = new Size(222, 72);
            EditarDisciplina.TabIndex = 22;
            EditarDisciplina.Text = "Editar disciplina selecionada";
            EditarDisciplina.UseVisualStyleBackColor = true;
            EditarDisciplina.Click += EditarDisciplina_Click;
            // 
            // btnApagarDisciplina
            // 
            btnApagarDisciplina.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagarDisciplina.Location = new Point(723, 254);
            btnApagarDisciplina.Name = "btnApagarDisciplina";
            btnApagarDisciplina.Size = new Size(222, 78);
            btnApagarDisciplina.TabIndex = 21;
            btnApagarDisciplina.Text = "Apagar disciplina selecionada";
            btnApagarDisciplina.UseVisualStyleBackColor = true;
            btnApagarDisciplina.Click += btnApagarDisciplina_Click;
            // 
            // DisciplinaListBox
            // 
            DisciplinaListBox.FormattingEnabled = true;
            DisciplinaListBox.Location = new Point(25, 254);
            DisciplinaListBox.Name = "DisciplinaListBox";
            DisciplinaListBox.Size = new Size(660, 156);
            DisciplinaListBox.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(407, 164);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 67);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(557, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 67);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(210, 121);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(438, 26);
            txtNomeDisciplina.TabIndex = 17;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(210, 38);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(263, 26);
            txtIdDisciplina.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 36);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 23;
            label3.Text = "Id da disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 119);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 24;
            label1.Text = "Nome da disciplina:";
            // 
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 461);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(EditarDisciplina);
            Controls.Add(btnApagarDisciplina);
            Controls.Add(DisciplinaListBox);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Name = "DisciplinaForm";
            Text = "DisciplinaForm";
            FormClosing += DisciplinaForm_FormClosing;
            Load += DisciplinaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EditarDisciplina;
        private Button btnApagarDisciplina;
        private ListBox DisciplinaListBox;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNomeDisciplina;
        private TextBox txtIdDisciplina;
        private Label label3;
        private Label label1;
    }
}