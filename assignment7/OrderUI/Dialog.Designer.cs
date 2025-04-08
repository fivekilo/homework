namespace OrderUI
{
    partial class Dialog
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
            tableLayoutPanel1 = new TableLayoutPanel();
            GoodsLabel = new Label();
            CustomerLabel = new Label();
            IDlabel = new Label();
            Goods = new TextBox();
            Customer = new TextBox();
            ID = new TextBox();
            ConfirmBtn = new Button();
            CancelBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(ID, 1, 0);
            tableLayoutPanel1.Controls.Add(Customer, 1, 1);
            tableLayoutPanel1.Controls.Add(GoodsLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(CustomerLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(IDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(Goods, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(754, 403);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // GoodsLabel
            // 
            GoodsLabel.Dock = DockStyle.Fill;
            GoodsLabel.Location = new Point(4, 161);
            GoodsLabel.Name = "GoodsLabel";
            GoodsLabel.Size = new Size(219, 241);
            GoodsLabel.TabIndex = 4;
            GoodsLabel.Text = "商品与价格";
            GoodsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Dock = DockStyle.Fill;
            CustomerLabel.Location = new Point(4, 81);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.RightToLeft = RightToLeft.No;
            CustomerLabel.Size = new Size(219, 79);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "客户";
            CustomerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Dock = DockStyle.Fill;
            IDlabel.Location = new Point(4, 1);
            IDlabel.Name = "IDlabel";
            IDlabel.RightToLeft = RightToLeft.No;
            IDlabel.Size = new Size(219, 79);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "ID";
            IDlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Goods
            // 
            Goods.AcceptsReturn = true;
            Goods.AcceptsTab = true;
            Goods.Dock = DockStyle.Fill;
            Goods.Location = new Point(230, 164);
            Goods.Multiline = true;
            Goods.Name = "Goods";
            Goods.Size = new Size(520, 235);
            Goods.TabIndex = 5;
            // 
            // Customer
            // 
            Customer.AcceptsReturn = true;
            Customer.AcceptsTab = true;
            Customer.Dock = DockStyle.Fill;
            Customer.Location = new Point(230, 84);
            Customer.Multiline = true;
            Customer.Name = "Customer";
            Customer.Size = new Size(520, 73);
            Customer.TabIndex = 6;
            // 
            // ID
            // 
            ID.AcceptsReturn = true;
            ID.AcceptsTab = true;
            ID.Dock = DockStyle.Fill;
            ID.Location = new Point(230, 4);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new Size(520, 73);
            ID.TabIndex = 7;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.Location = new Point(138, 448);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(75, 23);
            ConfirmBtn.TabIndex = 2;
            ConfirmBtn.Text = "确定";
            ConfirmBtn.UseVisualStyleBackColor = true;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(553, 448);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(75, 23);
            CancelBtn.TabIndex = 3;
            CancelBtn.Text = "取消";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // Dialog
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 483);
            Controls.Add(CancelBtn);
            Controls.Add(ConfirmBtn);
            Controls.Add(tableLayoutPanel1);
            Name = "Dialog";
            Text = "Form2";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label GoodsLabel;
        private Label CustomerLabel;
        private Label IDlabel;
        private TextBox Goods;
        private TextBox ID;
        private TextBox Customer;
        private Button ConfirmBtn;
        private Button CancelBtn;
    }
}