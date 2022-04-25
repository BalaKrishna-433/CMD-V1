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
    public interface IDoctorManager
    {
        //IDoctorRepository DoctorRepository = new DoctorRepository();
        List<DoctorDTO> GetDoctors();
    }
}
