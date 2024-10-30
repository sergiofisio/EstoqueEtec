namespace Estoque
{
    partial class FormMenu
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
            if(disposing && (components != null))
            {
                components.Dispose( );
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
            menuStrip1 = new MenuStrip( );
            menuToolStripMenuItem = new ToolStripMenuItem( );
            produtoToolStripMenuItem = new ToolStripMenuItem( );
            movimentaçãoEstoqueToolStripMenuItem = new ToolStripMenuItem( );
            menuStrip1.SuspendLayout( );
            SuspendLayout( );
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(394, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem, movimentaçãoEstoqueToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(199, 22);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += ProdutoToolStripMenuItem_Click;
            // 
            // movimentaçãoEstoqueToolStripMenuItem
            // 
            movimentaçãoEstoqueToolStripMenuItem.Name = "movimentaçãoEstoqueToolStripMenuItem";
            movimentaçãoEstoqueToolStripMenuItem.Size = new Size(199, 22);
            movimentaçãoEstoqueToolStripMenuItem.Text = "Movimentação Estoque";
            movimentaçãoEstoqueToolStripMenuItem.Click += MovimentaçãoEstoqueToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem movimentaçãoEstoqueToolStripMenuItem;
    }
}
