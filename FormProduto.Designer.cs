namespace Estoque
{
    partial class FormProduto
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
            lblTitle = new Label( );
            label1 = new Label( );
            TxtDesc = new TextBox( );
            label2 = new Label( );
            label3 = new Label( );
            TxtValue = new MaskedTextBox( );
            label4 = new Label( );
            DtpExp = new DateTimePicker( );
            BtnAdd = new Button( );
            BtnDelete = new Button( );
            BtnSearch = new Button( );
            TxtCod = new NumericUpDown( );
            DtgTable = new DataGridView( );
            btnClear = new Button( );
            ((System.ComponentModel.ISupportInitialize)TxtCod).BeginInit( );
            ((System.ComponentModel.ISupportInitialize)DtgTable).BeginInit( );
            SuspendLayout( );
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(617, 57);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cadastro de Produto";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 83);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 1;
            label1.Text = "Código do Produto";
            // 
            // TxtDesc
            // 
            TxtDesc.Location = new Point(195, 140);
            TxtDesc.Name = "TxtDesc";
            TxtDesc.RightToLeft = RightToLeft.No;
            TxtDesc.Size = new Size(410, 33);
            TxtDesc.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 143);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 6;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 203);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(82, 25);
            label3.TabIndex = 8;
            label3.Text = "Valor R$";
            // 
            // TxtValue
            // 
            TxtValue.Location = new Point(195, 200);
            TxtValue.Mask = "99999,99";
            TxtValue.Name = "TxtValue";
            TxtValue.RightToLeft = RightToLeft.No;
            TxtValue.Size = new Size(88, 33);
            TxtValue.TabIndex = 9;
            TxtValue.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 263);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 10;
            label4.Text = "Vencimento";
            // 
            // DtpExp
            // 
            DtpExp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DtpExp.Cursor = Cursors.Hand;
            DtpExp.Format = DateTimePickerFormat.Short;
            DtpExp.Location = new Point(195, 260);
            DtpExp.Name = "DtpExp";
            DtpExp.RightToLeft = RightToLeft.No;
            DtpExp.Size = new Size(180, 33);
            DtpExp.TabIndex = 11;
            // 
            // BtnAdd
            // 
            BtnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnAdd.BackColor = Color.FromArgb(0, 0, 192);
            BtnAdd.Cursor = Cursors.Hand;
            BtnAdd.ForeColor = Color.White;
            BtnAdd.Location = new Point(157, 324);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(150, 50);
            BtnAdd.TabIndex = 12;
            BtnAdd.Text = "INCLUIR";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BtnDelete.BackColor = Color.Red;
            BtnDelete.Cursor = Cursors.Hand;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.ForeColor = Color.White;
            BtnDelete.Location = new Point(313, 324);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(150, 50);
            BtnDelete.TabIndex = 13;
            BtnDelete.Text = "EXCLUIR";
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnSearch
            // 
            BtnSearch.Cursor = Cursors.Hand;
            BtnSearch.Dock = DockStyle.Bottom;
            BtnSearch.Image = Properties.Resources.search;
            BtnSearch.Location = new Point(0, 565);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(617, 51);
            BtnSearch.TabIndex = 14;
            BtnSearch.Text = "Pesquisar";
            BtnSearch.TextAlign = ContentAlignment.MiddleRight;
            BtnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtCod
            // 
            TxtCod.Location = new Point(195, 83);
            TxtCod.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            TxtCod.Name = "TxtCod";
            TxtCod.Size = new Size(410, 33);
            TxtCod.TabIndex = 16;
            TxtCod.TextAlign = HorizontalAlignment.Right;
            TxtCod.MouseDown += TxtCod_MouseDown;
            TxtCod.MouseUp += TxtCod_MouseUp;
            // 
            // DtgTable
            // 
            DtgTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtgTable.Location = new Point(12, 380);
            DtgTable.Name = "DtgTable";
            DtgTable.Size = new Size(593, 179);
            DtgTable.TabIndex = 17;
            DtgTable.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(501, 23);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(104, 34);
            btnClear.TabIndex = 18;
            btnClear.Text = "Limpar";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 616);
            Controls.Add(btnClear);
            Controls.Add(DtgTable);
            Controls.Add(TxtCod);
            Controls.Add(BtnSearch);
            Controls.Add(BtnDelete);
            Controls.Add(BtnAdd);
            Controls.Add(DtpExp);
            Controls.Add(label4);
            Controls.Add(TxtValue);
            Controls.Add(label3);
            Controls.Add(TxtDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormProduto";
            Text = "FormProduto";
            ((System.ComponentModel.ISupportInitialize)TxtCod).EndInit( );
            ((System.ComponentModel.ISupportInitialize)DtgTable).EndInit( );
            ResumeLayout(false);
            PerformLayout( );
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private TextBox TxtDesc;
        private Label label2;
        private Label label3;
        private MaskedTextBox TxtValue;
        private Label label4;
        private DateTimePicker DtpExp;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnSearch;
        private NumericUpDown TxtCod;
        private DataGridView DtgTable;
        private Button btnClear;
    }
}