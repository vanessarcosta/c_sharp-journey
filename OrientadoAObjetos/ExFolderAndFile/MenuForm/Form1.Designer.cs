namespace MenuForm
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            menuStripPrincipal = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            criarToolStripMenuItem = new ToolStripMenuItem();
            copiarFicheiroToolStripMenuItem = new ToolStripMenuItem();
            moverFicheiroToolStripMenuItem = new ToolStripMenuItem();
            apagarFicheiroToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            listarToolStripMenuItem = new ToolStripMenuItem();
            todasAsSubpastasToolStripMenuItem = new ToolStripMenuItem();
            todosOsFicheirosToolStripMenuItem = new ToolStripMenuItem();
            somenteONomeToolStripMenuItem = new ToolStripMenuItem();
            extensãoETamanhoToolStripMenuItem = new ToolStripMenuItem();
            tToolStripMenuItem = new ToolStripMenuItem();
            sobreAboutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxCaminho = new TextBox();
            label1 = new Label();
            bTNCaminho = new Button();
            menuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.Enabled = false;
            menuStripPrincipal.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripPrincipal.ImageScalingSize = new Size(19, 19);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, listarToolStripMenuItem, sobreAboutToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Size = new Size(800, 33);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "Principal";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarToolStripMenuItem, copiarFicheiroToolStripMenuItem, moverFicheiroToolStripMenuItem, apagarFicheiroToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(98, 29);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // criarToolStripMenuItem
            // 
            criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            criarToolStripMenuItem.Size = new Size(234, 30);
            criarToolStripMenuItem.Text = "Criar pasta";
            criarToolStripMenuItem.Click += criarToolStripMenuItem_Click;
            // 
            // copiarFicheiroToolStripMenuItem
            // 
            copiarFicheiroToolStripMenuItem.Name = "copiarFicheiroToolStripMenuItem";
            copiarFicheiroToolStripMenuItem.Size = new Size(234, 30);
            copiarFicheiroToolStripMenuItem.Text = "Copiar ficheiro";
            copiarFicheiroToolStripMenuItem.Click += copiarFicheiroToolStripMenuItem_Click;
            // 
            // moverFicheiroToolStripMenuItem
            // 
            moverFicheiroToolStripMenuItem.Name = "moverFicheiroToolStripMenuItem";
            moverFicheiroToolStripMenuItem.Size = new Size(234, 30);
            moverFicheiroToolStripMenuItem.Text = "Mover ficheiro";
            moverFicheiroToolStripMenuItem.Click += moverFicheiroToolStripMenuItem_Click;
            // 
            // apagarFicheiroToolStripMenuItem
            // 
            apagarFicheiroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            apagarFicheiroToolStripMenuItem.Name = "apagarFicheiroToolStripMenuItem";
            apagarFicheiroToolStripMenuItem.Size = new Size(234, 30);
            apagarFicheiroToolStripMenuItem.Text = "Apagar ficheiro";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(420, 30);
            toolStripMenuItem1.Text = "Por extensões";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(420, 30);
            toolStripMenuItem2.Text = "Por conjunto de caracteres no nome";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // listarToolStripMenuItem
            // 
            listarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todasAsSubpastasToolStripMenuItem, todosOsFicheirosToolStripMenuItem, tToolStripMenuItem });
            listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            listarToolStripMenuItem.Size = new Size(74, 29);
            listarToolStripMenuItem.Text = "Listar";
            // 
            // todasAsSubpastasToolStripMenuItem
            // 
            todasAsSubpastasToolStripMenuItem.Name = "todasAsSubpastasToolStripMenuItem";
            todasAsSubpastasToolStripMenuItem.Size = new Size(345, 30);
            todasAsSubpastasToolStripMenuItem.Text = "Todas as sub-pastas";
            todasAsSubpastasToolStripMenuItem.Click += todasAsSubpastasToolStripMenuItem_Click;
            // 
            // todosOsFicheirosToolStripMenuItem
            // 
            todosOsFicheirosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { somenteONomeToolStripMenuItem, extensãoETamanhoToolStripMenuItem });
            todosOsFicheirosToolStripMenuItem.Name = "todosOsFicheirosToolStripMenuItem";
            todosOsFicheirosToolStripMenuItem.Size = new Size(345, 30);
            todosOsFicheirosToolStripMenuItem.Text = "Todos os ficheiros";
            // 
            // somenteONomeToolStripMenuItem
            // 
            somenteONomeToolStripMenuItem.Name = "somenteONomeToolStripMenuItem";
            somenteONomeToolStripMenuItem.Size = new Size(276, 30);
            somenteONomeToolStripMenuItem.Text = "Somente o nome";
            somenteONomeToolStripMenuItem.Click += somenteONomeToolStripMenuItem_Click;
            // 
            // extensãoETamanhoToolStripMenuItem
            // 
            extensãoETamanhoToolStripMenuItem.Name = "extensãoETamanhoToolStripMenuItem";
            extensãoETamanhoToolStripMenuItem.Size = new Size(276, 30);
            extensãoETamanhoToolStripMenuItem.Text = "Extensão e tamanho";
            extensãoETamanhoToolStripMenuItem.Click += extensãoETamanhoToolStripMenuItem_Click;
            // 
            // tToolStripMenuItem
            // 
            tToolStripMenuItem.Name = "tToolStripMenuItem";
            tToolStripMenuItem.Size = new Size(345, 30);
            tToolStripMenuItem.Text = "Apenas Ficheiros especificos";
            tToolStripMenuItem.Click += tToolStripMenuItem_Click;
            // 
            // sobreAboutToolStripMenuItem
            // 
            sobreAboutToolStripMenuItem.Name = "sobreAboutToolStripMenuItem";
            sobreAboutToolStripMenuItem.Size = new Size(143, 29);
            sobreAboutToolStripMenuItem.Text = "Sobre/About";
            sobreAboutToolStripMenuItem.Click += sobreAboutToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(19, 19);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxCaminho
            // 
            textBoxCaminho.Location = new Point(118, 270);
            textBoxCaminho.Name = "textBoxCaminho";
            textBoxCaminho.Size = new Size(120, 26);
            textBoxCaminho.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 216);
            label1.Name = "label1";
            label1.Size = new Size(466, 25);
            label1.TabIndex = 2;
            label1.Text = "Insira o caminho da pasta desejada e pressione OK:";
            // 
            // bTNCaminho
            // 
            bTNCaminho.Font = new Font("Segoe UI", 11.2695656F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bTNCaminho.Location = new Point(392, 270);
            bTNCaminho.Name = "bTNCaminho";
            bTNCaminho.Size = new Size(90, 28);
            bTNCaminho.TabIndex = 3;
            bTNCaminho.Text = "OK";
            bTNCaminho.UseVisualStyleBackColor = true;
            bTNCaminho.Click += bTNCaminho_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bTNCaminho);
            Controls.Add(label1);
            Controls.Add(textBoxCaminho);
            Controls.Add(menuStripPrincipal);
            MainMenuStrip = menuStripPrincipal;
            Name = "FormPrincipal";
            Text = "Manipular Arquivos";
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripPrincipal;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem criarToolStripMenuItem;
        private ToolStripMenuItem copiarFicheiroToolStripMenuItem;
        private ToolStripMenuItem moverFicheiroToolStripMenuItem;
        private ToolStripMenuItem apagarFicheiroToolStripMenuItem;
        private ToolStripMenuItem listarToolStripMenuItem;
        private ToolStripMenuItem todasAsSubpastasToolStripMenuItem;
        private ToolStripMenuItem todosOsFicheirosToolStripMenuItem;
        private ToolStripMenuItem somenteONomeToolStripMenuItem;
        private ToolStripMenuItem extensãoETamanhoToolStripMenuItem;
        private ToolStripMenuItem tToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sobreAboutToolStripMenuItem;
        private TextBox textBoxCaminho;
        private Label label1;
        private Button bTNCaminho;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
