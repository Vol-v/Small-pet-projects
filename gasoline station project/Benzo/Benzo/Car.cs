using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Benzo
{
   public class Car: ProgressBar
    {
        int CurrFuel = 0;
        int MaxFuel;
        public static int TotalCount = 0;

        public bool CanBeFeel = false;
        public Pump p = null;
        Timer mt;
        const int speed = 3;

        public Car(int curr, int max, Form1 f)
        {
            CurrFuel = curr;
            MaxFuel = max;
            TotalCount++;

            Parent = f;
            Height = 20;
            Width = 30;
            Left = f.Width;
            Maximum = MaxFuel;
            Value = CurrFuel;
            mt = new Timer();
            mt.Interval = 50;
            mt.Tick += mt_Tick;
            mt.Start();
        }

        void mt_Tick(object sender, EventArgs e)
        {
            if (p == null)
            {
                Left -= speed;
                if (Left <= -Width)
                    mt.Stop();

            }
            else
            {
                int pos = p.queue.IndexOf(this);
                if (pos < 0)
                    p = null;
                else
                {
                    if (Left - speed > 250 + pos * (Width + 6))
                        Left -= speed;
                    else
                        CanBeFeel = (pos == 0);
                }
            }
        }
        public int NeedFill()
        {
            return MaxFuel - CurrFuel;
        }
        public bool IsFull()
        {
            return MaxFuel == CurrFuel;
        }
        public void DoFill(int x)
        {
            CurrFuel += x;
            Value = CurrFuel;
        }
    }
}
