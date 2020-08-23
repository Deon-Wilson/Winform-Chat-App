namespace ChatApp.Views.Components
{
    partial class Conversation
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
            this.bg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnState = new Guna.UI2.WinForms.Guna2CircleButton();
            this.unReadMessage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbLatestMessage = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pbAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bg.BackColor = System.Drawing.Color.Transparent;
            this.bg.BorderRadius = 12;
            this.bg.Controls.Add(this.btnState);
            this.bg.Controls.Add(this.unReadMessage);
            this.bg.Controls.Add(this.lbDate);
            this.bg.Controls.Add(this.lbLatestMessage);
            this.bg.Controls.Add(this.lbTitle);
            this.bg.Controls.Add(this.pbAvatar);
            this.bg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bg.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.ShadowDecoration.BorderRadius = 12;
            this.bg.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bg.ShadowDecoration.Enabled = true;
            this.bg.ShadowDecoration.Parent = this.bg;
            this.bg.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 2, 5, 7);
            this.bg.Size = new System.Drawing.Size(282, 66);
            this.bg.TabIndex = 1;
            // 
            // btnState
            // 
            this.btnState.BackColor = System.Drawing.Color.Transparent;
            this.btnState.CheckedState.Parent = this.btnState;
            this.btnState.CustomImages.Parent = this.btnState;
            this.btnState.FillColor = System.Drawing.Color.Lime;
            this.btnState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnState.ForeColor = System.Drawing.Color.White;
            this.btnState.HoverState.Parent = this.btnState;
            this.btnState.Location = new System.Drawing.Point(6, 6);
            this.btnState.Name = "btnState";
            this.btnState.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnState.ShadowDecoration.Parent = this.btnState;
            this.btnState.Size = new System.Drawing.Size(12, 12);
            this.btnState.TabIndex = 4;
            // 
            // unReadMessage
            // 
            this.unReadMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unReadMessage.BackColor = System.Drawing.Color.Transparent;
            this.unReadMessage.CheckedState.Parent = this.unReadMessage;
            this.unReadMessage.CustomImages.Parent = this.unReadMessage;
            this.unReadMessage.FillColor = System.Drawing.Color.Magenta;
            this.unReadMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unReadMessage.ForeColor = System.Drawing.Color.White;
            this.unReadMessage.HoverState.Parent = this.unReadMessage;
            this.unReadMessage.Location = new System.Drawing.Point(233, 32);
            this.unReadMessage.Name = "unReadMessage";
            this.unReadMessage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.unReadMessage.ShadowDecoration.Parent = this.unReadMessage;
            this.unReadMessage.Size = new System.Drawing.Size(20, 20);
            this.unReadMessage.TabIndex = 3;
            this.unReadMessage.Text = "6";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Silver;
            this.lbDate.Location = new System.Drawing.Point(186, 11);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(98, 14);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "hh:mm dd/";
            // 
            // lbLatestMessage
            // 
            this.lbLatestMessage.BackColor = System.Drawing.Color.Transparent;
            this.lbLatestMessage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLatestMessage.ForeColor = System.Drawing.Color.Silver;
            this.lbLatestMessage.Location = new System.Drawing.Point(54, 32);
            this.lbLatestMessage.Name = "lbLatestMessage";
            this.lbLatestMessage.Size = new System.Drawing.Size(136, 28);
            this.lbLatestMessage.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(54, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(128, 17);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Tên người dùng";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Image = global::ChatApp.Properties.Resources.groupavatar;
            this.pbAvatar.Location = new System.Drawing.Point(12, 11);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAvatar.ShadowDecoration.Parent = this.pbAvatar;
            this.pbAvatar.Size = new System.Drawing.Size(40, 40);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // Conversation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.bg);
            this.Name = "Conversation";
            this.Size = new System.Drawing.Size(282, 66);
            this.Load += new System.EventHandler(this.Conversation_Load);
            this.bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton unReadMessage;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAvatar;
        public Guna.UI2.WinForms.Guna2CircleButton btnState;
        public Guna.UI2.WinForms.Guna2GradientPanel bg;
        public System.Windows.Forms.Label lbLatestMessage;
        public System.Windows.Forms.Label lbDate;
    }
}
