using CMD.Model.Appointments;
using CMD.Model.Doctors;
using CMD.Repository.Appointments;
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

        IAppointmentRepository obj;
        [TestInitialize]
        public void ObjectCreation()
        {
            obj = new   AppointmentRepository();

        }

        [TestCleanup]
        public void ObjectDeletion()
        {
            obj = null;

        }

        

        //[TestMethod]
        //public void AddRecommedations_ShouldAddRecommendations()
        //{
        //    var recommendation = new Recommendation();
        //    Doctor doctor = new Doctor() { DoctorId = 1 };
        //    reco.RecommendedDoctor = doctor;
        //    Appointment appointment = db.Appointments.Find(reco.AppointmentId);
        //    reco = db.Recommendations.Add(reco);

        //    var doc = obj.AddRecommendtaion(recommendation);
        //    Assert.IsNotNull(doc);

        //}

        [TestMethod]
        public void RemoveRecommendations_ShouldRemoveRecommendations()
        {
            int id = 4;
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
