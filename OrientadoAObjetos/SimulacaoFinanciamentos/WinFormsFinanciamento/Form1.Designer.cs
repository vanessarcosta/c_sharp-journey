namespace WinFormsFinanciamento
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
            //this.comboBoxTipo = new ComboBox();
            button1 = new Button();
            //this.comboBoxMontante = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxPrazo = new ComboBox();
            lblValorPrestacao = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            //this.comboBoxTipo.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            //this.comboBoxTipo.FormattingEnabled = true;
            //this.comboBoxTipo.Items.AddRange(new object[] { "Carro", "Casa", "Outros" });
            //this.comboBoxTipo.Location = new Point(470, 119);
            //this.comboBoxTipo.Name = "comboBoxTipo";
            //this.comboBoxTipo.Size = new Size(145, 33);
            //this.comboBoxTipo.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            button1.Location = new Point(525, 281);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 1;
            button1.Text = "Simular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBoxMontante
            // 
            //this.comboBoxMontante.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            //this.comboBoxMontante.FormattingEnabled = true;
            //this.comboBoxMontante.Location = new Point(84, 119);
            //this.comboBoxMontante.Name = "comboBoxMontante";
            //this.comboBoxMontante.Size = new Size(145, 33);
            //this.comboBoxMontante.TabIndex = 2;
            //// 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            label1.Location = new Point(102, 63);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 3;
            label1.Text = "Montante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            label2.Location = new Point(526, 63);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            label3.Location = new Point(115, 244);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 5;
            label3.Text = "Prazo";
            // 
            // comboBoxPrazo
            // 
            comboBoxPrazo.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            comboBoxPrazo.FormattingEnabled = true;
            comboBoxPrazo.Location = new Point(84, 281);
            comboBoxPrazo.Name = "comboBoxPrazo";
            comboBoxPrazo.Size = new Size(145, 33);
            comboBoxPrazo.TabIndex = 7;
            // 
            // lblValorPrestacao
            // 
            lblValorPrestacao.AutoSize = true;
            lblValorPrestacao.Enabled = false;
            lblValorPrestacao.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            lblValorPrestacao.Location = new Point(84, 384);
            lblValorPrestacao.Name = "lblValorPrestacao";
            lblValorPrestacao.Size = new Size(57, 25);
            lblValorPrestacao.TabIndex = 8;
            lblValorPrestacao.Text = "label";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            label5.Location = new Point(235, 289);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 9;
            label5.Text = "meses";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Garamond", 13.7739134F, FontStyle.Bold);
            label6.Location = new Point(247, 127);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 10;
            label6.Text = "Euros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblValorPrestacao);
            Controls.Add(comboBoxPrazo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            //Controls.Add(this.comboBoxMontante);
            Controls.Add(button1);
            //Controls.Add(this.comboBoxTipo);
            Name = "Form1";
            Text = "Simular Financiamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox3;
        private ComboBox comboBoxPrazo;
        private Label lblValorPrestacao;
        private Label label5;
        private Label label6;
    }
}
