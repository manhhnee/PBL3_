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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnModifyTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTable = new Guna.UI2.WinForms.Guna2Button();
            this.txtTableName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDTable = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dtgvTable);
            this.panel1.Controls.Add(this.btnModifyTable);
            this.panel1.Controls.Add(this.btnDeleteTable);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 848);
            this.panel1.TabIndex = 1;
            // 
            // dtgvTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTable.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvTable.EnableHeadersVisualStyles = false;
            this.dtgvTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dtgvTable.Location = new System.Drawing.Point(0, 0);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.ReadOnly = true;
            this.dtgvTable.RowHeadersVisible = false;
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTable.Size = new System.Drawing.Size(837, 601);
            this.dtgvTable.TabIndex = 1;
            this.dtgvTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.dtgvTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.dtgvTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.dtgvTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dtgvTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.dtgvTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvTable.ThemeStyle.HeaderStyle.Height = 24;
            this.dtgvTable.ThemeStyle.ReadOnly = true;
            this.dtgvTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTable.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTable.SelectionChanged += new System.EventHandler(this.dtgvTable_SelectionChanged);
            // 
            // btnModifyTable
            // 
            this.btnModifyTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyTable.Animated = true;
            this.btnModifyTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyTable.BorderRadius = 10;
            this.btnModifyTable.BorderThickness = 1;
            this.btnModifyTable.CheckedState.Parent = this.btnModifyTable;
            this.btnModifyTable.CustomImages.Parent = this.btnModifyTable;
            this.btnModifyTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnModifyTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnModifyTable.HoverState.FillColor = System.Drawing.Color.White;
            this.btnModifyTable.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnModifyTable.HoverState.Parent = this.btnModifyTable;
            this.btnModifyTable.Location = new System.Drawing.Point(492, 699);
            this.btnModifyTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyTable.Name = "btnModifyTable";
            this.btnModifyTable.ShadowDecoration.Parent = this.btnModifyTable;
            this.btnModifyTable.Size = new System.Drawing.Size(129, 52);
            this.btnModifyTable.TabIndex = 30;
            this.btnModifyTable.Text = "Modify";
            this.btnModifyTable.Click += new System.EventHandler(this.btnModifyTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTable.Animated = true;
            this.btnDeleteTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteTable.BorderRadius = 10;
            this.btnDeleteTable.BorderThickness = 1;
            this.btnDeleteTable.CheckedState.Parent = this.btnDeleteTable;
            this.btnDeleteTable.CustomImages.Parent = this.btnDeleteTable;
            this.btnDeleteTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnDeleteTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnDeleteTable.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteTable.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnDeleteTable.HoverState.Parent = this.btnDeleteTable;
            this.btnDeleteTable.Location = new System.Drawing.Point(312, 699);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.ShadowDecoration.Parent = this.btnDeleteTable;
            this.btnDeleteTable.Size = new System.Drawing.Size(129, 52);
            this.btnDeleteTable.TabIndex = 29;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTable.Animated = true;
            this.btnAddTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddTable.BorderRadius = 10;
            this.btnAddTable.BorderThickness = 1;
            this.btnAddTable.CheckedState.Parent = this.btnAddTable;
            this.btnAddTable.CustomImages.Parent = this.btnAddTable;
            this.btnAddTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.btnAddTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAddTable.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddTable.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.btnAddTable.HoverState.Parent = this.btnAddTable;
            this.btnAddTable.Location = new System.Drawing.Point(136, 699);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.ShadowDecoration.Parent = this.btnAddTable;
            this.btnAddTable.Size = new System.Drawing.Size(129, 52);
            this.btnAddTable.TabIndex = 28;
            this.btnAddTable.Text = "Add";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTableName.BorderColor = System.Drawing.Color.White;
            this.txtTableName.BorderRadius = 6;
            this.txtTableName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTableName.DefaultText = "";
            this.txtTableName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTableName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTableName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.DisabledState.Parent = this.txtTableName;
            this.txtTableName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtTableName.FocusedState.Parent = this.txtTableName;
            this.txtTableName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtTableName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTableName.HoverState.Parent = this.txtTableName;
            this.txtTableName.Location = new System.Drawing.Point(1004, 378);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.PasswordChar = '\0';
            this.txtTableName.PlaceholderText = "";
            this.txtTableName.SelectedText = "";
            this.txtTableName.ShadowDecoration.Parent = this.txtTableName;
            this.txtTableName.Size = new System.Drawing.Size(231, 30);
            this.txtTableName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(865, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "TableName:";
            // 
            // txtIDTable
            // 
            this.txtIDTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIDTable.BorderColor = System.Drawing.Color.White;
            this.txtIDTable.BorderRadius = 6;
            this.txtIDTable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDTable.DefaultText = "";
            this.txtIDTable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTable.DisabledState.Parent = this.txtIDTable;
            this.txtIDTable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDTable.Enabled = false;
            this.txtIDTable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtIDTable.FocusedState.Parent = this.txtIDTable;
            this.txtIDTable.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtIDTable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDTable.HoverState.Parent = this.txtIDTable;
            this.txtIDTable.Location = new System.Drawing.Point(1001, 289);
            this.txtIDTable.Margin = new System.Windows.Forms.Padding(5);
            this.txtIDTable.Name = "txtIDTable";
            this.txtIDTable.PasswordChar = '\0';
            this.txtIDTable.PlaceholderText = "";
            this.txtIDTable.SelectedText = "";
            this.txtIDTable.ShadowDecoration.Parent = this.txtIDTable;
            this.txtIDTable.Size = new System.Drawing.Size(231, 30);
            this.txtIDTable.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(955, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID:";
            // 
            // UC_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIDTable);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_Table";
            this.Size = new System.Drawing.Size(1255, 848);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvTable;
        private Guna.UI2.WinForms.Guna2Button btnModifyTable;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTable;
        private Guna.UI2.WinForms.Guna2Button btnAddTable;
        private Guna.UI2.WinForms.Guna2TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIDTable;
        private System.Windows.Forms.Label label1;
    }
}
