using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace almaszedegetes
{
    public partial class Form1 : Form
    {
        static int pontok = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                timer1.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                if(kosar.Location.X > 0 && kosar.Location.X < 650)
                {
                    kosar.Location = new Point(kosar.Location.X + 10, kosar.Location.Y);
                }
                if (kosar.Location.X <= 0)
                {
                    kosar.Location = new Point(1, kosar.Location.Y);
                }
            }

            if(e.KeyCode == Keys.Left)
            {
                if (kosar.Location.X > 0 && kosar.Location.X < 650)
                {
                    kosar.Location = new Point(kosar.Location.X - 10, kosar.Location.Y);
                }
                if (kosar.Location.X >= 650)
                {
                    kosar.Location = new Point(649, kosar.Location.Y);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            alma.Location = new Point(alma.Location.X, alma.Location.Y + 5);

            if (alma.Bounds.IntersectsWith(talaj.Bounds))
            {
                timer1.Stop();
                MessageBox.Show($"Játék vége! A pontok: {pontok}");
            }

            if (alma.Bounds.IntersectsWith(kosar.Bounds))
            {
                pontok++;
                Random veletlen = new Random();
                alma.Location = new Point(veletlen.Next(0, 650), 12);

                if(timer1.Interval > 20)
                {
                    timer1.Interval = timer1.Interval - 10;
                }
            }
        }

        private void alma_Click(object sender, EventArgs e)
        {

        }
    }
}
