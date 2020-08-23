using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChatApp.Views.Components
{
    public partial class TextBubble : UserControl
    {
        public TextBubble()
        {
            InitializeComponent();
            setHeight();
        }
        public TextBubble(string msg, msgType type)
        {
            InitializeComponent();
            message.Text = msg;
            setHeight();
            if (type.ToString() == "Out")
            {
                this.bubble.Location = new Point(457 - (bubble.Width + 20), 0);
                this.bubble.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(90)))));
                this.bubble.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(36)))), ((int)(((byte)(206)))));
            }
        }
        public enum msgType
        {
            In,
            Out
        }
        void setHeight()
        {
            Graphics g = CreateGraphics();
            SizeF size = g.MeasureString(message.Text, message.Font, message.Width);
            message.Height = int.Parse(Math.Round(size.Height, 0).ToString());
            bubble.Width = int.Parse(Math.Round(size.Width + 32, 0).ToString());
            bubble.Height = message.Height + 16;
            this.Height = bubble.Height;

        }

        private void option_Click(object sender, EventArgs e)
        {
            cmtOption.Show(this, 325, 16);
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(message.Text);
        }
    }
}
