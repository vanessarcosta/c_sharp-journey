namespace WinFormsDisciplinas
{
    partial class EditarDisciplinaForm
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNomeDisciplina = new TextBox();
            txtIdDisciplina = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(456, 206);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 61);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(603, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 61);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(208, 131);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(463, 26);
            txtNomeDisciplina.TabIndex = 6;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Location = new Point(208, 50);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(263, 26);
            txtIdDisciplina.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 25;
            label1.Text = "Nome da disciplina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 26;
            label2.Text = "Id da disciplina:";
            // 
            // EditarDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 328);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Name = "EditarDisciplinaForm";
            Text = "Editar Disciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNomeDisciplina;
        private TextBox txtIdDisciplina;
        private Label label1;
        private Label label2;
    }
}