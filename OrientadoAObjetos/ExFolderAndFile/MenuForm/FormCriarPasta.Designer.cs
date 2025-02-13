namespace MenuForm
{
    partial class frmCriarPasta
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
            btnCriarPasta = new Button();
            label1 = new Label();
            textBoxCriarPasta = new TextBox();
            SuspendLayout();
            // 
            // btnCriarPasta
            // 
            btnCriarPasta.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCriarPasta.Location = new Point(329, 108);
            btnCriarPasta.Name = "btnCriarPasta";
            btnCriarPasta.Size = new Size(90, 28);
            btnCriarPasta.TabIndex = 9;
            btnCriarPasta.Text = "OK";
            btnCriarPasta.UseVisualStyleBackColor = true;
            btnCriarPasta.Click += btnCriarPasta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 58);
            label1.Name = "label1";
            label1.Size = new Size(356, 25);
            label1.TabIndex = 8;
            label1.Text = "Insira o nome da pasta e pressione OK:";
            // 
            // textBoxCriarPasta
            // 
            textBoxCriarPasta.Location = new Point(30, 108);
            textBoxCriarPasta.Name = "textBoxCriarPasta";
            textBoxCriarPasta.Size = new Size(238, 26);
            textBoxCriarPasta.TabIndex = 7;
            // 
            // frmCriarPasta
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 168);
            Controls.Add(btnCriarPasta);
            Controls.Add(label1);
            Controls.Add(textBoxCriarPasta);
            Name = "frmCriarPasta";
            Text = "Inserir dados da pasta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCriarPasta;
        private Label label1;
        private TextBox textBoxCriarPasta;
    }
}