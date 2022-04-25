using CMD.DTO.Doctors;
using CMD.Model.Doctors;
using CMD.Repository.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business.Doctors
{
    public class DoctorManager : IDoctorManager
    {
        IDoctorRepository DoctorRepository = new DoctorRepository();

        public List<DoctorDTO> GetDoctors()
        {
            return DoctorRepository.GetDoctors();

        }
    }
}
