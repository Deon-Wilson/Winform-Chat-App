namespace ChatApp.Views.Components
{
    partial class OutgoingMessage
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
            this.time = new System.Windows.Forms.Label();
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
            this.bubbleArea.Location = new System.Drawing.Point(43, 20);
            this.bubbleArea.Name = "bubbleArea";
            this.bubbleArea.Size = new System.Drawing.Size(457, 36);
            this.bubbleArea.TabIndex = 13;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.time.Location = new System.Drawing.Point(387, 3);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(99, 14);
            this.time.TabIndex = 12;
            this.time.Text = "hh:mm dd/MM/yyyy";
            // 
            // OutgoingMessage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.bubbleArea);
            this.Controls.Add(this.time);
            this.Name = "OutgoingMessage";
            this.Size = new System.Drawing.Size(500, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel bubbleArea;
        private System.Windows.Forms.Label time;
    }
}
