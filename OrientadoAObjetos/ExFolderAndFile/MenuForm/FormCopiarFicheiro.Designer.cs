namespace MenuForm
{
    partial class FormCopiarFicheiro
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
            btnCopiarFicheiros = new Button();
            label1 = new Label();
            textBoxCopiarFicheiros = new TextBox();
            SuspendLayout();
            // 
            // btnCopiarFicheiros
            // 
            btnCopiarFicheiros.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopiarFicheiros.Location = new Point(323, 98);
            btnCopiarFicheiros.Name = "btnCopiarFicheiros";
            btnCopiarFicheiros.Size = new Size(90, 28);
            btnCopiarFicheiros.TabIndex = 9;
            btnCopiarFicheiros.Text = "OK";
            btnCopiarFicheiros.UseVisualStyleBackColor = true;
            btnCopiarFicheiros.Click += btnCopiarFicheiros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 8;
            label1.Text = "Insira o destino das cópias e pressione OK:";
            // 
            // textBoxCopiarFicheiros
            // 
            textBoxCopiarFicheiros.Location = new Point(24, 98);
            textBoxCopiarFicheiros.Name = "textBoxCopiarFicheiros";
            textBoxCopiarFicheiros.Size = new Size(238, 26);
            textBoxCopiarFicheiros.TabIndex = 7;
            // 
            // FormCopiarFicheiro
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 170);
            Controls.Add(btnCopiarFicheiros);
            Controls.Add(label1);
            Controls.Add(textBoxCopiarFicheiros);
            Name = "FormCopiarFicheiro";
            Text = "FormCopiarFicheiro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopiarFicheiros;
        private Label label1;
        private TextBox textBoxCopiarFicheiros;
    }
}