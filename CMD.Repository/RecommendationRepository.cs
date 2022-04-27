using CMD.DTO;
using CMD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository
{
    public class RecommendationRepository : IRecommendationRepository
    {
        CMDDbContext db = new CMDDbContext();

        public Recommendations AddRecommendtaion(Recommendations reco)
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



        public bool RemoveRecommendation(int id)
        {
            var r = db.Recommendations.Find(id);
            if (r == null) return false;
            db.Recommendations.Remove(r);
            return db.SaveChanges() > 0;

        }



        public List<DoctorDTO> GetDoctors()
        {
            List<DoctorDTO> list = new List<DoctorDTO>();
            List<Doctor> doctors = db.Doctors.ToList();
            foreach (Doctor doctor in doctors)
            {
                DoctorDTO temp = new DoctorDTO();
                temp.DoctorId = doctor.DoctorId;
                temp.DoctorName = doctor.DoctorName;
                list.Add(temp);
            }
            return list;
        }
    }
}
