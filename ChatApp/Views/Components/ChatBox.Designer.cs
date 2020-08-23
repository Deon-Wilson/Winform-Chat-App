namespace ChatApp.Views.Components
{
    partial class ChatBox
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
            this.sendBox = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnChooseAllFile = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnChoosePicture = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSend = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlTop = new Guna.UI2.WinForms.Guna2Panel();
            this.lbNumMember = new System.Windows.Forms.LinkLabel();
            this.btnAddMember = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbTitle = new System.Windows.Forms.Label();
            this.messageBox = new ChatApp.Views.Components.ScrollPanel();
            this.sendBox.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendBox
            // 
            this.sendBox.Controls.Add(this.guna2Panel1);
            this.sendBox.Controls.Add(this.btnChooseAllFile);
            this.sendBox.Controls.Add(this.btnChoosePicture);
            this.sendBox.Controls.Add(this.btnSend);
            this.sendBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sendBox.Location = new System.Drawing.Point(0, 478);
            this.sendBox.Name = "sendBox";
            this.sendBox.ShadowDecoration.Parent = this.sendBox;
            this.sendBox.Size = new System.Drawing.Size(560, 70);
            this.sendBox.TabIndex = 1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.txtMessage);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.guna2Panel1.Location = new System.Drawing.Point(24, 14);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(357, 45);
            this.guna2Panel1.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtMessage.BorderThickness = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.Parent = this.txtMessage;
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.FocusedState.Parent = this.txtMessage;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.HoverState.Parent = this.txtMessage;
            this.txtMessage.Location = new System.Drawing.Point(22, 10);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderText = "Nhập một tin nhắn";
            this.txtMessage.SelectedText = "";
            this.txtMessage.ShadowDecoration.Parent = this.txtMessage;
            this.txtMessage.Size = new System.Drawing.Size(315, 26);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyUp);
            // 
            // btnChooseAllFile
            // 
            this.btnChooseAllFile.CheckedState.Parent = this.btnChooseAllFile;
            this.btnChooseAllFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseAllFile.CustomImages.Parent = this.btnChooseAllFile;
            this.btnChooseAllFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnChooseAllFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseAllFile.ForeColor = System.Drawing.Color.White;
            this.btnChooseAllFile.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnChooseAllFile.HoverState.Image = global::ChatApp.Properties.Resources.attachhover;
            this.btnChooseAllFile.HoverState.Parent = this.btnChooseAllFile;
            this.btnChooseAllFile.Image = global::ChatApp.Properties.Resources.attach;
            this.btnChooseAllFile.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChooseAllFile.Location = new System.Drawing.Point(494, 17);
            this.btnChooseAllFile.Name = "btnChooseAllFile";
            this.btnChooseAllFile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChooseAllFile.ShadowDecoration.Parent = this.btnChooseAllFile;
            this.btnChooseAllFile.Size = new System.Drawing.Size(40, 40);
            this.btnChooseAllFile.TabIndex = 0;
            this.btnChooseAllFile.Click += new System.EventHandler(this.btnChooseAllFile_Click);
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.CheckedState.Parent = this.btnChoosePicture;
            this.btnChoosePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicture.CustomImages.Parent = this.btnChoosePicture;
            this.btnChoosePicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnChoosePicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoosePicture.ForeColor = System.Drawing.Color.White;
            this.btnChoosePicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.HoverState.Image = global::ChatApp.Properties.Resources.picturehover;
            this.btnChoosePicture.HoverState.Parent = this.btnChoosePicture;
            this.btnChoosePicture.Image = global::ChatApp.Properties.Resources.picture;
            this.btnChoosePicture.ImageSize = new System.Drawing.Size(25, 25);
            this.btnChoosePicture.Location = new System.Drawing.Point(446, 17);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnChoosePicture.ShadowDecoration.Parent = this.btnChoosePicture;
            this.btnChoosePicture.Size = new System.Drawing.Size(40, 40);
            this.btnChoosePicture.TabIndex = 0;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // btnSend
            // 
            this.btnSend.CheckedState.Parent = this.btnSend;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.CustomImages.Parent = this.btnSend;
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.btnSend.HoverState.Image = global::ChatApp.Properties.Resources.sendhover;
            this.btnSend.HoverState.Parent = this.btnSend;
            this.btnSend.Image = global::ChatApp.Properties.Resources.send;
            this.btnSend.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSend.Location = new System.Drawing.Point(398, 17);
            this.btnSend.Name = "btnSend";
            this.btnSend.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSend.ShadowDecoration.Parent = this.btnSend;
            this.btnSend.Size = new System.Drawing.Size(40, 40);
            this.btnSend.TabIndex = 0;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlTop.Controls.Add(this.lbNumMember);
            this.pnlTop.Controls.Add(this.btnAddMember);
            this.pnlTop.Controls.Add(this.lbTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.ShadowDecoration.Parent = this.pnlTop;
            this.pnlTop.Size = new System.Drawing.Size(560, 55);
            this.pnlTop.TabIndex = 2;
            // 
            // lbNumMember
            // 
            this.lbNumMember.ActiveLinkColor = System.Drawing.Color.Gray;
            this.lbNumMember.AutoSize = true;
            this.lbNumMember.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumMember.LinkColor = System.Drawing.Color.Silver;
            this.lbNumMember.Location = new System.Drawing.Point(461, 38);
            this.lbNumMember.Name = "lbNumMember";
            this.lbNumMember.Size = new System.Drawing.Size(73, 15);
            this.lbNumMember.TabIndex = 2;
            this.lbNumMember.TabStop = true;
            this.lbNumMember.Text = "3 thành viên";
            this.lbNumMember.VisitedLinkColor = System.Drawing.Color.Gray;
            this.lbNumMember.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbNumMember_LinkClicked);
            // 
            // btnAddMember
            // 
            this.btnAddMember.CheckedState.Parent = this.btnAddMember;
            this.btnAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMember.CustomImages.Parent = this.btnAddMember;
            this.btnAddMember.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMember.ForeColor = System.Drawing.Color.White;
            this.btnAddMember.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(47)))));
            this.btnAddMember.HoverState.Image = global::ChatApp.Properties.Resources.adduser;
            this.btnAddMember.HoverState.Parent = this.btnAddMember;
            this.btnAddMember.Image = global::ChatApp.Properties.Resources.adduser;
            this.btnAddMember.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMember.Location = new System.Drawing.Point(480, 3);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddMember.ShadowDecoration.Parent = this.btnAddMember;
            this.btnAddMember.Size = new System.Drawing.Size(32, 32);
            this.btnAddMember.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTitle.Location = new System.Drawing.Point(20, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(300, 55);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Tiêu đề";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.messageBox.Location = new System.Drawing.Point(0, 64);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(560, 408);
            this.messageBox.TabIndex = 0;
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.sendBox);
            this.Name = "ChatBox";
            this.Size = new System.Drawing.Size(560, 548);
            this.Load += new System.EventHandler(this.ChatBox_Load);
            this.sendBox.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ScrollPanel messageBox;
        private Guna.UI2.WinForms.Guna2Panel sendBox;
        private Guna.UI2.WinForms.Guna2CircleButton btnSend;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlTop;
        private System.Windows.Forms.Label lbTitle;
        public Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2CircleButton btnChoosePicture;
        private Guna.UI2.WinForms.Guna2CircleButton btnChooseAllFile;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddMember;
        private System.Windows.Forms.LinkLabel lbNumMember;
    }
}
