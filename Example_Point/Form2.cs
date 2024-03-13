using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Point
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int x = 10;
        private int y = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point currentLocation = pictureBox1.Location;

            int newX = currentLocation.X + x;
            int newY = currentLocation.Y + y;

            pictureBox1.Location = new Point(newX, newY);

            if(newX<=0 || newX + pictureBox1.Width >=this.ClientSize.Width)
            {
                x *= -1;
            }
            if (newY <= 0 || newY + pictureBox1.Height >= this.ClientSize.Height)
            {
                y *= -1;
            }
        }
    }
}
