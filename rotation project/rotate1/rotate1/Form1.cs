using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rotate1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double alpha = 0.0;
        int X, Y, R;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ch.Checked)
                alpha += 0.05;
            else
                alpha -= 0.05;
         
            pbArr.Left = (int)(X + Math.Cos(alpha) * R) - pbArr.Width / 2;
            pbArr.Top = (int)(Y + Math.Sin(alpha) * R) - pbArr.Height / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            flag_started = timer1.Enabled;
        }

        private void NudX_ValueChanged(object sender, EventArgs e)
        {
            X = (int)NudX.Value;
            pbCenter.Left = (int)(NudX.Value - pbCenter.Size.Width);
        }

        private void NudY_ValueChanged(object sender, EventArgs e)
        {
            Y = (int)NudY.Value;
            pbCenter.Top = Y - pbCenter.Width / 2;
        }

        private void NudR_ValueChanged(object sender, EventArgs e)
        {
            R = (int)NudR.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            NudX.Value = 100;
            NudY.Value = 100;
            NudR.Value = 50;
            alpha = 0.0;
            X = (int)NudX.Value;
            Y = (int)NudY.Value;
            R = (int)NudR.Value;
            pbArr.Left = (int)(X + Math.Cos(alpha) * R) - pbArr.Width / 2;
            pbArr.Top = (int)(Y + Math.Sin(alpha) * R) - pbArr.Height / 2;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
           /* if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;*/
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tb.Value;
        }
        int ox, oy;
        bool flag_fly, flag_arr_pressed = false;
        bool flag_started = false;

        bool flag_center_pressed = false;
        void stop_fly()
        {
            flag_fly = timer1.Enabled;
            timer1.Enabled = false;
            pbCenter.BackColor = Color.Black;
        }

        private void pbCenter_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag_center_pressed)
            {
                NudX.Value += e.X;
                NudY.Value += e.Y;


                pbCenter.Left = (int)(NudX.Value - pbCenter.Size.Width);
                pbCenter.Top = (int)(NudY.Value - pbCenter.Size.Height);
            }
        }

        private void pbCenter_MouseUp(object sender, MouseEventArgs e)
        {
            flag_center_pressed = false;
            timer1.Enabled = flag_started;
        }

        private void pbArr_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag_arr_pressed)
            {
                pbArr.Top += e.Y - oy;
                pbArr.Left += e.X - ox;
            }
        }

        private void pbArr_MouseDown(object sender, MouseEventArgs e)
        {
            ox = e.X;
            oy = e.Y;
            stop_fly();
            flag_arr_pressed = true;
        }

        private void pbCenter_MouseDown(object sender, MouseEventArgs e)
        {
            flag_center_pressed = true;
            flag_started = timer1.Enabled;
            timer1.Enabled = false;
        }


        private void pbArr_MouseUp(object sender, MouseEventArgs e)
        {
            int xx = pbArr.Left + pbArr.Width / 2;
            int yy = pbArr.Top + pbArr.Width / 2;
            R = (int)Math.Sqrt((xx - X) * (xx - X) + (yy - Y) * (yy - Y));
            NudR.Value = R;
            if (xx > X)
                alpha = -Math.Atan(((double)Y - yy) / (xx - X));
            else
                if (xx < X)
                alpha = Math.PI - Math.Atan(((double)Y - yy) / (xx - X));
            else
                alpha = Y > yy ? Math.PI / 2 : Y < yy ? -Math.PI / 2 : 0;
            flag_arr_pressed = false;
            timer1.Enabled = flag_fly;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            X = (int)NudX.Value;
            Y = (int)NudY.Value;
            R = (int)NudR.Value;
            pbCenter.Left = X - pbCenter.Width / 2;
            pbCenter.Top = Y - pbCenter.Width / 2;
            pbCenter.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
