namespace MenuForm
{
    partial class FormExtensao
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
            bTNExtensao = new Button();
            label1 = new Label();
            textBoxExtensao = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // bTNExtensao
            // 
            bTNExtensao.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bTNExtensao.Location = new Point(311, 103);
            bTNExtensao.Name = "bTNExtensao";
            bTNExtensao.Size = new Size(90, 28);
            bTNExtensao.TabIndex = 6;
            bTNExtensao.Text = "OK";
            bTNExtensao.UseVisualStyleBackColor = true;
            bTNExtensao.Click += bTNExtensao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(389, 25);
            label1.TabIndex = 5;
            label1.Text = "Insira a extensão desejada e pressione OK:";
            // 
            // textBoxExtensao
            // 
            textBoxExtensao.Location = new Point(12, 103);
            textBoxExtensao.Name = "textBoxExtensao";
            textBoxExtensao.Size = new Size(238, 26);
            textBoxExtensao.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(356, 25);
            label2.TabIndex = 7;
            label2.Text = "Insira somente o nome sem o ponto(.):";
            // 
            // FormExtensao
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 161);
            Controls.Add(label2);
            Controls.Add(bTNExtensao);
            Controls.Add(label1);
            Controls.Add(textBoxExtensao);
            Name = "FormExtensao";
            Text = "Inserir dados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bTNExtensao;
        private Label label1;
        private TextBox textBoxExtensao;
        private Label label2;
    }
}