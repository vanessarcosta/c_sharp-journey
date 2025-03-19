namespace WinFormsAlunos
{
    partial class FrmLogin
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
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 71, 160);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 56);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 71, 160);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.icons8_desligar_30;
            button2.Location = new Point(1334, 8);
            button2.Name = "button2";
            button2.Size = new Size(63, 43);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_escola_16;
            pictureBox1.Location = new Point(38, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 12);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 2;
            label2.Text = "Escola da Luz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(0, 71, 160);
            label1.Location = new Point(347, 357);
            label1.Name = "label1";
            label1.Size = new Size(170, 22);
            label1.TabIndex = 1;
            label1.Text = "Nome de usuário:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_escola_100__1_;
            pictureBox2.Location = new Point(604, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 71, 160);
            label3.Location = new Point(513, 314);
            label3.Name = "label3";
            label3.Size = new Size(375, 30);
            label3.TabIndex = 3;
            label3.Text = "Por favor, faça login primeiro";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(347, 393);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(687, 34);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(347, 485);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(687, 34);
            textBox2.TabIndex = 8;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(0, 71, 160);
            label6.Location = new Point(347, 449);
            label6.Name = "label6";
            label6.Size = new Size(73, 22);
            label6.TabIndex = 6;
            label6.Text = "Senha:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 71, 160);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(347, 594);
            button1.Name = "button1";
            button1.Size = new Size(687, 48);
            button1.TabIndex = 9;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 71, 160);
            label5.Location = new Point(508, 543);
            label5.Name = "label5";
            label5.Size = new Size(207, 23);
            label5.TabIndex = 10;
            label5.Text = "Esqueceu sua senha?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.0173912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 71, 160);
            label7.Location = new Point(12, 689);
            label7.Name = "label7";
            label7.Size = new Size(471, 21);
            label7.TabIndex = 11;
            label7.Text = "Copyright © 2025 Todos os direitos reservados  Escola da Luz";
            // 
            // FrmLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1430, 720);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = "FrmLogin";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private Button button1;
        private Label label5;
        private Label label7;
        private Button button2;
    }
}