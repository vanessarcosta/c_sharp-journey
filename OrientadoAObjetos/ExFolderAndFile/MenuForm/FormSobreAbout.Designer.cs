﻿namespace MenuForm
{
    partial class FormSobreAbout
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 112);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 5;
            label3.Text = "Versão: 1.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 69);
            label2.Name = "label2";
            label2.Size = new Size(249, 30);
            label2.TabIndex = 4;
            label2.Text = "Criado em 13/02/2025";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 25);
            label1.Name = "label1";
            label1.Size = new Size(236, 30);
            label1.TabIndex = 3;
            label1.Text = "Autora Vanessa Costa";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 146);
            button1.Name = "button1";
            button1.Size = new Size(90, 39);
            button1.TabIndex = 6;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormSobreAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 197);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSobreAbout";
            Text = "Manipular Arquivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}