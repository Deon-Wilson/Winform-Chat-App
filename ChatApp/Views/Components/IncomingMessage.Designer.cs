namespace ChatApp.Views.Components
{
    partial class IncomingMessage
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
            this.bubbleArea = new System.Windows.Forms.FlowLayoutPanel();
            this.userAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bubbleArea
            // 
            this.bubbleArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bubbleArea.AutoSize = true;
            this.bubbleArea.BackColor = System.Drawing.Color.Transparent;
            this.bubbleArea.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.bubbleArea.Font = new System.Drawing.Font("Arial", 8.25F);
            this.bubbleArea.Location = new System.Drawing.Point(43, 17);
            this.bubbleArea.Name = "bubbleArea";
            this.bubbleArea.Size = new System.Drawing.Size(457, 36);
            this.bubbleArea.TabIndex = 11;
            // 
            // userAvatar
            // 
            this.userAvatar.Image = global::ChatApp.Properties.Resources.avatar;
            this.userAvatar.Location = new System.Drawing.Point(0, 0);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userAvatar.ShadowDecoration.Parent = this.userAvatar;
            this.userAvatar.Size = new System.Drawing.Size(40, 40);
            this.userAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userAvatar.TabIndex = 9;
            this.userAvatar.TabStop = false;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.info.Location = new System.Drawing.Point(46, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(56, 14);
            this.info.TabIndex = 8;
            this.info.Text = "hh:mm AM";
            // 
            // IncomingMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.bubbleArea);
            this.Controls.Add(this.userAvatar);
            this.Controls.Add(this.info);
            this.Name = "IncomingMessage";
            this.Size = new System.Drawing.Size(500, 58);
            ((System.ComponentModel.ISupportInitialize)(this.userAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox userAvatar;
        private System.Windows.Forms.FlowLayoutPanel bubbleArea;
        private System.Windows.Forms.Label info;
    }
}
