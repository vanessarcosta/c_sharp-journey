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
            panel1 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.HotTrack;
            btnGuardar.Location = new Point(477, 294);
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
            btnCancelar.ForeColor = SystemColors.HotTrack;
            btnCancelar.Location = new Point(624, 294);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 61);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.ForeColor = SystemColors.HotTrack;
            txtNomeDisciplina.Location = new Point(229, 219);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(463, 26);
            txtNomeDisciplina.TabIndex = 6;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.ForeColor = SystemColors.HotTrack;
            txtIdDisciplina.Location = new Point(229, 138);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(263, 26);
            txtIdDisciplina.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(33, 220);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 25;
            label1.Text = "Nome da disciplina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(33, 139);
            label2.Name = "label2";
            label2.Size = new Size(145, 25);
            label2.TabIndex = 26;
            label2.Text = "Id da disciplina:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 113);
            panel1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(309, 41);
            label3.Name = "label3";
            label3.Size = new Size(220, 30);
            label3.TabIndex = 5;
            label3.Text = "Editar disciplinas";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = WinFormsAlunos.Properties.Resources.icons8_escola_100__1_;
            pictureBox2.Location = new Point(36, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // EditarDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 414);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Name = "EditarDisciplinaForm";
            Text = "Editar Disciplina";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private Label label3;
        private PictureBox pictureBox2;
    }
}