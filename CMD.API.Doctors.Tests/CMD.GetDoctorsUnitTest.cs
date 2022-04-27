using CMD.Repository.Doctors;
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
        
        IDoctorRepository obj;
        [TestInitialize]
        public void ObjectCreation()
        {
            obj = new DoctorRepository();
            
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
