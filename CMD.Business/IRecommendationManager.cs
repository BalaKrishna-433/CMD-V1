using CMD.DTO;
using CMD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business
{
    public interface IRecommendationManager
    {

        Recommendations AddRecommendtaion(Recommendations reco);



        bool RemoveRecommendation(int id);

        List<DoctorDTO> GetDoctors();


    }
}
