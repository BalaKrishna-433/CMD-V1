using CMD.Business;
using CMD.DTO;
using CMD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CMD.API.Recommendation.Controllers
{
    public class RecommendationController : ApiController
    {
        [RoutePrefix("api/doctor")]
        public class DoctorController : ApiController
        {
            private readonly IRecommendationManager RecommendationManagers = new RecommendationManager();


            [HttpGet]
            public List<DoctorDTO> GetDoctorNames()
            {

                return RecommendationManagers.GetDoctors();
            }






            [Route("Recommendation")]
            [HttpPost]

            public IHttpActionResult AddRecommendation(Recommendations recommendation)
            {
                var reco = RecommendationManagers.AddRecommendtaion(recommendation);


                return Created($"api/recommendation/{reco.RecommendationId}", reco);
            }
            [Route("Recommendation/{id}")]

            [HttpDelete]

            public IHttpActionResult Remove(int id)
            {
                if (!RecommendationManagers.RemoveRecommendation(id))
                    return BadRequest();
                return Ok();


            }


        }
    }
}
