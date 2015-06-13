using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfuel.Model
{
    public class FillUp
    {
        public FillUp()
        {
            this.Date = DateTime.Now;
        }
        public int Odometer { get; set; }

        public bool IsFull { get; set; }

        public double Liters { get; set; }

        public DateTime Date { get; set; }
    }
}
