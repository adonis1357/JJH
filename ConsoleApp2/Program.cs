using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomNumberGame
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private Random random;
        private int number;

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new Size(800, 600);
            this.BackColor = Color.Black;

            random = new Random();
            number = random.Next(11);

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int y = random.Next(this.ClientSize.Height);
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            g.DrawString(number.ToString(), new Font("Arial", 16), new SolidBrush(Color.White), this.ClientSize.Width - 50, y);

            if (number <= 0)
            {
                number = random.Next(11);
            }
            else
            {
                number--;
            }
        }
    }
}




