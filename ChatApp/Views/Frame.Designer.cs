namespace ChatApp.Views
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddNewGroup = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewChat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSetting = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pbUserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtSearchAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.dragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlConversations = new ChatApp.Views.Components.ScrollPanel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(18)))), ((int)(((byte)(30)))));
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.pictureBox3);
            this.pnlTop.Controls.Add(this.guna2ControlBox2);
            this.pnlTop.Controls.Add(this.guna2ControlBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Parent = this.pnlTop;
            this.pnlTop.Size = new System.Drawing.Size(860, 32);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chat App";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ChatApp.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(8, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(767, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(815, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 32);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.guna2Panel2.Controls.Add(this.btnAddNewGroup);
            this.guna2Panel2.Controls.Add(this.btnAddNewChat);
            this.guna2Panel2.Controls.Add(this.pnlConversations);
            this.guna2Panel2.Controls.Add(this.guna2Panel5);
            this.guna2Panel2.Controls.Add(this.txtSearchAccount);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 32);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(300, 548);
            this.guna2Panel2.TabIndex = 1;
            // 
            // btnAddNewGroup
            // 
            this.btnAddNewGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.btnAddNewGroup.CheckedState.Parent = this.btnAddNewGroup;
            this.btnAddNewGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewGroup.CustomImages.Parent = this.btnAddNewGroup;
            this.btnAddNewGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.btnAddNewGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewGroup.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewGroup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(6)))), ((int)(((byte)(200)))));
            this.btnAddNewGroup.HoverState.Image = global::ChatApp.Properties.Resources.newgrouphover;
            this.btnAddNewGroup.HoverState.Parent = this.btnAddNewGroup;
            this.btnAddNewGroup.Image = global::ChatApp.Properties.Resources.newgroup;
            this.btnAddNewGroup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewGroup.ImageOffset = new System.Drawing.Point(15, -9);
            this.btnAddNewGroup.Location = new System.Drawing.Point(68, 61);
            this.btnAddNewGroup.Name = "btnAddNewGroup";
            this.btnAddNewGroup.ShadowDecoration.Parent = this.btnAddNewGroup;
            this.btnAddNewGroup.Size = new System.Drawing.Size(69, 35);
            this.btnAddNewGroup.TabIndex = 10;
            this.btnAddNewGroup.Text = "Nhóm mới";
            this.btnAddNewGroup.TextOffset = new System.Drawing.Point(0, 8);
            this.btnAddNewGroup.Click += new System.EventHandler(this.btnAddNewGroup_Click);
            // 
            // btnAddNewChat
            // 
            this.btnAddNewChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.btnAddNewChat.CheckedState.Parent = this.btnAddNewChat;
            this.btnAddNewChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewChat.CustomImages.Parent = this.btnAddNewChat;
            this.btnAddNewChat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.btnAddNewChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewChat.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewChat.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(6)))), ((int)(((byte)(200)))));
            this.btnAddNewChat.HoverState.Image = global::ChatApp.Properties.Resources.newchathover;
            this.btnAddNewChat.HoverState.Parent = this.btnAddNewChat;
            this.btnAddNewChat.Image = global::ChatApp.Properties.Resources.newchat;
            this.btnAddNewChat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewChat.ImageOffset = new System.Drawing.Point(6, -9);
            this.btnAddNewChat.Location = new System.Drawing.Point(8, 61);
            this.btnAddNewChat.Name = "btnAddNewChat";
            this.btnAddNewChat.ShadowDecoration.Parent = this.btnAddNewChat;
            this.btnAddNewChat.Size = new System.Drawing.Size(54, 35);
            this.btnAddNewChat.TabIndex = 10;
            this.btnAddNewChat.Text = "Chat mới";
            this.btnAddNewChat.TextOffset = new System.Drawing.Point(0, 8);
            this.btnAddNewChat.Click += new System.EventHandler(this.btnAddNewChat_Click);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.guna2Panel5.Controls.Add(this.btnSetting);
            this.guna2Panel5.Controls.Add(this.label5);
            this.guna2Panel5.Controls.Add(this.lbUserName);
            this.guna2Panel5.Controls.Add(this.pbUserAvatar);
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(300, 55);
            this.guna2Panel5.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.Empty;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Image = global::ChatApp.Properties.Resources.setting;
            this.btnSetting.Location = new System.Drawing.Point(273, 14);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(19, 24);
            this.btnSetting.TabIndex = 9;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(53, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đang hoạt động";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbUserName.Location = new System.Drawing.Point(53, 7);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(112, 17);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "Tên người dùng";
            // 
            // pbUserAvatar
            // 
            this.pbUserAvatar.Image = global::ChatApp.Properties.Resources.avatar;
            this.pbUserAvatar.Location = new System.Drawing.Point(8, 7);
            this.pbUserAvatar.Name = "pbUserAvatar";
            this.pbUserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserAvatar.ShadowDecoration.Parent = this.pbUserAvatar;
            this.pbUserAvatar.Size = new System.Drawing.Size(40, 40);
            this.pbUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserAvatar.TabIndex = 6;
            this.pbUserAvatar.TabStop = false;
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearchAccount.BorderRadius = 8;
            this.txtSearchAccount.BorderThickness = 0;
            this.txtSearchAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchAccount.DefaultText = "";
            this.txtSearchAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.DisabledState.Parent = this.txtSearchAccount;
            this.txtSearchAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtSearchAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.FocusedState.Parent = this.txtSearchAccount;
            this.txtSearchAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearchAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchAccount.HoverState.Parent = this.txtSearchAccount;
            this.txtSearchAccount.IconLeftSize = new System.Drawing.Size(16, 16);
            this.txtSearchAccount.Location = new System.Drawing.Point(8, 102);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.PasswordChar = '\0';
            this.txtSearchAccount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchAccount.PlaceholderText = "Người dùng hoặc  nhóm chat";
            this.txtSearchAccount.SelectedText = "";
            this.txtSearchAccount.ShadowDecoration.Parent = this.txtSearchAccount;
            this.txtSearchAccount.Size = new System.Drawing.Size(284, 36);
            this.txtSearchAccount.TabIndex = 7;
            this.txtSearchAccount.TextOffset = new System.Drawing.Point(8, 0);
            this.txtSearchAccount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyUp);
            // 
            // pnlPages
            // 
            this.pnlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPages.Location = new System.Drawing.Point(300, 32);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(560, 548);
            this.pnlPages.TabIndex = 2;
            // 
            // dragControl1
            // 
            this.dragControl1.TargetControl = this.pnlTop;
            // 
            // pnlConversations
            // 
            this.pnlConversations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.pnlConversations.Location = new System.Drawing.Point(0, 144);
            this.pnlConversations.Name = "pnlConversations";
            this.pnlConversations.Size = new System.Drawing.Size(300, 392);
            this.pnlConversations.TabIndex = 9;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frame_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frame_FormClosed);
            this.Load += new System.EventHandler(this.Frame_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchAccount;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button btnSetting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbUserName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserAvatar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DragControl dragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnAddNewGroup;
        private Guna.UI2.WinForms.Guna2Button btnAddNewChat;
        public Components.ScrollPanel pnlConversations;
        public System.Windows.Forms.Panel pnlPages;
    }
}