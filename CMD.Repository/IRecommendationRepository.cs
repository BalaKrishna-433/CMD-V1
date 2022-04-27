using CMD.DTO;
using CMD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Repository
{
    public interface IRecommendationRepository
    {
        List<DoctorDTO> GetDoctors();

        Recommendations AddRecommendtaion(Recommendations reco);



        bool RemoveRecommendation(int id);


    }
}
