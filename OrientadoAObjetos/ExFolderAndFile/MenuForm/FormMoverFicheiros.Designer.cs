namespace MenuForm
{
    partial class FormMoverFicheiros
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
            btnMoverFicheiros = new Button();
            label1 = new Label();
            textBoxMoverrFicheiros = new TextBox();
            label2 = new Label();
            textBoxDestinoMover = new TextBox();
            SuspendLayout();
            // 
            // btnMoverFicheiros
            // 
            btnMoverFicheiros.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMoverFicheiros.Location = new Point(313, 185);
            btnMoverFicheiros.Name = "btnMoverFicheiros";
            btnMoverFicheiros.Size = new Size(90, 28);
            btnMoverFicheiros.TabIndex = 12;
            btnMoverFicheiros.Text = "OK";
            btnMoverFicheiros.UseVisualStyleBackColor = true;
            btnMoverFicheiros.Click += btnMoverFicheiros_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 128);
            label1.Name = "label1";
            label1.Size = new Size(391, 25);
            label1.TabIndex = 11;
            label1.Text = "Insira o destino das cópias e pressione OK:";
            // 
            // textBoxMoverrFicheiros
            // 
            textBoxMoverrFicheiros.Location = new Point(22, 86);
            textBoxMoverrFicheiros.Name = "textBoxMoverrFicheiros";
            textBoxMoverrFicheiros.Size = new Size(238, 26);
            textBoxMoverrFicheiros.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 41);
            label2.Name = "label2";
            label2.Size = new Size(272, 25);
            label2.TabIndex = 13;
            label2.Text = "Insira a origem dos ficheiros:";
            // 
            // textBoxDestinoMover
            // 
            textBoxDestinoMover.Location = new Point(22, 185);
            textBoxDestinoMover.Name = "textBoxDestinoMover";
            textBoxDestinoMover.Size = new Size(238, 26);
            textBoxDestinoMover.TabIndex = 14;
            // 
            // FormMoverFicheiros
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 226);
            Controls.Add(textBoxDestinoMover);
            Controls.Add(label2);
            Controls.Add(btnMoverFicheiros);
            Controls.Add(label1);
            Controls.Add(textBoxMoverrFicheiros);
            Name = "FormMoverFicheiros";
            Text = "FormMoverFicheiros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMoverFicheiros;
        private Label label1;
        private TextBox textBoxMoverrFicheiros;
        private Label label2;
        private TextBox textBoxDestinoMover;
    }
}