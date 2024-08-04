using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appointment_System
{
    class Receipt
    {
        public int Appointment_ID { get; set; }
        public string HaircutName { get; set; }
        public string Price { get; set; }
        public string AmountTendered { get; set; }
        public string Change { get; set; }
        public string Total { get { return string.Format(Price);  } }
    }
}
