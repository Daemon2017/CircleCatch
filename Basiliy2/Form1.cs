using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basiliy2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int r = 100;
        float x_green, x_green2, x_blue, x_blue2, x_red, x_red2;
        double rasst;
        int ok_green, yes_green, no_green, ok_blue, yes_blue, no_blue, ok_red, yes_red, no_red, ok, no;
        int green_number = 0, blue_number = 0, red_number = 0;
        
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();

            Pen pen_red = new Pen(Brushes.Red, 2);
            Pen pen_blue = new Pen(Brushes.Blue, 2);
            Pen pen_green = new Pen(Brushes.Green, 2);

            Pen pen_krug = new Pen(Brushes.Black, 2);

            Graphics krug = pictureBox1.CreateGraphics();

            krug.DrawEllipse(pen_krug, 0, 0, 199, 199);
            krug.FillRectangle(Brushes.White, 100, 100, 1, 1);

            float cosFi_green2 = (float)Math.Cos(((Math.PI * (trackBar1.Value - 1)) / 180));
            float sinFi_green2 = (float)Math.Sin(((Math.PI * (trackBar1.Value - 1)) / 180));
            x_green2 = 100 + r * cosFi_green2;
            float y_green2 = 100 + r * sinFi_green2;
            krug.DrawLine(pen_green, 100, 100, x_green2, y_green2);

            float cosFi_red = (float)Math.Cos(((Math.PI * (trackBar1.Value + 1)) / 180));
            float sinFi_red = (float)Math.Sin(((Math.PI * (trackBar1.Value + 1)) / 180));
            x_red = 100 + r * cosFi_red;
            float y_red = 100 + r * sinFi_red;
            krug.DrawLine(pen_red, 100, 100, x_red, y_red);

            float cosFi_red2 = (float)Math.Cos(((Math.PI * (trackBar1.Value + 119)) / 180));
            float sinFi_red2 = (float)Math.Sin(((Math.PI * (trackBar1.Value + 119)) / 180));
            x_red2 = 100 + r * cosFi_red2;
            float y_red2 = 100 + r * sinFi_red2;
            krug.DrawLine(pen_red, 100, 100, x_red2, y_red2);

            float cosFi_blue = (float)Math.Cos(((Math.PI * (trackBar1.Value + 121)) / 180));
            float sinFi_blue = (float)Math.Sin(((Math.PI * (trackBar1.Value + 121)) / 180));
            x_blue = 100 + r * cosFi_blue;
            float y_blue = 100 + r * sinFi_blue;
            krug.DrawLine(pen_blue, 100, 100, x_blue, y_blue);

            float cosFi_blue2 = (float)Math.Cos(((Math.PI * (trackBar1.Value + 239)) / 180));
            float sinFi_blue2 = (float)Math.Sin(((Math.PI * (trackBar1.Value + 239)) / 180));
            x_blue2 = 100 + r * cosFi_blue2;
            float y_blue2 = 100 + r * sinFi_blue2;
            krug.DrawLine(pen_blue, 100, 100, x_blue2, y_blue2);

            float cosFi_green = (float)Math.Cos(((Math.PI * (trackBar1.Value + 241)) / 180));
            float sinFi_green = (float)Math.Sin(((Math.PI * (trackBar1.Value + 241)) / 180));
            x_green = 100 + r * cosFi_green;
            float y_green = 100 + r * sinFi_green;
            krug.DrawLine(pen_green, 100, 100, x_green, y_green);

            //pictureBox1.SendToBack();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 'A':
                    {
                        if (trackBar1.Value > -720)
                        {
                            trackBar1.Value = trackBar1.Value - 2;
                        }
                        break;
                    }
                case 'D':
                    {
                        if (trackBar1.Value < 720)
                        {
                            trackBar1.Value = trackBar1.Value + 2;
                        }
                        break;
                    }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (trackBar1.Value < 120)
            {
                trackBar1.Value = trackBar1.Value + 2;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random generate_green = new Random();
            Random generate_blue = new Random();
            Random generate_red = new Random();

            timer2.Interval = generate_green.Next(5000, 6000);
            timer5.Interval = generate_blue.Next(8000, 9000);
            timer8.Interval = generate_red.Next(1100, 12000);

            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random Fire_Green = new Random();
            if (green_number < 2)
            {
                int Ball_green_X = Fire_Green.Next(200, 380);
                int Ball_green_Y = Fire_Green.Next(0, 20);

                PictureBox Ball_green = new PictureBox();
                Ball_green.Name = string.Format("Ball_green");
                Ball_green.BackColor = Color.Transparent;
                Ball_green.Image = Basiliy2.Properties.Resources.green_ball;
                Ball_green.Location = new Point(Ball_green_X, Ball_green_Y);
                Ball_green.SizeMode = PictureBoxSizeMode.StretchImage;
                Ball_green.ClientSize = new Size(20, 20);

                green_number++;
                this.Controls.Add(Ball_green);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random Fire_Blue = new Random();
            if (blue_number < 2)
            {
                int Ball_blue_X = Fire_Blue.Next(200, 380);
                int Ball_blue_Y = Fire_Blue.Next(0, 20);

                PictureBox Ball_blue = new PictureBox();
                Ball_blue.Name = string.Format("Ball_blue");
                Ball_blue.BackColor = Color.Transparent;
                Ball_blue.Image = Basiliy2.Properties.Resources.blue_ball;
                Ball_blue.Location = new Point(Ball_blue_X, Ball_blue_Y);
                Ball_blue.SizeMode = PictureBoxSizeMode.StretchImage;
                Ball_blue.ClientSize = new Size(20, 20);

                blue_number++;
                this.Controls.Add(Ball_blue);
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Random Fire_Red = new Random();
            if (red_number < 2)
            {
                int Ball_red_X = Fire_Red.Next(200, 380);
                int Ball_red_Y = Fire_Red.Next(0, 20);

                PictureBox Ball_red = new PictureBox();
                Ball_red.Name = string.Format("Ball_red");
                Ball_red.BackColor = Color.Transparent;
                Ball_red.Image = Basiliy2.Properties.Resources.red_ball;
                Ball_red.Location = new Point(Ball_red_X, Ball_red_Y);
                Ball_red.SizeMode = PictureBoxSizeMode.StretchImage;
                Ball_red.ClientSize = new Size(20, 20);

                red_number++;
                this.Controls.Add(Ball_red);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_green in Controls)
                if (Ball_green.Name == "Ball_green")
                {
                    Point p_green = Ball_green.Location;
                    p_green.Y += 4;
                    Ball_green.Location = p_green;
                }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_blue in Controls)
                if (Ball_blue.Name == "Ball_blue")
                {
                    Point p_blue = Ball_blue.Location;
                    p_blue.Y += 2;
                    Ball_blue.Location = p_blue;
                }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_red in Controls)
                if (Ball_red.Name == "Ball_red")
                {
                    Point p_red = Ball_red.Location;
                    p_red.Y += 1;
                    Ball_red.Location = p_red;
                }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_green in Controls)
            {
                if (Ball_green.Name == "Ball_green")
                {
                    rasst = Math.Sqrt(Math.Pow((Ball_green.Location.X + 10) - (pictureBox1.Location.X + 100), 2) + Math.Pow((Ball_green.Location.Y + 10) - (pictureBox1.Location.Y + 100), 2));
                    if ((Ball_green.Location.X + 10) >= (pictureBox1.Location.X + x_green) &&
                        (Ball_green.Location.X + 10) <= (pictureBox1.Location.X + x_green2) &&
                        (Ball_green.Location.Y + 10) >= pictureBox1.Location.Y &&
                        (Ball_green.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                        rasst <= r)
                    {
                        ok_green++;
                        label3.Text = ok_green.ToString();
                        this.Controls.Remove(Ball_green);
                        green_number--;
                    }

                    if ((Ball_green.Location.X + 10) >= pictureBox1.Location.X &&
                       (Ball_green.Location.X + 10) <= (pictureBox1.Location.X + 200) &&
                       (Ball_green.Location.Y + 10) >= pictureBox1.Location.Y &&
                       (Ball_green.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                       rasst <= r)
                    {
                        yes_green++;
                        this.Controls.Remove(Ball_green);
                        green_number--;
                        no_green = yes_green - ok_green;
                        label5.Text = no_green.ToString();
                    }

                }               
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_blue in Controls)
            {
                if (Ball_blue.Name == "Ball_blue")
                {
                    rasst = Math.Sqrt(Math.Pow((Ball_blue.Location.X + 10) - (pictureBox1.Location.X + 100), 2) + Math.Pow((Ball_blue.Location.Y + 10) - (pictureBox1.Location.Y + 100), 2));
                    if ((Ball_blue.Location.X + 10) >= (pictureBox1.Location.X + x_blue) &&
                        (Ball_blue.Location.X + 10) <= (pictureBox1.Location.X + x_blue2) &&
                        (Ball_blue.Location.Y + 10) >= pictureBox1.Location.Y &&
                        (Ball_blue.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                        rasst <= r)
                    {
                        ok_blue++;
                        label8.Text = ok_blue.ToString();
                        this.Controls.Remove(Ball_blue);
                        blue_number--;
                    }

                    if ((Ball_blue.Location.X + 10) >= pictureBox1.Location.X &&
                       (Ball_blue.Location.X + 10) <= (pictureBox1.Location.X + 200) &&
                       (Ball_blue.Location.Y + 10) >= pictureBox1.Location.Y &&
                       (Ball_blue.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                       rasst <= r)
                    {
                        yes_blue++;
                        this.Controls.Remove(Ball_blue);
                        blue_number--;
                        no_blue = yes_blue - ok_blue;
                        label7.Text = no_blue.ToString();
                    }

                }
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            foreach (Control Ball_red in Controls)
            {
                if (Ball_red.Name == "Ball_red")
                {
                    rasst = Math.Sqrt(Math.Pow((Ball_red.Location.X + 10) - (pictureBox1.Location.X + 100), 2) + Math.Pow((Ball_red.Location.Y + 10) - (pictureBox1.Location.Y + 100), 2));
                    if ((Ball_red.Location.X + 10) >= (pictureBox1.Location.X + x_red) &&
                        (Ball_red.Location.X + 10) <= (pictureBox1.Location.X + x_red2) &&
                        (Ball_red.Location.Y + 10) >= pictureBox1.Location.Y &&
                        (Ball_red.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                        rasst <= r)
                    {
                        ok_red++;
                        label10.Text = ok_red.ToString();
                        this.Controls.Remove(Ball_red);
                        red_number--;
                    }

                    if ((Ball_red.Location.X + 10) >= pictureBox1.Location.X &&
                       (Ball_red.Location.X + 10) <= (pictureBox1.Location.X + 200) &&
                       (Ball_red.Location.Y + 10) >= pictureBox1.Location.Y &&
                       (Ball_red.Location.Y + 10) <= (pictureBox1.Location.Y + 200) &&
                       rasst <= r)
                    {
                        yes_red++;
                        this.Controls.Remove(Ball_red);
                        red_number--;
                        no_red = yes_red - ok_red;
                        label9.Text = no_red.ToString();
                    }

                }
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            no = no_green + no_blue + no_red;
            label11.Text = no.ToString();
            if(no>=12)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                timer9.Stop();
                timer10.Stop();
                timer11.Stop();
                MessageBox.Show("Конец игры", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Restart();
            }

            ok = ok_green + ok_blue + ok_red;
            label12.Text = ok.ToString();
            if(ok>=7)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Stop();
                timer6.Stop();
                timer7.Stop();
                timer8.Stop();
                timer9.Stop();
                timer10.Stop();
                timer11.Stop();
                MessageBox.Show("Вы победили!", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Application.Restart();
            }
        }

    }
}
