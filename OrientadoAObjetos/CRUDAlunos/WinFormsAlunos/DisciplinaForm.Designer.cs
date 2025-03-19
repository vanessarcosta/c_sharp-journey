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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // EditarDisciplina
            // 
            EditarDisciplina.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            EditarDisciplina.ForeColor = SystemColors.HotTrack;
            EditarDisciplina.Location = new Point(710, 420);
            EditarDisciplina.Name = "EditarDisciplina";
            EditarDisciplina.Size = new Size(222, 72);
            EditarDisciplina.TabIndex = 22;
            EditarDisciplina.Text = "Editar disciplina selecionada";
            EditarDisciplina.UseVisualStyleBackColor = true;
            EditarDisciplina.Click += EditarDisciplina_Click;
            // 
            // btnApagarDisciplina
            // 
            btnApagarDisciplina.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnApagarDisciplina.ForeColor = SystemColors.HotTrack;
            btnApagarDisciplina.Location = new Point(710, 336);
            btnApagarDisciplina.Name = "btnApagarDisciplina";
            btnApagarDisciplina.Size = new Size(222, 78);
            btnApagarDisciplina.TabIndex = 21;
            btnApagarDisciplina.Text = "Apagar disciplina selecionada";
            btnApagarDisciplina.UseVisualStyleBackColor = true;
            btnApagarDisciplina.Click += btnApagarDisciplina_Click;
            // 
            // DisciplinaListBox
            // 
            DisciplinaListBox.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            DisciplinaListBox.ForeColor = SystemColors.HotTrack;
            DisciplinaListBox.FormattingEnabled = true;
            DisciplinaListBox.ItemHeight = 23;
            DisciplinaListBox.Location = new Point(12, 336);
            DisciplinaListBox.Name = "DisciplinaListBox";
            DisciplinaListBox.Size = new Size(660, 142);
            DisciplinaListBox.TabIndex = 20;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.HotTrack;
            btnGuardar.Location = new Point(407, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 67);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.HotTrack;
            btnCancelar.Location = new Point(560, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 67);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            txtNomeDisciplina.ForeColor = SystemColors.HotTrack;
            txtNomeDisciplina.Location = new Point(234, 193);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(438, 31);
            txtNomeDisciplina.TabIndex = 17;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Enabled = false;
            txtIdDisciplina.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            txtIdDisciplina.ForeColor = SystemColors.HotTrack;
            txtIdDisciplina.Location = new Point(234, 133);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(263, 31);
            txtIdDisciplina.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(159, 23);
            label3.TabIndex = 23;
            label3.Text = "Id da disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 201);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 24;
            label1.Text = "Nome da disciplina:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 113);
            panel1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(394, 33);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 5;
            label2.Text = "Disciplinas";
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
            // DisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 525);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
    }
}