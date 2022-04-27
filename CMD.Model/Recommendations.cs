using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Model
{
    public class Recommendations
    {
        [Key]
        public int RecommendationId { get; set; }
        public Doctor RecommendedDoctor { get; set; }

        [ForeignKey("RecommendedDoctor")]
        public int DoctorId { get; set; }

        public int AppointmentId { get; set; }
    }
}
