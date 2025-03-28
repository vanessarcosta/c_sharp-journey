namespace LinqUI
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
            label1 = new Label();
            comboBoxTodosAlunos = new ComboBox();
            label2 = new Label();
            numericUpDownDisciplinasFeitas = new NumericUpDown();
            btnUpdate = new Button();
            label3 = new Label();
            listBoxFiltro = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplinasFeitas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 67);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Todos os alunos";
            // 
            // comboBoxTodosAlunos
            // 
            comboBoxTodosAlunos.FormattingEnabled = true;
            comboBoxTodosAlunos.Location = new Point(57, 102);
            comboBoxTodosAlunos.Name = "comboBoxTodosAlunos";
            comboBoxTodosAlunos.Size = new Size(265, 27);
            comboBoxTodosAlunos.TabIndex = 1;
            comboBoxTodosAlunos.SelectedIndexChanged += comboBoxTodosAlunos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 212);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 2;
            label2.Text = "Disciplinas Feitas:";
            // 
            // numericUpDownDisciplinasFeitas
            // 
            numericUpDownDisciplinasFeitas.Location = new Point(208, 212);
            numericUpDownDisciplinasFeitas.Name = "numericUpDownDisciplinasFeitas";
            numericUpDownDisciplinasFeitas.Size = new Size(144, 26);
            numericUpDownDisciplinasFeitas.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(57, 284);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 45);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.0173912F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(442, 47);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 5;
            label3.Text = "Alunos filtrados:";
            // 
            // listBoxFiltro
            // 
            listBoxFiltro.FormattingEnabled = true;
            listBoxFiltro.Location = new Point(433, 81);
            listBoxFiltro.Name = "listBoxFiltro";
            listBoxFiltro.Size = new Size(341, 422);
            listBoxFiltro.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(listBoxFiltro);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(numericUpDownDisciplinasFeitas);
            Controls.Add(label2);
            Controls.Add(comboBoxTodosAlunos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDisciplinasFeitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxTodosAlunos;
        private Label label2;
        private NumericUpDown numericUpDownDisciplinasFeitas;
        private Button btnUpdate;
        private Label label3;
        private ListBox listBoxFiltro;
    }
}
