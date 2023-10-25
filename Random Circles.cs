using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Close window when exit button pressed
        private void cmdQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Clar graphics window
        private void cmdClear_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        // Create black circle of 50 diameter at point (50,50)
        private void cmdEllipse_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics;
            graphics = pnlDraw.CreateGraphics();
            Pen penColour = new Pen(Color.BlueViolet);
            graphics.DrawEllipse(penColour, 50, 50, 50, 50);
        }

        // Draw random circles on graphics window
        private void cmdRandomCircles_Click(object sender, EventArgs e)
        {
            int x, y, radius;
            Random rand = new Random();
            x = rand.Next(pnlDraw.Width);
            y = rand.Next(pnlDraw.Height);
            radius = 50;
            System.Drawing.Graphics graphics;
            graphics = pnlDraw.CreateGraphics();
            Color Colour = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            Pen penColour = new Pen(Colour);
            graphics.DrawEllipse(penColour, x, y, radius, radius);

        }

        // Draw black line from the top left corner to the bottom right  
        private void cmdLines_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics;
            graphics = pnlDraw.CreateGraphics();
            Pen penColour = new Pen(Color.Black);
            graphics.DrawLine(penColour, 0, 0, pnlDraw.Width, pnlDraw.Height);
        }
    }
}
