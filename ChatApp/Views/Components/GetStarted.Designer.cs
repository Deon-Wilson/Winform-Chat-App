namespace ChatApp.Views.Components
{
    partial class GetStarted
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
            this.label1 = new System.Windows.Forms.Label();
            this.signInOrCreate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chat App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInOrCreate
            // 
            this.signInOrCreate.BorderRadius = 20;
            this.signInOrCreate.CheckedState.Parent = this.signInOrCreate;
            this.signInOrCreate.CustomImages.Parent = this.signInOrCreate;
            this.signInOrCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.signInOrCreate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.signInOrCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInOrCreate.ForeColor = System.Drawing.Color.White;
            this.signInOrCreate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
            this.signInOrCreate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(26)))), ((int)(((byte)(206)))));
            this.signInOrCreate.HoverState.Parent = this.signInOrCreate;
            this.signInOrCreate.Location = new System.Drawing.Point(100, 145);
            this.signInOrCreate.Name = "signInOrCreate";
            this.signInOrCreate.ShadowDecoration.Parent = this.signInOrCreate;
            this.signInOrCreate.Size = new System.Drawing.Size(250, 40);
            this.signInOrCreate.TabIndex = 1;
            this.signInOrCreate.Text = "Đăng nhập hoặc tạo mới";
            // 
            // GetStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.signInOrCreate);
            this.Controls.Add(this.label1);
            this.Name = "GetStarted";
            this.Size = new System.Drawing.Size(450, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton signInOrCreate;
    }
}
