using CMD.DbContextAll;
using CMD.Model.Appointments;
using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Appointments
{
    public class AppointmentRepository : IAppointmentRepository
    {
        CMDDbContext db = new CMDDbContext();

        public Recommendation AddRecommendtaion(Recommendation reco)
        {
            Doctor doctor = db.Doctors.Find(reco.DoctorId);
            reco.RecommendedDoctor = doctor;
            Appointment appointment = db.Appointments.Find(reco.AppointmentId);
             reco = db.Recommendations.Add(reco);

            appointment.Recommendations.Add(reco);

            db.Appointments.Append(appointment);
            db.SaveChanges();
            return reco;
        }

        //public ICollection<Recommendation> GetAllRecommendation()
        //{
        //    return db.Appointments.Include("Recommendation").Include("RecommendedDoctor").ToList();
        //}

        public bool RemoveRecommendation(int id)
        {
            var r = db.Recommendations.Find(id);
            if (r == null) return false;  
            db.Recommendations.Remove(r);
            return db.SaveChanges() > 0;

        }
    }
}

