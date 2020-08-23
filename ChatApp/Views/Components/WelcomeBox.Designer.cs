namespace ChatApp.Views.Components
{
    partial class WelcomeBox
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.userAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnConversation = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbWelcome.Location = new System.Drawing.Point(0, 100);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(560, 60);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "Xin Chào Bạn";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userAvatar
            // 
            this.userAvatar.Image = global::ChatApp.Properties.Resources.avatar;
            this.userAvatar.Location = new System.Drawing.Point(200, 190);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userAvatar.ShadowDecoration.Parent = this.userAvatar;
            this.userAvatar.Size = new System.Drawing.Size(160, 160);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userAvatar.TabIndex = 1;
            this.userAvatar.TabStop = false;
            // 
            // btnConversation
            // 
            this.btnConversation.BorderRadius = 20;
            this.btnConversation.CheckedState.Parent = this.btnConversation;
            this.btnConversation.CustomImages.Parent = this.btnConversation;
            this.btnConversation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnConversation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnConversation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversation.ForeColor = System.Drawing.Color.White;
            this.btnConversation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.btnConversation.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.btnConversation.HoverState.Parent = this.btnConversation;
            this.btnConversation.Location = new System.Drawing.Point(150, 385);
            this.btnConversation.Name = "btnConversation";
            this.btnConversation.ShadowDecoration.Parent = this.btnConversation;
            this.btnConversation.Size = new System.Drawing.Size(260, 40);
            this.btnConversation.TabIndex = 7;
            this.btnConversation.Text = "Bắt đầu một cuộc hội thoại";
            // 
            // WelcomeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.btnConversation);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.lbWelcome);
            this.Name = "WelcomeBox";
            this.Size = new System.Drawing.Size(560, 548);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userAvatar;
        private Guna.UI2.WinForms.Guna2GradientButton btnConversation;
    }
}
