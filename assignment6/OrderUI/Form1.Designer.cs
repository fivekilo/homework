namespace OrderUI
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            StateLabel = new Label();
            Goods = new Label();
            GoodsLabel = new Label();
            Customer = new Label();
            CustomerLabel = new Label();
            IDlabel = new Label();
            ID = new Label();
            BackBtn = new Button();
            NextBtn = new Button();
            AddBtn = new Button();
            RemoveBtn = new Button();
            ModifyBtn = new Button();
            QueryBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Controls.Add(StateLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(Goods, 1, 2);
            tableLayoutPanel1.Controls.Add(GoodsLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(Customer, 1, 1);
            tableLayoutPanel1.Controls.Add(CustomerLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(IDlabel, 0, 0);
            tableLayoutPanel1.Controls.Add(ID, 1, 0);
            tableLayoutPanel1.Controls.Add(BackBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(NextBtn, 2, 0);
            tableLayoutPanel1.Location = new Point(1, 58);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(711, 491);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // StateLabel
            // 
            StateLabel.AutoSize = true;
            StateLabel.Dock = DockStyle.Fill;
            StateLabel.Location = new Point(640, 197);
            StateLabel.Name = "StateLabel";
            StateLabel.Size = new Size(67, 293);
            StateLabel.TabIndex = 8;
            StateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Goods
            // 
            Goods.AutoSize = true;
            Goods.Dock = DockStyle.Fill;
            Goods.Location = new Point(195, 197);
            Goods.Name = "Goods";
            Goods.Size = new Size(438, 293);
            Goods.TabIndex = 5;
            Goods.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GoodsLabel
            // 
            GoodsLabel.Dock = DockStyle.Fill;
            GoodsLabel.Location = new Point(4, 197);
            GoodsLabel.Name = "GoodsLabel";
            GoodsLabel.Size = new Size(184, 293);
            GoodsLabel.TabIndex = 4;
            GoodsLabel.Text = "商品与价格";
            GoodsLabel.TextAlign = ContentAlignment.MiddleCenter;
            GoodsLabel.Click += label1_Click_1;
            // 
            // Customer
            // 
            Customer.AutoSize = true;
            Customer.Dock = DockStyle.Fill;
            Customer.Location = new Point(195, 99);
            Customer.Name = "Customer";
            Customer.Size = new Size(438, 97);
            Customer.TabIndex = 3;
            Customer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Dock = DockStyle.Fill;
            CustomerLabel.Location = new Point(4, 99);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.RightToLeft = RightToLeft.No;
            CustomerLabel.Size = new Size(184, 97);
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
            IDlabel.Size = new Size(184, 97);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "ID";
            IDlabel.TextAlign = ContentAlignment.MiddleCenter;
            IDlabel.Click += label1_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Dock = DockStyle.Fill;
            ID.Location = new Point(195, 1);
            ID.Name = "ID";
            ID.Size = new Size(438, 97);
            ID.TabIndex = 1;
            ID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(640, 102);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(67, 23);
            BackBtn.TabIndex = 7;
            BackBtn.Text = "上一订单";
            BackBtn.UseVisualStyleBackColor = true;
            // 
            // NextBtn
            // 
            NextBtn.Location = new Point(640, 4);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(67, 23);
            NextBtn.TabIndex = 6;
            NextBtn.Text = "下一订单";
            NextBtn.UseVisualStyleBackColor = true;
            NextBtn.Click += button1_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 12);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "添加订单";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += button1_Click_1;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(93, 12);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(75, 23);
            RemoveBtn.TabIndex = 2;
            RemoveBtn.Text = "删除订单";
            RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Location = new Point(174, 12);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(75, 23);
            ModifyBtn.TabIndex = 3;
            ModifyBtn.Text = "修改订单";
            ModifyBtn.UseVisualStyleBackColor = true;
            // 
            // QueryBtn
            // 
            QueryBtn.Location = new Point(255, 12);
            QueryBtn.Name = "QueryBtn";
            QueryBtn.Size = new Size(75, 23);
            QueryBtn.TabIndex = 4;
            QueryBtn.Text = "查询订单";
            QueryBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(716, 549);
            Controls.Add(QueryBtn);
            Controls.Add(ModifyBtn);
            Controls.Add(RemoveBtn);
            Controls.Add(AddBtn);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label IDlabel;
        private Label ID;
        private Label CustomerLabel;
        private Label Customer;
        private Label GoodsLabel;
        private Label Goods;
        private Button BackBtn;
        private Button NextBtn;
        private Label StateLabel;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button ModifyBtn;
        private Button QueryBtn;
    }
}