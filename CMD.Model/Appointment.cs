using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public string comment { get; set; }



        public ICollection<Recommendations> Recommendations { get; set; }
    }
}
