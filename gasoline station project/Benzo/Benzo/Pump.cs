using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benzo
{
  public class Pump
    {
        int FuelCount = 250;
        int MaxFuelCount = 250;
      public  List<Car> queue = new List<Car>();
        public Pump()
        {

        }
        public int NeedFill()
        {
            return MaxFuelCount - FuelCount;
        }
        public void DoFill(int x)
        {
            FuelCount += x;

        }
        public void Add(Car c)
        {
            queue.Add(c);
            c.p = this;
        }
        public int QueueLen()
        {
            return queue.Count;
        }
        public int GetFuelCount()
        {
            return FuelCount;
        }
        public void Tick(Form1 f)
        {
            if (queue.Count == 0) return;
            Car c = queue[0];
            int x = Math.Min(10, FuelCount);
            x = Math.Min(x, c.NeedFill());
            if (c.CanBeFeel)
            {
                c.DoFill(x);
                f.Money += x * (double)f.numS.Value;
                f.Profit += x * (double)(f.numS.Value - f.numB.Value);
                FuelCount -= x;
            }
            if (c.IsFull() || x == 0)
            {
                queue.RemoveAt(0);
                c.p = null;
            }

        }
    }
}
