namespace ChatApp.Views.Components
{
    partial class SearchResult
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
            this.lbInfo = new System.Windows.Forms.Label();
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
            this.bg.Controls.Add(this.lbInfo);
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
            this.bg.TabIndex = 2;
            // 
            // lbInfo
            // 
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.ForeColor = System.Drawing.Color.Silver;
            this.lbInfo.Location = new System.Drawing.Point(54, 32);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(136, 28);
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "Email";
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
            this.pbAvatar.Image = global::ChatApp.Properties.Resources.avatar;
            this.pbAvatar.Location = new System.Drawing.Point(12, 11);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbAvatar.ShadowDecoration.Parent = this.pbAvatar;
            this.pbAvatar.Size = new System.Drawing.Size(40, 40);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // SearchResult
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bg);
            this.Name = "SearchResult";
            this.Size = new System.Drawing.Size(282, 66);
            this.bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2GradientPanel bg;
        public System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbAvatar;
    }
}
