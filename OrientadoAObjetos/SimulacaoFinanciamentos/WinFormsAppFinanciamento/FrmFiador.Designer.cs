namespace WinFormsAppFinanciamento
{
    partial class FrmFiador
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
            label1 = new Label();
            label6 = new Label();
            txtNome = new TextBox();
            txtMorada = new TextBox();
            labelMorada = new Label();
            txtTelefone = new TextBox();
            label3 = new Label();
            txtNif = new TextBox();
            label4 = new Label();
            txtRendimentoAnual = new TextBox();
            label5 = new Label();
            btnSalvarFiador = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 92);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(251, 39);
            label6.Name = "label6";
            label6.Size = new Size(189, 21);
            label6.TabIndex = 5;
            label6.Text = "Insira dados do fiado:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(209, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(377, 29);
            txtNome.TabIndex = 6;
            // 
            // txtMorada
            // 
            txtMorada.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMorada.Location = new Point(209, 143);
            txtMorada.Name = "txtMorada";
            txtMorada.Size = new Size(377, 29);
            txtMorada.TabIndex = 8;
            // 
            // labelMorada
            // 
            labelMorada.AutoSize = true;
            labelMorada.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMorada.Location = new Point(45, 151);
            labelMorada.Name = "labelMorada";
            labelMorada.Size = new Size(78, 21);
            labelMorada.TabIndex = 7;
            labelMorada.Text = "Morada:";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(209, 204);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(377, 29);
            txtTelefone.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 212);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 9;
            label3.Text = "Telefone:";
            // 
            // txtNif
            // 
            txtNif.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNif.Location = new Point(209, 261);
            txtNif.Name = "txtNif";
            txtNif.Size = new Size(377, 29);
            txtNif.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 269);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 11;
            label4.Text = "NIF:";
            // 
            // txtRendimentoAnual
            // 
            txtRendimentoAnual.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRendimentoAnual.Location = new Point(267, 319);
            txtRendimentoAnual.Name = "txtRendimentoAnual";
            txtRendimentoAnual.Size = new Size(319, 29);
            txtRendimentoAnual.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 327);
            label5.Name = "label5";
            label5.Size = new Size(216, 21);
            label5.TabIndex = 13;
            label5.Text = "Rendimento bruto anual:";
            // 
            // btnSalvarFiador
            // 
            btnSalvarFiador.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarFiador.Location = new Point(496, 378);
            btnSalvarFiador.Name = "btnSalvarFiador";
            btnSalvarFiador.Size = new Size(90, 28);
            btnSalvarFiador.TabIndex = 15;
            btnSalvarFiador.Text = "OK";
            btnSalvarFiador.UseVisualStyleBackColor = true;
            btnSalvarFiador.Click += btnSalvarFiador_Click;
            // 
            // FrmFiador
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 428);
            Controls.Add(btnSalvarFiador);
            Controls.Add(txtRendimentoAnual);
            Controls.Add(label5);
            Controls.Add(txtNif);
            Controls.Add(label4);
            Controls.Add(txtTelefone);
            Controls.Add(label3);
            Controls.Add(txtMorada);
            Controls.Add(labelMorada);
            Controls.Add(txtNome);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FrmFiador";
            Text = "Insira Fiador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label6;
        private TextBox txtNome;
        private TextBox txtMorada;
        private Label labelMorada;
        private TextBox txtTelefone;
        private Label label3;
        private TextBox txtNif;
        private Label label4;
        private TextBox txtRendimentoAnual;
        private Label label5;
        private Button btnSalvarFiador;
    }
}