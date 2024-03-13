using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example_Point
{
    public partial class Form1 : Form
    {
        private int deltaX = 10; // X eksenindeki hareket miktarı
        private int deltaY = 10; // Y eksenindeki hareket miktarı

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Zamanlayıcıyı başlat
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mevcut picturebox konumunu al
            Point currentLocation = pictureBox1.Location;

            // Yeni konumu hesapla
            int newX = currentLocation.X + deltaX;
            int newY = currentLocation.Y + deltaY;

            // Yeni konumu ayarla
            pictureBox1.Location = new Point(newX, newY);

            // Yeni konumun form sınırlarını aşmamasını sağlayın
            if (newX <= 0 || newX + pictureBox1.Width >= this.ClientSize.Width)
            {
                deltaX *= -1; // X eksenindeki hareketi tersine çevir
            }
            if (newY <= 0 || newY + pictureBox1.Height >= this.ClientSize.Height)
            {
                deltaY *= -1; // Y eksenindeki hareketi tersine çevir
            }
        }
    }
}
