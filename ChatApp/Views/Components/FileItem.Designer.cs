namespace ChatApp.Views.Components
{
    partial class FileItem
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
            this.bg = new Guna.UI2.WinForms.Guna2Panel();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbFileSize = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.file = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.file)).BeginInit();
            this.SuspendLayout();
            // 
            // bg
            // 
            this.bg.BorderRadius = 10;
            this.bg.Controls.Add(this.btnClose);
            this.bg.Controls.Add(this.lbFileSize);
            this.bg.Controls.Add(this.lbFileName);
            this.bg.Controls.Add(this.file);
            this.bg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.bg.Location = new System.Drawing.Point(0, 0);
            this.bg.Name = "bg";
            this.bg.ShadowDecoration.Parent = this.bg;
            this.bg.Size = new System.Drawing.Size(130, 100);
            this.bg.TabIndex = 0;
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.ForeColor = System.Drawing.Color.White;
            this.lbFileName.Location = new System.Drawing.Point(9, 9);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(72, 17);
            this.lbFileName.TabIndex = 1;
            this.lbFileName.Text = "File name";
            // 
            // lbFileSize
            // 
            this.lbFileSize.AutoSize = true;
            this.lbFileSize.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileSize.ForeColor = System.Drawing.Color.White;
            this.lbFileSize.Location = new System.Drawing.Point(9, 26);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(46, 14);
            this.lbFileSize.TabIndex = 2;
            this.lbFileSize.Text = "File size";
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::ChatApp.Properties.Resources.circleclose;
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(102, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            // 
            // file
            // 
            this.file.BorderRadius = 20;
            this.file.Image = global::ChatApp.Properties.Resources.file;
            this.file.Location = new System.Drawing.Point(0, 46);
            this.file.Name = "file";
            this.file.ShadowDecoration.Parent = this.file;
            this.file.Size = new System.Drawing.Size(130, 54);
            this.file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.file.TabIndex = 0;
            this.file.TabStop = false;
            // 
            // FileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bg);
            this.Name = "FileItem";
            this.Size = new System.Drawing.Size(130, 100);
            this.bg.ResumeLayout(false);
            this.bg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.file)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel bg;
        private Guna.UI2.WinForms.Guna2PictureBox file;
        private System.Windows.Forms.Label lbFileSize;
        private System.Windows.Forms.Label lbFileName;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
    }
}
