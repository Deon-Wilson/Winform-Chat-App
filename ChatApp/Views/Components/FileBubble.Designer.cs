namespace ChatApp.Views.Components
{
    partial class FileBubble
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
            this.components = new System.ComponentModel.Container();
            this.fileName = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.option = new System.Windows.Forms.Label();
            this.pnlBubble = new Guna.UI2.WinForms.Guna2Panel();
            this.cmtOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.pnlBubble.SuspendLayout();
            this.cmtOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.ForeColor = System.Drawing.Color.White;
            this.fileName.Location = new System.Drawing.Point(11, 8);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(121, 27);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "File Name";
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSize.ForeColor = System.Drawing.Color.White;
            this.fileSize.Location = new System.Drawing.Point(13, 35);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(59, 16);
            this.fileSize.TabIndex = 2;
            this.fileSize.Text = "File Size";
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.Transparent;
            this.picture.Image = global::ChatApp.Properties.Resources.file;
            this.picture.Location = new System.Drawing.Point(0, 54);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(250, 96);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // option
            // 
            this.option.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option.Image = global::ChatApp.Properties.Resources.option;
            this.option.Location = new System.Drawing.Point(442, -2);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(15, 16);
            this.option.TabIndex = 6;
            this.option.Click += new System.EventHandler(this.option_Click);
            // 
            // pnlBubble
            // 
            this.pnlBubble.BackColor = System.Drawing.Color.Transparent;
            this.pnlBubble.BorderRadius = 15;
            this.pnlBubble.Controls.Add(this.picture);
            this.pnlBubble.Controls.Add(this.fileName);
            this.pnlBubble.Controls.Add(this.fileSize);
            this.pnlBubble.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(37)))));
            this.pnlBubble.Location = new System.Drawing.Point(0, 0);
            this.pnlBubble.Name = "pnlBubble";
            this.pnlBubble.ShadowDecoration.Parent = this.pnlBubble;
            this.pnlBubble.Size = new System.Drawing.Size(250, 150);
            this.pnlBubble.TabIndex = 7;
            // 
            // cmtOption
            // 
            this.cmtOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadToolStripMenuItem});
            this.cmtOption.Name = "cmtOption";
            this.cmtOption.Size = new System.Drawing.Size(181, 48);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.downloadToolStripMenuItem.Text = "Tải xuống";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // FileBubble
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.option);
            this.Controls.Add(this.pnlBubble);
            this.Name = "FileBubble";
            this.Size = new System.Drawing.Size(457, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.pnlBubble.ResumeLayout(false);
            this.pnlBubble.PerformLayout();
            this.cmtOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label option;
        private Guna.UI2.WinForms.Guna2Panel pnlBubble;
        private System.Windows.Forms.ContextMenuStrip cmtOption;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
    }
}
