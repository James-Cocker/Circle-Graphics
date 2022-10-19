using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            // Close the program when the quit button is pressed
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            // Refresh the picture box when the clear button is pressed
            Refresh();
        }

        private void cmdEllipse_Click(object sender, EventArgs e)
        {
            int x, y, radius = 50;          // Creating variables
            Random rand = new Random();

            x = rand.Next(pnlDraw.Width - radius);          // Set the co-ordinates of the circle
            y = rand.Next(pnlDraw.Height - radius);

            System.Drawing.Graphics graphics;           // Give the picture box the ability to display graphics
            graphics = pnlDraw.CreateGraphics();

            Color Colour = Color.FromArgb(0,0,0);           // Create a pen with the colour black
            Pen penColour = new Pen(Colour);

            graphics.DrawEllipse(penColour, x, y, radius, radius);          // Draw the circle
        }

        private void cmdRandomCircles_Click(object sender, EventArgs e)
        {
            Random rand = new Random();         // Creating variables
            int x, y, radius;

            radius = rand.Next(10, 90);          // Set the circle to have a random radius
            x = rand.Next(pnlDraw.Width - radius);          // Set the co-ordinates of the circle
            y = rand.Next(pnlDraw.Height - radius);

            System.Drawing.Graphics graphics;           // Give the picture box the ability to display graphics
            graphics = pnlDraw.CreateGraphics();

            Color Colour = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));  // Create a pen with a random colour
            Pen penColour = new Pen(Colour);

            graphics.DrawEllipse(penColour, x, y, radius, radius);          // Draw the circle

        }

        private void cmdLines_Click(object sender, EventArgs e)
        {
            Random rand = new Random();         // Create vairables

            int StartX = rand.Next(pnlDraw.Width), StartY = rand.Next(pnlDraw.Height);          // Set the co-ordinates of the circle
            int EndX = rand.Next(pnlDraw.Width), EndY = rand.Next(pnlDraw.Height);

            System.Drawing.Graphics graphics;           // Give the picture box the ability to display graphics
            graphics = pnlDraw.CreateGraphics();

            Pen penColour = new Pen(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));            // Create a pen with a random colour

            graphics.DrawLine(penColour, StartX, StartY, EndX, EndY);           // Draw the line
        }


        // Unused routine
        private void pnlDraw_Click(object sender, EventArgs e) { }
    }
}
