using CMD.DbContextAll;
using CMD.DTO.Doctors;
using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Doctors
{

    public class DoctorRepository : IDoctorRepository
    {
        CMDDbContext db = new CMDDbContext();
        public List<DoctorDTO> GetDoctors()
        {
            List<DoctorDTO> list = new List<DoctorDTO>();
            List<Doctor> doctors = db.Doctors.ToList();
            foreach (Doctor doctor in doctors)
            {
                DoctorDTO temp = new DoctorDTO(); 
                temp.DoctorId= doctor.DoctorId;  
                temp.DoctorName= doctor.DoctorName;
                list.Add(temp);
            }
            return list;
        }
    }
}
