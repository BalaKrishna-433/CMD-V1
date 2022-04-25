using CMD.Business.Doctors;
using CMD.DTO.Doctors;
using CMD.Model.Doctors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMD.API.Doctors.Controllers
{
    [RoutePrefix("api/doctor")]
    public class DoctorController : ApiController
    {
       private IDoctorManager DoctorManager = new DoctorManager();


        [HttpGet]
        public List<DoctorDTO> GetDoctorNames()
        {

            return DoctorManager.GetDoctors();
        }

    }
}
