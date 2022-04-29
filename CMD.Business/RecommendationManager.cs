using CMD.DTO;
using CMD.Model;
using CMD.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD.Business
{
    public class RecommendationManager : IRecommendationManager
    {
        protected IRecommendationRepository Repo = null;

        public RecommendationManager(IRecommendationRepository recommendationRepository)
        {
            this.Repo = recommendationRepository;   
        }

        public Recommendations AddRecommendtaion(Recommendations reco)
        {
            return Repo.AddRecommendtaion(reco);

        }

        public bool RemoveRecommendation(int id)
        {
            return Repo.RemoveRecommendation(id);
        }

        public List<DoctorDTO> GetDoctors()
        {
            return Repo.GetDoctors();

        }


    }
}
