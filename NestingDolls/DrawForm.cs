using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestingDolls
{
    public partial class DrawForm : Form
    {
        Graphics g;
        public DrawForm()
        {
            InitializeComponent();

            g = this.CreateGraphics();
        }
        private void DrawNestingDoll(int x, int y, int h, int w)
        {
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, x, y, w, h);
            g.FillEllipse(brush, x, y, w, (int)(h*0.3));
            brush = new SolidBrush(Color.LightYellow);
            g.FillEllipse(brush, (int)(x+w*0.25), (int)(y+h*0.05), (int)(w * 0.5), (int)(h*0.2));
            g.DrawEllipse(pen, (int)(x+w*0.25), (int)(y+h*0.05), (int)(w * 0.5), (int)(h*0.2));
            g.DrawEllipse(pen, (int)(x+w*0.30), (int)(y+h*0.075), (int)(w * 0.2), (int)(h*0.05));
            g.DrawEllipse(pen, (int)(x+w*0.5), (int)(y+h*0.075), (int)(w * 0.2), (int)(h*0.05));
            g.DrawLine(pen, (int)(x+w*0.5), (int)(y+h*0.25), (int)(x + w*0.5), (int)(y+h));
            g.DrawLine(pen, (int)(x + w * 0.25), (int)(y+h*0.15), (int)(x + w*0.75), (int)(y + h * 0.15));
            brush.Dispose();
            pen.Dispose();
        }



        private void DrawForm_MouseDown(object sender, MouseEventArgs e)
        {
            int height = 150;
            int width = 100;

            switch (Control.ModifierKeys)
            {
                case Keys.Shift:
                    DrawNestingDoll(e.X, e.Y, height / 2, width /2);
                    break;
                case Keys.Control:
                    DrawNestingDoll(e.X, e.Y, height / 3, width / 3);
                    break;
                case Keys.Alt:
                    DrawNestingDoll(e.X, e.Y, height / 5, width / 5);
                    break;
                default:
                    DrawNestingDoll(e.X, e.Y, height, width);
                    break;
            }
        }
    }
}
