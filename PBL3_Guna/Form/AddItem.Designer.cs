﻿namespace PBL3_Guna
{
    partial class AddItem
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.cxbCategoryItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNameItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.label3.Location = new System.Drawing.Point(65, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Category:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.label2.Location = new System.Drawing.Point(57, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(46, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(109, 45);
            this.btnAdd.TabIndex = 48;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderThickness = 2;
            this.btnExit.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnExit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(228, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(109, 45);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cxbCategoryItem
            // 
            this.cxbCategoryItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cxbCategoryItem.Animated = true;
            this.cxbCategoryItem.BackColor = System.Drawing.Color.Transparent;
            this.cxbCategoryItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.cxbCategoryItem.BorderRadius = 6;
            this.cxbCategoryItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cxbCategoryItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxbCategoryItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cxbCategoryItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cxbCategoryItem.FocusedState.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cxbCategoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.cxbCategoryItem.HoverState.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.ItemHeight = 30;
            this.cxbCategoryItem.ItemsAppearance.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Location = new System.Drawing.Point(135, 110);
            this.cxbCategoryItem.Name = "cxbCategoryItem";
            this.cxbCategoryItem.ShadowDecoration.Parent = this.cxbCategoryItem;
            this.cxbCategoryItem.Size = new System.Drawing.Size(212, 36);
            this.cxbCategoryItem.TabIndex = 50;
            // 
            // txtNameItem
            // 
            this.txtNameItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNameItem.BackColor = System.Drawing.Color.Transparent;
            this.txtNameItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtNameItem.BorderRadius = 8;
            this.txtNameItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameItem.DefaultText = "";
            this.txtNameItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItem.DisabledState.Parent = this.txtNameItem;
            this.txtNameItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtNameItem.FocusedState.Parent = this.txtNameItem;
            this.txtNameItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtNameItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameItem.HoverState.Parent = this.txtNameItem;
            this.txtNameItem.Location = new System.Drawing.Point(135, 45);
            this.txtNameItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.PasswordChar = '\0';
            this.txtNameItem.PlaceholderText = "Name";
            this.txtNameItem.SelectedText = "";
            this.txtNameItem.ShadowDecoration.Parent = this.txtNameItem;
            this.txtNameItem.Size = new System.Drawing.Size(213, 28);
            this.txtNameItem.TabIndex = 51;
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.Animated = true;
            this.txtPriceItem.BackColor = System.Drawing.Color.Transparent;
            this.txtPriceItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(124)))), ((int)(((byte)(84)))));
            this.txtPriceItem.BorderRadius = 8;
            this.txtPriceItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceItem.DefaultText = "";
            this.txtPriceItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(167)))), ((int)(((byte)(152)))));
            this.txtPriceItem.DisabledState.ForeColor = System.Drawing.Color.White;
            this.txtPriceItem.DisabledState.Parent = this.txtPriceItem;
            this.txtPriceItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtPriceItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtPriceItem.FocusedState.Parent = this.txtPriceItem;
            this.txtPriceItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.txtPriceItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(73)))), ((int)(((byte)(55)))));
            this.txtPriceItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(168)))), ((int)(((byte)(47)))));
            this.txtPriceItem.HoverState.Parent = this.txtPriceItem;
            this.txtPriceItem.Location = new System.Drawing.Point(135, 176);
            this.txtPriceItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.PasswordChar = '\0';
            this.txtPriceItem.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.txtPriceItem.PlaceholderText = "Price";
            this.txtPriceItem.SelectedText = "";
            this.txtPriceItem.ShadowDecoration.Parent = this.txtPriceItem;
            this.txtPriceItem.Size = new System.Drawing.Size(213, 28);
            this.txtPriceItem.TabIndex = 52;
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(387, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cxbCategoryItem);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.txtPriceItem);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox cxbCategoryItem;
        private Guna.UI2.WinForms.Guna2TextBox txtNameItem;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceItem;
    }
}