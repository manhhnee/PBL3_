namespace PBL3_Guna
{
    partial class AddCategory
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
            this.txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCategory.BorderRadius = 6;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.DefaultText = "";
            this.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.DisabledState.Parent = this.txtCategory;
            this.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.FocusedState.Parent = this.txtCategory;
            this.txtCategory.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategory.HoverState.Parent = this.txtCategory;
            this.txtCategory.Location = new System.Drawing.Point(148, 39);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PlaceholderText = "";
            this.txtCategory.SelectedText = "";
            this.txtCategory.ShadowDecoration.Parent = this.txtCategory;
            this.txtCategory.Size = new System.Drawing.Size(211, 24);
            this.txtCategory.TabIndex = 32;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Name Category:";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnExit.BorderRadius = 10;
            this.btnExit.BorderThickness = 2;
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnExit.HoverState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(221, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(109, 45);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderThickness = 2;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(148)))), ((int)(((byte)(97)))));
            this.btnLogin.HoverState.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(40, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(109, 45);
            this.btnLogin.TabIndex = 45;
            this.btnLogin.Text = "Add";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(216)))), ((int)(((byte)(176)))));
            this.ClientSize = new System.Drawing.Size(370, 173);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}