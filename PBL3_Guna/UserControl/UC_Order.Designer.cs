namespace PBL3_Guna
{
    partial class UC_Order
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.nmItemAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.txbTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSwapTable = new Guna.UI2.WinForms.Guna2Button();
            this.nmDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbSwapTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lvBill = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemAmount)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(231)))));
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(700, 750);
            this.flpTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 750);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.nmItemAmount);
            this.panel2.Controls.Add(this.cbItem);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(700, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Animated = true;
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.CheckedState.Parent = this.btnAddItem;
            this.btnAddItem.CustomImages.Parent = this.btnAddItem;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAddItem.ForeColor = System.Drawing.Color.Black;
            this.btnAddItem.HoverState.Parent = this.btnAddItem;
            this.btnAddItem.Location = new System.Drawing.Point(335, 53);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ShadowDecoration.Parent = this.btnAddItem;
            this.btnAddItem.Size = new System.Drawing.Size(167, 44);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add Items";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // nmItemAmount
            // 
            this.nmItemAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmItemAmount.AutoRoundedCorners = true;
            this.nmItemAmount.BackColor = System.Drawing.Color.Transparent;
            this.nmItemAmount.BorderRadius = 21;
            this.nmItemAmount.CausesValidation = false;
            this.nmItemAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmItemAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmItemAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmItemAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmItemAmount.DisabledState.Parent = this.nmItemAmount;
            this.nmItemAmount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nmItemAmount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nmItemAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmItemAmount.FocusedState.Parent = this.nmItemAmount;
            this.nmItemAmount.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nmItemAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nmItemAmount.Location = new System.Drawing.Point(256, 53);
            this.nmItemAmount.Margin = new System.Windows.Forms.Padding(4);
            this.nmItemAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmItemAmount.Name = "nmItemAmount";
            this.nmItemAmount.ShadowDecoration.Parent = this.nmItemAmount;
            this.nmItemAmount.Size = new System.Drawing.Size(71, 44);
            this.nmItemAmount.TabIndex = 2;
            this.nmItemAmount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
            this.nmItemAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbItem
            // 
            this.cbItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbItem.Animated = true;
            this.cbItem.BackColor = System.Drawing.Color.Transparent;
            this.cbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbItem.BorderRadius = 6;
            this.cbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbItem.FocusedState.Parent = this.cbItem;
            this.cbItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbItem.HoverState.Parent = this.cbItem;
            this.cbItem.ItemHeight = 30;
            this.cbItem.ItemsAppearance.Parent = this.cbItem;
            this.cbItem.Location = new System.Drawing.Point(47, 84);
            this.cbItem.Margin = new System.Windows.Forms.Padding(4);
            this.cbItem.Name = "cbItem";
            this.cbItem.ShadowDecoration.Parent = this.cbItem;
            this.cbItem.Size = new System.Drawing.Size(200, 36);
            this.cbItem.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategory.Animated = true;
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbCategory.BorderRadius = 6;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCategory.FocusedState.Parent = this.cbCategory;
            this.cbCategory.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbCategory.HoverState.Parent = this.cbCategory;
            this.cbCategory.ItemHeight = 30;
            this.cbCategory.ItemsAppearance.Parent = this.cbCategory;
            this.cbCategory.Location = new System.Drawing.Point(47, 18);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.ShadowDecoration.Parent = this.cbCategory;
            this.cbCategory.Size = new System.Drawing.Size(200, 36);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.lvBill);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(700, 144);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(505, 606);
            this.guna2Panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.btnSwapTable);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.cbSwapTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 440);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 166);
            this.panel3.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.Animated = true;
            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Location = new System.Drawing.Point(335, 85);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(127, 44);
            this.btnCheckOut.TabIndex = 7;
            this.btnCheckOut.Text = "Payment";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalPrice.Animated = true;
            this.txbTotalPrice.BorderRadius = 6;
            this.txbTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTotalPrice.DefaultText = "";
            this.txbTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.DisabledState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.txbTotalPrice.FocusedState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.txbTotalPrice.HoverState.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Location = new System.Drawing.Point(273, 18);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.PasswordChar = '\0';
            this.txbTotalPrice.PlaceholderText = "0";
            this.txbTotalPrice.SelectedText = "";
            this.txbTotalPrice.ShadowDecoration.Parent = this.txbTotalPrice;
            this.txbTotalPrice.Size = new System.Drawing.Size(216, 44);
            this.txbTotalPrice.TabIndex = 6;
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSwapTable.Animated = true;
            this.btnSwapTable.BorderRadius = 10;
            this.btnSwapTable.CheckedState.Parent = this.btnSwapTable;
            this.btnSwapTable.CustomImages.Parent = this.btnSwapTable;
            this.btnSwapTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnSwapTable.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnSwapTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwapTable.HoverState.Parent = this.btnSwapTable;
            this.btnSwapTable.Location = new System.Drawing.Point(47, 85);
            this.btnSwapTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.ShadowDecoration.Parent = this.btnSwapTable;
            this.btnSwapTable.Size = new System.Drawing.Size(167, 44);
            this.btnSwapTable.TabIndex = 5;
            this.btnSwapTable.Text = "Change Table";
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmDiscount.AutoRoundedCorners = true;
            this.nmDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmDiscount.BorderRadius = 21;
            this.nmDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nmDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nmDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nmDiscount.DisabledState.Parent = this.nmDiscount;
            this.nmDiscount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nmDiscount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nmDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nmDiscount.FocusedState.Parent = this.nmDiscount;
            this.nmDiscount.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nmDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nmDiscount.Location = new System.Drawing.Point(256, 85);
            this.nmDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.ShadowDecoration.Parent = this.nmDiscount;
            this.nmDiscount.Size = new System.Drawing.Size(71, 44);
            this.nmDiscount.TabIndex = 5;
            this.nmDiscount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(160)))), ((int)(((byte)(87)))));
            // 
            // cbSwapTable
            // 
            this.cbSwapTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSwapTable.Animated = true;
            this.cbSwapTable.BackColor = System.Drawing.Color.Transparent;
            this.cbSwapTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbSwapTable.BorderRadius = 6;
            this.cbSwapTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSwapTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSwapTable.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwapTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSwapTable.FocusedState.Parent = this.cbSwapTable;
            this.cbSwapTable.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbSwapTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.cbSwapTable.HoverState.Parent = this.cbSwapTable;
            this.cbSwapTable.ItemHeight = 30;
            this.cbSwapTable.ItemsAppearance.Parent = this.cbSwapTable;
            this.cbSwapTable.Location = new System.Drawing.Point(29, 18);
            this.cbSwapTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwapTable.Name = "cbSwapTable";
            this.cbSwapTable.ShadowDecoration.Parent = this.cbSwapTable;
            this.cbSwapTable.Size = new System.Drawing.Size(200, 36);
            this.cbSwapTable.TabIndex = 5;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Quantity,
            this.Price,
            this.Total});
            this.lvBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvBill.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBill.FullRowSelect = true;
            this.lvBill.GridLines = true;
            this.lvBill.HideSelection = false;
            this.lvBill.HoverSelection = true;
            this.lvBill.Location = new System.Drawing.Point(0, 0);
            this.lvBill.Margin = new System.Windows.Forms.Padding(4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(505, 431);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.UseWaitCursor = true;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 138;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 61;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 69;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 169;
            // 
            // UC_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "UC_Order";
            this.Size = new System.Drawing.Size(1205, 750);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemAmount)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cbItem;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmItemAmount;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ListView lvBill;
        private new System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbSwapTable;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2TextBox txbTotalPrice;
        private Guna.UI2.WinForms.Guna2Button btnSwapTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmDiscount;
    }
}
