namespace PBL3_Guna
{
    partial class UC_Table
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvStaff = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnModifyItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.txtDisplayName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserNameStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDStaff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dtgvStaff);
            this.panel1.Controls.Add(this.btnModifyItem);
            this.panel1.Controls.Add(this.btnDeleteItem);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 689);
            this.panel1.TabIndex = 1;
            // 
            // dtgvStaff
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.dtgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvStaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvStaff.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvStaff.DefaultCellStyle = dataGridViewCellStyle12;
            this.dtgvStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvStaff.EnableHeadersVisualStyles = false;
            this.dtgvStaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dtgvStaff.Location = new System.Drawing.Point(0, 0);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersVisible = false;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStaff.Size = new System.Drawing.Size(628, 488);
            this.dtgvStaff.TabIndex = 1;
            this.dtgvStaff.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvStaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvStaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvStaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvStaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvStaff.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.dtgvStaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dtgvStaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.dtgvStaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvStaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvStaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.dtgvStaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvStaff.ThemeStyle.HeaderStyle.Height = 4;
            this.dtgvStaff.ThemeStyle.ReadOnly = true;
            this.dtgvStaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvStaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvStaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvStaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvStaff.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvStaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvStaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnModifyItem
            // 
            this.btnModifyItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyItem.Animated = true;
            this.btnModifyItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyItem.BorderRadius = 10;
            this.btnModifyItem.BorderThickness = 1;
            this.btnModifyItem.CheckedState.Parent = this.btnModifyItem;
            this.btnModifyItem.CustomImages.Parent = this.btnModifyItem;
            this.btnModifyItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnModifyItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyItem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnModifyItem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnModifyItem.HoverState.Parent = this.btnModifyItem;
            this.btnModifyItem.Location = new System.Drawing.Point(388, 557);
            this.btnModifyItem.Name = "btnModifyItem";
            this.btnModifyItem.ShadowDecoration.Parent = this.btnModifyItem;
            this.btnModifyItem.Size = new System.Drawing.Size(97, 42);
            this.btnModifyItem.TabIndex = 30;
            this.btnModifyItem.Text = "Modify";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteItem.Animated = true;
            this.btnDeleteItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteItem.BorderRadius = 10;
            this.btnDeleteItem.BorderThickness = 1;
            this.btnDeleteItem.CheckedState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.CustomImages.Parent = this.btnDeleteItem;
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnDeleteItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteItem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteItem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnDeleteItem.HoverState.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Location = new System.Drawing.Point(253, 557);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.ShadowDecoration.Parent = this.btnDeleteItem;
            this.btnDeleteItem.Size = new System.Drawing.Size(97, 42);
            this.btnDeleteItem.TabIndex = 29;
            this.btnDeleteItem.Text = "Delete";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddItem.Animated = true;
            this.btnAddItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.BorderThickness = 1;
            this.btnAddItem.CheckedState.Parent = this.btnAddItem;
            this.btnAddItem.CustomImages.Parent = this.btnAddItem;
            this.btnAddItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnAddItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddItem.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddItem.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnAddItem.HoverState.Parent = this.btnAddItem;
            this.btnAddItem.Location = new System.Drawing.Point(121, 557);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ShadowDecoration.Parent = this.btnAddItem;
            this.btnAddItem.Size = new System.Drawing.Size(97, 42);
            this.btnAddItem.TabIndex = 28;
            this.btnAddItem.Text = "Add";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDisplayName.BorderColor = System.Drawing.Color.White;
            this.txtDisplayName.BorderRadius = 6;
            this.txtDisplayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisplayName.DefaultText = "";
            this.txtDisplayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDisplayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDisplayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisplayName.DisabledState.Parent = this.txtDisplayName;
            this.txtDisplayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDisplayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtDisplayName.FocusedState.Parent = this.txtDisplayName;
            this.txtDisplayName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtDisplayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDisplayName.HoverState.Parent = this.txtDisplayName;
            this.txtDisplayName.Location = new System.Drawing.Point(752, 182);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.PasswordChar = '\0';
            this.txtDisplayName.PlaceholderText = "";
            this.txtDisplayName.SelectedText = "";
            this.txtDisplayName.ShadowDecoration.Parent = this.txtDisplayName;
            this.txtDisplayName.Size = new System.Drawing.Size(173, 24);
            this.txtDisplayName.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(692, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Status:";
            // 
            // txtUserNameStaff
            // 
            this.txtUserNameStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserNameStaff.BorderColor = System.Drawing.Color.White;
            this.txtUserNameStaff.BorderRadius = 6;
            this.txtUserNameStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameStaff.DefaultText = "";
            this.txtUserNameStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameStaff.DisabledState.Parent = this.txtUserNameStaff;
            this.txtUserNameStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtUserNameStaff.FocusedState.Parent = this.txtUserNameStaff;
            this.txtUserNameStaff.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtUserNameStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameStaff.HoverState.Parent = this.txtUserNameStaff;
            this.txtUserNameStaff.Location = new System.Drawing.Point(752, 123);
            this.txtUserNameStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserNameStaff.Name = "txtUserNameStaff";
            this.txtUserNameStaff.PasswordChar = '\0';
            this.txtUserNameStaff.PlaceholderText = "";
            this.txtUserNameStaff.SelectedText = "";
            this.txtUserNameStaff.ShadowDecoration.Parent = this.txtUserNameStaff;
            this.txtUserNameStaff.Size = new System.Drawing.Size(173, 24);
            this.txtUserNameStaff.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(648, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "TableName:";
            // 
            // txtIDStaff
            // 
            this.txtIDStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDStaff.BorderColor = System.Drawing.Color.White;
            this.txtIDStaff.BorderRadius = 6;
            this.txtIDStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDStaff.DefaultText = "";
            this.txtIDStaff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDStaff.DisabledState.Parent = this.txtIDStaff;
            this.txtIDStaff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDStaff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtIDStaff.FocusedState.Parent = this.txtIDStaff;
            this.txtIDStaff.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtIDStaff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDStaff.HoverState.Parent = this.txtIDStaff;
            this.txtIDStaff.Location = new System.Drawing.Point(752, 64);
            this.txtIDStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDStaff.Name = "txtIDStaff";
            this.txtIDStaff.PasswordChar = '\0';
            this.txtIDStaff.PlaceholderText = "";
            this.txtIDStaff.SelectedText = "";
            this.txtIDStaff.ShadowDecoration.Parent = this.txtIDStaff;
            this.txtIDStaff.Size = new System.Drawing.Size(173, 24);
            this.txtIDStaff.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(718, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // UC_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDStaff);
            this.Controls.Add(this.txtUserNameStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "UC_Table";
            this.Size = new System.Drawing.Size(941, 689);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvStaff;
        private Guna.UI2.WinForms.Guna2Button btnModifyItem;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private Guna.UI2.WinForms.Guna2TextBox txtDisplayName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameStaff;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIDStaff;
        private System.Windows.Forms.Label label1;
    }
}
