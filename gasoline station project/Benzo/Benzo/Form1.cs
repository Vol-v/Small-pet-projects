using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Benzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] stats = new string[]
            {
                "Cash balance",
                "Current amount of gazoline in station",
                "Current queue",
                "Amount of cars passed",
                "Amount of cars refueld",
                "Summary income",
                "Summary losses",
                "avarage profit form one car"
            };
            foreach(string str in stats)
            {
                ListViewItem lvi = listView1.Items.Add(str);
                lvi.Name = str;
                lvi.SubItems.Add("");

            }
        }

        public double Money;//Balance
        public double Profit;//Summary income
        double Loss; //loss
        const int MaxQueueLen = 4;//Max queue
        int ServCars;//Served cars
        Pump p;
        Random r = new Random();
        private void bStart_Click(object sender, EventArgs e)
        {
            Money = 0;
            Profit = 0;
            Loss = 0;
            ServCars = 0;
            Car.TotalCount = 0;
            p = new Pump();
            timer1.Start();
        }
        int ToCar;
        int ToTanker = 60;
        int[] max_cf = new int[]
        {
            40,60
        };

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ToCar <= 0)
            {
                int max = max_cf[r.Next(max_cf.Length)];
                int curr = r.Next(max + 1);
                Car c = new Car(curr, max, this);
                bool WantsToFill = 3 * curr <= 2 * max;
                if (WantsToFill && (p.QueueLen() < MaxQueueLen) && p.GetFuelCount() > 0)
                {
                    ServCars++;
                    p.Add(c);
                    c.Top = 275;

                }
                else
                {
                    if (WantsToFill)
                    {
                        Loss += c.NeedFill() * (double)(numS.Value - numB.Value);
                    }
                    c.Top = 300;
                }
                ToCar = r.Next((int)numMin.Value, (int)numMax.Value + 1);


            }
            else 
                ToCar--;

            p.Tick(this);


            if (ToTanker <= 0)
            {
                int x = Math.Min(250, p.NeedFill());
                x = Math.Min(x, (int)(Money/(double) numB.Value));
                p.DoFill(x);
                Money -= x * (double)numB.Value;
                ToTanker = 60;
            }
            else
                ToTanker--;
            ShowStats();
        }
        int chartX = 0;
        double max = 0;
        void ShowStats()
        {
            listView1.BeginUpdate();
            listView1.Items["Cash balance"].SubItems[1].Text = Money.ToString();
            listView1.Items["Current amount of gazoline in station"].SubItems[1].Text = p.GetFuelCount().ToString();
            listView1.Items["Current queue"].SubItems[1].Text = p.QueueLen().ToString();
            listView1.Items["Amount of cars passed"].SubItems[1].Text = Car.TotalCount.ToString();
            listView1.Items["Amount of cars refueld"].SubItems[1].Text = ServCars.ToString();
            listView1.Items["Summary income"].SubItems[1].Text = Profit.ToString();
            listView1.Items["Summary losses"].SubItems[1].Text = Loss.ToString();
            listView1.Items["avarage profit form one car"].SubItems[1].Text = ((double)(Profit / Car.TotalCount)).ToString();
            listView1.EndUpdate();

            System.Windows.Forms.DataVisualization.Charting.Series s;
            s = chart1.Series["Profit"];
            while (s.Points.Count > 20) s.Points.RemoveAt(0);
            s.Points.AddXY(chartX, Profit);
            s = chart1.Series["Money"];
            while (s.Points.Count > 20) s.Points.RemoveAt(0);
            s.Points.AddXY(chartX, Money);
            s = chart1.Series["Losses"];
            while (s.Points.Count > 20) s.Points.RemoveAt(0);
            s.Points.AddXY(chartX, Loss);

            chart1.ChartAreas[0].AxisX.Minimum = s.Points[0].XValue; //Ширина региона
            chart1.ChartAreas[0].AxisX.Maximum = chartX;
            max = Math.Max(max, Math.Max(Profit, Math.Max(Money, Loss)));
            chart1.ChartAreas[0].AxisY.Maximum = max;

            chartX++;

        }
    }
}
