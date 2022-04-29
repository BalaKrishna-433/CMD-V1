
using CMD.Model;
using CMD.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMD.API.Appointments.Tests
{
    /// <summary>
    /// Summary description for CMD
    /// </summary>
    [TestClass]
    public class CMD
    {

        IRecommendationRepository obj;
        [TestInitialize]
        public void ObjectCreation()
        {
            obj = new   RecommendationRepository();

        }

        [TestCleanup]
        public void ObjectDeletion()
        {
            obj = null;

        }



        [TestMethod]
        public void AddRecommedations_ShouldAddRecommendations()
        {
            CMDDbContext db = new CMDDbContext();

            var recommendation = new Recommendations();
            var doctor = db.Doctors.Find(1);
            recommendation.RecommendedDoctor = doctor;
            recommendation.AppointmentId = 1;
            var result = db.Recommendations.Add(recommendation);
            Assert.IsNotNull(result);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        
        public void AddRecommedations_withWrongData_ShouldnotAddRecommendations()
        {
            CMDDbContext db = new CMDDbContext();

            Recommendations recommendation = null;
            
            
            var result = db.Recommendations.Add(recommendation);
        }




        [TestMethod]
        public void RemoveRecommendations_ShouldRemoveRecommendations()
        {
            int id = 8;
            var result = obj.RemoveRecommendation(id);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void RemoveRecommendations_WithWrongId_ShouldNotRemoveRecommendations()
        {
            int id = 1;
            var result = obj.RemoveRecommendation(id);
            Assert.IsFalse(result);
        }
    }
}
