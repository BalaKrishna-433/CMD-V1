using CMD.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMD.API.Doctors.Tests
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
            obj = new RecommendationRepository();
            
        }

        [TestCleanup]
        public void ObjectDeletion()
        {
            obj = null;

        }



        [TestMethod]
            public void GetDoctors_ShouldReturnAllDoctors()
            {

                var doc = obj.GetDoctors();
                Assert.IsNotNull(doc);

            }
        

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void GetDoctors_IncorrectDataBase_ShouldReturnNull()
        {

            var doc = obj.GetDoctors();

        }
    }
}
