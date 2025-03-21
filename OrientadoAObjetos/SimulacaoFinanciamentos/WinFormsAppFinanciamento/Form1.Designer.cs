namespace WinFormsAppFinanciamento
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
            comboBoxTipo = new ComboBox();
            lblInformacao = new Label();
            btnSimular = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMontante = new TextBox();
            txtPrazo = new TextBox();
            txtJuros = new TextBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Carro", "Casa", "Outros" });
            comboBoxTipo.Location = new Point(349, 94);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(201, 29);
            comboBoxTipo.TabIndex = 1;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // lblInformacao
            // 
            lblInformacao.AutoSize = true;
            lblInformacao.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInformacao.Location = new Point(45, 325);
            lblInformacao.Name = "lblInformacao";
            lblInformacao.Size = new Size(0, 25);
            lblInformacao.TabIndex = 3;
            // 
            // btnSimular
            // 
            btnSimular.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimular.Location = new Point(671, 72);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(132, 51);
            btnSimular.TabIndex = 4;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = true;
            btnSimular.Click += btnSimular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label2.Location = new Point(45, 51);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 5;
            label2.Text = "Montante:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label3.Location = new Point(349, 51);
            label3.Name = "label3";
            label3.Size = new Size(201, 21);
            label3.TabIndex = 6;
            label3.Text = "Tipo de financiamento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label4.Location = new Point(45, 190);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 7;
            label4.Text = "Prazo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label5.Location = new Point(208, 239);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 8;
            label5.Text = "meses";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label6.Location = new Point(208, 99);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 9;
            label6.Text = "euros";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label7.Location = new Point(512, 242);
            label7.Name = "label7";
            label7.Size = new Size(61, 21);
            label7.TabIndex = 12;
            label7.Text = "% ano";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold);
            label8.Location = new Point(349, 193);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 11;
            label8.Text = "Juros";
            // 
            // txtMontante
            // 
            txtMontante.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMontante.Location = new Point(45, 94);
            txtMontante.Name = "txtMontante";
            txtMontante.Size = new Size(141, 29);
            txtMontante.TabIndex = 13;
            // 
            // txtPrazo
            // 
            txtPrazo.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrazo.Location = new Point(45, 231);
            txtPrazo.Name = "txtPrazo";
            txtPrazo.Size = new Size(141, 29);
            txtPrazo.TabIndex = 14;
            // 
            // txtJuros
            // 
            txtJuros.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtJuros.Location = new Point(349, 239);
            txtJuros.Name = "txtJuros";
            txtJuros.Size = new Size(157, 29);
            txtJuros.TabIndex = 15;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Garamond", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(671, 209);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(132, 51);
            btnLimpar.TabIndex = 16;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 467);
            Controls.Add(btnLimpar);
            Controls.Add(txtJuros);
            Controls.Add(txtPrazo);
            Controls.Add(txtMontante);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSimular);
            Controls.Add(lblInformacao);
            Controls.Add(comboBoxTipo);
            Name = "Form1";
            Text = "Simular Financiamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxTipo;
        private Label lblInformacao;
        private Button btnSimular;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMontante;
        private TextBox txtPrazo;
        private TextBox txtJuros;
        private Button btnLimpar;
    }
}
