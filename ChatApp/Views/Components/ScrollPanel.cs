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
    public partial class ScrollPanel : UserControl
    {
        private int b;
        public ScrollPanel()
        {
            InitializeComponent();
            b = 0;
        }
        private void panelBgMouseWheel(object sender, MouseEventArgs e)
        {
            if (this.vScrollBar.Visible)
            {
                int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
                int numberOfPixelsToMove = numberOfTextLinesToMove * 10;
                if (numberOfPixelsToMove < 0)
                {
                    if ((this.vScrollBar.Value - numberOfPixelsToMove) >= this.vScrollBar.Maximum)
                    {
                        this.vScrollBar.Value = this.vScrollBar.Maximum;
                    }
                    else
                    {
                        this.vScrollBar.Value -= numberOfPixelsToMove;
                    }
                }
                else
                {

                    if (this.vScrollBar.Value > numberOfPixelsToMove)
                    {
                        this.vScrollBar.Value -= numberOfPixelsToMove;
                    }
                    else
                    {
                        this.vScrollBar.Value = 0;
                    }
                }
            }
        }
        public void VScrollBarValueChanged(EventHandler e)
        {
            this.vScrollBar.ValueChanged += e;
        }
        private void vScrollBar_ValueChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Location = new Point(0, -this.vScrollBar.Value);
            b = this.vScrollBar.Maximum - this.vScrollBar.Value;
        }

        public void UpdateUi()
        {
            if (this.panelBg.Size.Height < this.flowLayoutPanel.PreferredSize.Height)
            {
                this.vScrollBar.Show();
                this.vScrollBar.Maximum = this.flowLayoutPanel.Size.Height - this.panelBg.Size.Height;
                this.vScrollBar.Value = this.vScrollBar.Maximum - b;
                this.flowLayoutPanel.Location = new Point(0, -this.vScrollBar.Value);
            }
        }

        private void ScrollPanel_Resize(object sender, EventArgs e)
        {
            if (this.flowLayoutPanel.PreferredSize.Height < this.panelBg.Height)
            {
                this.vScrollBar.Hide();
            }
            else
            {
                this.vScrollBar.Show();
                this.vScrollBar.Maximum = this.flowLayoutPanel.Size.Height - this.panelBg.Height;
            }
        }
    }
}
