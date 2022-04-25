using CMD.DTO.Doctors;
using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository.Doctors
{
    public interface IDoctorRepository
    {

        List<DoctorDTO> GetDoctors();

    }
}
