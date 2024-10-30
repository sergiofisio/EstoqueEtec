namespace Estoque
{
    partial class FormMovEstoque
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
            if(disposing && (components != null))
            {
                components.Dispose( );
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
            label1 = new Label( );
            label2 = new Label( );
            TxtCodMov = new NumericUpDown( );
            TxtCodProd = new NumericUpDown( );
            label3 = new Label( );
            lblDesc = new Label( );
            DtpMov = new DateTimePicker( );
            label4 = new Label( );
            groupBox1 = new GroupBox( );
            RdbOut = new RadioButton( );
            RdbIn = new RadioButton( );
            label5 = new Label( );
            TxtQty = new NumericUpDown( );
            label6 = new Label( );
            TxtObs = new TextBox( );
            BtnInclude = new Button( );
            BtnDelete = new Button( );
            BtnSearch = new Button( );
            BtnUpdate = new Button( );
            ((System.ComponentModel.ISupportInitialize)TxtCodMov).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)TxtCodProd).BeginInit( );
            groupBox1.SuspendLayout( );
            ((System.ComponentModel.ISupportInitialize)TxtQty).BeginInit( );
            SuspendLayout( );
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(680, 65);
            label1.TabIndex = 0;
            label1.Text = "Movimentação do Estoque";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 63);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 1;
            label2.Text = "Código Movimentação";
            // 
            // TxtCodMov
            // 
            TxtCodMov.Cursor = Cursors.Hand;
            TxtCodMov.Location = new Point(232, 60);
            TxtCodMov.Margin = new Padding(5);
            TxtCodMov.Name = "TxtCodMov";
            TxtCodMov.Size = new Size(161, 33);
            TxtCodMov.TabIndex = 2;
            TxtCodMov.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCodProd
            // 
            TxtCodProd.Cursor = Cursors.Hand;
            TxtCodProd.Location = new Point(232, 110);
            TxtCodProd.Margin = new Padding(5);
            TxtCodProd.Name = "TxtCodProd";
            TxtCodProd.Size = new Size(161, 33);
            TxtCodProd.TabIndex = 4;
            TxtCodProd.TextAlign = HorizontalAlignment.Right;
            TxtCodProd.MouseDown += CodProdChange;
            TxtCodProd.MouseUp += CodProdChange;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 113);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 3;
            label3.Text = "Código Produto";
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDesc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(401, 110);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(267, 33);
            lblDesc.TabIndex = 5;
            lblDesc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DtpMov
            // 
            DtpMov.Cursor = Cursors.Hand;
            DtpMov.Enabled = false;
            DtpMov.Format = DateTimePickerFormat.Short;
            DtpMov.Location = new Point(232, 160);
            DtpMov.Name = "DtpMov";
            DtpMov.Size = new Size(224, 33);
            DtpMov.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 163);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 25);
            label4.TabIndex = 7;
            label4.Text = "Data da Movimentação";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdbOut);
            groupBox1.Controls.Add(RdbIn);
            groupBox1.Location = new Point(232, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // RdbOut
            // 
            RdbOut.AutoSize = true;
            RdbOut.BackColor = Color.FromArgb(128, 64, 0);
            RdbOut.Cursor = Cursors.Hand;
            RdbOut.Dock = DockStyle.Bottom;
            RdbOut.FlatAppearance.BorderColor = Color.White;
            RdbOut.FlatAppearance.CheckedBackColor = Color.Black;
            RdbOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RdbOut.ForeColor = Color.White;
            RdbOut.Location = new Point(3, 68);
            RdbOut.Name = "RdbOut";
            RdbOut.Padding = new Padding(8, 0, 0, 0);
            RdbOut.Size = new Size(218, 29);
            RdbOut.TabIndex = 1;
            RdbOut.TabStop = true;
            RdbOut.Text = "Saída";
            RdbOut.UseVisualStyleBackColor = false;
            // 
            // RdbIn
            // 
            RdbIn.AutoSize = true;
            RdbIn.BackColor = Color.FromArgb(0, 192, 0);
            RdbIn.Cursor = Cursors.Hand;
            RdbIn.Dock = DockStyle.Top;
            RdbIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RdbIn.ForeColor = Color.Black;
            RdbIn.Location = new Point(3, 29);
            RdbIn.Name = "RdbIn";
            RdbIn.Padding = new Padding(8, 0, 0, 0);
            RdbIn.Size = new Size(218, 29);
            RdbIn.TabIndex = 0;
            RdbIn.TabStop = true;
            RdbIn.Text = "Entrada";
            RdbIn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 333);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 9;
            label5.Text = "Quantidade";
            // 
            // TxtQty
            // 
            TxtQty.Cursor = Cursors.Hand;
            TxtQty.Location = new Point(232, 330);
            TxtQty.Margin = new Padding(5);
            TxtQty.Name = "TxtQty";
            TxtQty.Size = new Size(161, 33);
            TxtQty.TabIndex = 10;
            TxtQty.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 373);
            label6.Name = "label6";
            label6.Size = new Size(111, 25);
            label6.TabIndex = 11;
            label6.Text = "Observação";
            // 
            // TxtObs
            // 
            TxtObs.BorderStyle = BorderStyle.FixedSingle;
            TxtObs.Cursor = Cursors.IBeam;
            TxtObs.Location = new Point(232, 373);
            TxtObs.Multiline = true;
            TxtObs.Name = "TxtObs";
            TxtObs.Size = new Size(224, 127);
            TxtObs.TabIndex = 12;
            // 
            // BtnInclude
            // 
            BtnInclude.BackColor = Color.Blue;
            BtnInclude.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnInclude.ForeColor = Color.White;
            BtnInclude.Location = new Point(162, 517);
            BtnInclude.Name = "BtnInclude";
            BtnInclude.Size = new Size(128, 38);
            BtnInclude.TabIndex = 13;
            BtnInclude.Text = "Incluir";
            BtnInclude.UseVisualStyleBackColor = false;
            BtnInclude.Click += BtnInclude_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.Red;
            BtnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(377, 517);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(128, 38);
            BtnDelete.TabIndex = 14;
            BtnDelete.Text = "Excluir";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.FromArgb(255, 128, 0);
            BtnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnSearch.ForeColor = Color.White;
            BtnSearch.Image = Properties.Resources.search;
            BtnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearch.Location = new Point(162, 577);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Padding = new Padding(8, 0, 0, 0);
            BtnSearch.RightToLeft = RightToLeft.No;
            BtnSearch.Size = new Size(128, 38);
            BtnSearch.TabIndex = 13;
            BtnSearch.Text = "Pesquisar";
            BtnSearch.TextAlign = ContentAlignment.MiddleRight;
            BtnSearch.UseVisualStyleBackColor = false;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            BtnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            BtnUpdate.ForeColor = Color.White;
            BtnUpdate.Location = new Point(377, 577);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(128, 38);
            BtnUpdate.TabIndex = 14;
            BtnUpdate.Text = "Alterar";
            BtnUpdate.UseVisualStyleBackColor = false;
            BtnUpdate.Click += BtnAtualizar_Click;
            // 
            // FormMovEstoque
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 627);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnDelete);
            Controls.Add(BtnSearch);
            Controls.Add(BtnInclude);
            Controls.Add(TxtObs);
            Controls.Add(label6);
            Controls.Add(TxtQty);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(DtpMov);
            Controls.Add(lblDesc);
            Controls.Add(TxtCodProd);
            Controls.Add(label3);
            Controls.Add(TxtCodMov);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormMovEstoque";
            Text = "FormMovEstoque";
            ((System.ComponentModel.ISupportInitialize)TxtCodMov).EndInit( );
            ((System.ComponentModel.ISupportInitialize)TxtCodProd).EndInit( );
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout( );
            ((System.ComponentModel.ISupportInitialize)TxtQty).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown TxtCodMov;
        private NumericUpDown TxtCodProd;
        private Label label3;
        private Label lblDesc;
        private DateTimePicker DtpMov;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton RdbOut;
        private RadioButton RdbIn;
        private Label label5;
        private NumericUpDown TxtQty;
        private Label label6;
        private TextBox TxtObs;
        private Button BtnInclude;
        private Button BtnDelete;
        private Button BtnSearch;
        private Button BtnUpdate;
    }
}