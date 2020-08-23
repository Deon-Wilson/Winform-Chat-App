namespace ChatApp.Views
{
    partial class AddNewGroup
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFirst = new System.Windows.Forms.Panel();
            this.btnContinue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtGroupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChangeAvatar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbGroupAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlLast = new System.Windows.Forms.Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreateGroup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlConversation = new ChatApp.Views.Components.ScrollPanel();
            this.pnlMember = new ChatApp.Views.Components.ScrollPanel();
            this.pnlFirst.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupAvatar)).BeginInit();
            this.pnlLast.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(405, 11);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 30);
            this.guna2ControlBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 36);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhóm chat mới";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFirst
            // 
            this.pnlFirst.Controls.Add(this.btnContinue);
            this.pnlFirst.Controls.Add(this.guna2Panel1);
            this.pnlFirst.Controls.Add(this.btnChangeAvatar);
            this.pnlFirst.Controls.Add(this.pbGroupAvatar);
            this.pnlFirst.Location = new System.Drawing.Point(0, 52);
            this.pnlFirst.Name = "pnlFirst";
            this.pnlFirst.Size = new System.Drawing.Size(450, 464);
            this.pnlFirst.TabIndex = 16;
            // 
            // btnContinue
            // 
            this.btnContinue.BorderRadius = 15;
            this.btnContinue.CheckedState.Parent = this.btnContinue;
            this.btnContinue.CustomImages.Parent = this.btnContinue;
            this.btnContinue.Enabled = false;
            this.btnContinue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnContinue.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnContinue.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnContinue.HoverState.Parent = this.btnContinue;
            this.btnContinue.Location = new System.Drawing.Point(310, 414);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.ShadowDecoration.Parent = this.btnContinue;
            this.btnContinue.Size = new System.Drawing.Size(120, 32);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.Controls.Add(this.txtGroupName);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Location = new System.Drawing.Point(20, 180);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(410, 40);
            this.guna2Panel1.TabIndex = 8;
            // 
            // txtGroupName
            // 
            this.txtGroupName.BorderThickness = 0;
            this.txtGroupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupName.DefaultText = "";
            this.txtGroupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.DisabledState.Parent = this.txtGroupName;
            this.txtGroupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.txtGroupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.FocusedState.Parent = this.txtGroupName;
            this.txtGroupName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.Color.White;
            this.txtGroupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupName.HoverState.Parent = this.txtGroupName;
            this.txtGroupName.Location = new System.Drawing.Point(5, 7);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PasswordChar = '\0';
            this.txtGroupName.PlaceholderText = "Nhập tên nhóm";
            this.txtGroupName.SelectedText = "";
            this.txtGroupName.ShadowDecoration.Parent = this.txtGroupName;
            this.txtGroupName.Size = new System.Drawing.Size(400, 30);
            this.txtGroupName.TabIndex = 0;
            this.txtGroupName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGroupName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGroupName_KeyUp);
            // 
            // btnChangeAvatar
            // 
            this.btnChangeAvatar.BorderRadius = 15;
            this.btnChangeAvatar.CheckedState.Parent = this.btnChangeAvatar;
            this.btnChangeAvatar.CustomImages.Parent = this.btnChangeAvatar;
            this.btnChangeAvatar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnChangeAvatar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnChangeAvatar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeAvatar.ForeColor = System.Drawing.Color.White;
            this.btnChangeAvatar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnChangeAvatar.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnChangeAvatar.HoverState.Parent = this.btnChangeAvatar;
            this.btnChangeAvatar.Location = new System.Drawing.Point(165, 136);
            this.btnChangeAvatar.Name = "btnChangeAvatar";
            this.btnChangeAvatar.ShadowDecoration.Parent = this.btnChangeAvatar;
            this.btnChangeAvatar.Size = new System.Drawing.Size(120, 30);
            this.btnChangeAvatar.TabIndex = 7;
            this.btnChangeAvatar.Text = "Thay đổi";
            this.btnChangeAvatar.Click += new System.EventHandler(this.btnChangeAvatar_Click);
            // 
            // pbGroupAvatar
            // 
            this.pbGroupAvatar.Image = global::ChatApp.Properties.Resources.groupavatar;
            this.pbGroupAvatar.Location = new System.Drawing.Point(165, 6);
            this.pbGroupAvatar.Name = "pbGroupAvatar";
            this.pbGroupAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbGroupAvatar.ShadowDecoration.Parent = this.pbGroupAvatar;
            this.pbGroupAvatar.Size = new System.Drawing.Size(120, 120);
            this.pbGroupAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGroupAvatar.TabIndex = 0;
            this.pbGroupAvatar.TabStop = false;
            // 
            // pnlLast
            // 
            this.pnlLast.Controls.Add(this.pnlConversation);
            this.pnlLast.Controls.Add(this.pnlMember);
            this.pnlLast.Controls.Add(this.btnBack);
            this.pnlLast.Controls.Add(this.btnCreateGroup);
            this.pnlLast.Location = new System.Drawing.Point(0, 52);
            this.pnlLast.Name = "pnlLast";
            this.pnlLast.Size = new System.Drawing.Size(450, 464);
            this.pnlLast.TabIndex = 17;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 15;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnBack.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnBack.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Location = new System.Drawing.Point(178, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(120, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Quay lại";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.BorderRadius = 15;
            this.btnCreateGroup.CheckedState.Parent = this.btnCreateGroup;
            this.btnCreateGroup.CustomImages.Parent = this.btnCreateGroup;
            this.btnCreateGroup.Enabled = false;
            this.btnCreateGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnCreateGroup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnCreateGroup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGroup.ForeColor = System.Drawing.Color.White;
            this.btnCreateGroup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnCreateGroup.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnCreateGroup.HoverState.Parent = this.btnCreateGroup;
            this.btnCreateGroup.Location = new System.Drawing.Point(310, 414);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.ShadowDecoration.Parent = this.btnCreateGroup;
            this.btnCreateGroup.Size = new System.Drawing.Size(120, 32);
            this.btnCreateGroup.TabIndex = 9;
            this.btnCreateGroup.Text = "Tạo nhóm";
            // 
            // pnlConversation
            // 
            this.pnlConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.pnlConversation.Location = new System.Drawing.Point(0, 66);
            this.pnlConversation.Name = "pnlConversation";
            this.pnlConversation.Size = new System.Drawing.Size(450, 337);
            this.pnlConversation.TabIndex = 11;
            // 
            // pnlMember
            // 
            this.pnlMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.pnlMember.Location = new System.Drawing.Point(15, 0);
            this.pnlMember.Name = "pnlMember";
            this.pnlMember.Size = new System.Drawing.Size(420, 60);
            this.pnlMember.TabIndex = 10;
            // 
            // AddNewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(450, 516);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlFirst);
            this.Controls.Add(this.pnlLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewGroup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewGroup";
            this.Load += new System.EventHandler(this.AddNewGroup_Load);
            this.pnlFirst.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupAvatar)).EndInit();
            this.pnlLast.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFirst;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbGroupAvatar;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangeAvatar;
        private Guna.UI2.WinForms.Guna2GradientButton btnContinue;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel pnlLast;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateGroup;
        private Components.ScrollPanel pnlConversation;
        private Components.ScrollPanel pnlMember;
        private Guna.UI2.WinForms.Guna2GradientButton btnBack;
        public Guna.UI2.WinForms.Guna2TextBox txtGroupName;
    }
}