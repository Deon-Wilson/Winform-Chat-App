namespace ChatApp.Views.Components
{
    partial class ScrollPanel
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
            this.panelBg = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.vScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBg.BackColor = System.Drawing.Color.Transparent;
            this.panelBg.Controls.Add(this.flowLayoutPanel);
            this.panelBg.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBg.Location = new System.Drawing.Point(0, 0);
            this.panelBg.Name = "panelBg";
            this.panelBg.ShadowDecoration.Parent = this.panelBg;
            this.panelBg.Size = new System.Drawing.Size(294, 400);
            this.panelBg.TabIndex = 0;
            this.panelBg.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.panelBgMouseWheel);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(294, 400);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.WrapContents = false;
            // 
            // vScrollBar
            // 
            this.vScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar.BackColor = System.Drawing.Color.Transparent;
            this.vScrollBar.FillColor = System.Drawing.Color.Transparent;
            this.vScrollBar.HoverState.Parent = null;
            this.vScrollBar.LargeChange = 10;
            this.vScrollBar.Location = new System.Drawing.Point(295, 0);
            this.vScrollBar.MouseWheelBarPartitions = 10;
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.PressedState.Parent = this.vScrollBar;
            this.vScrollBar.ScrollbarSize = 3;
            this.vScrollBar.Size = new System.Drawing.Size(3, 400);
            this.vScrollBar.TabIndex = 1;
            this.vScrollBar.ThumbColor = System.Drawing.Color.Silver;
            this.vScrollBar.ThumbSize = 30F;
            this.vScrollBar.ValueChanged += new System.EventHandler(this.vScrollBar_ValueChanged);
            // 
            // ScrollPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.panelBg);
            this.Name = "ScrollPanel";
            this.Size = new System.Drawing.Size(300, 400);
            this.Resize += new System.EventHandler(this.ScrollPanel_Resize);
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2VScrollBar vScrollBar;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        public Guna.UI2.WinForms.Guna2GradientPanel panelBg;
    }
}
