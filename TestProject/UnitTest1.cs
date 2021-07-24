using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        PersonManagement personManagement;
        [TestInitialize]
        public void TestSetup()
        {

            personManagement = new PersonManagement();
            personManagement.AddPerson();

        }
        //Usecase 2 Retrieve Top two Records"
        [TestMethod]  
        public void GivenRecord_ReturnTop2_AgeLessThan60()
        {
            List<string> expected = new List<string> { "Krithick", "Dhanush" };
            List<string> actual = personManagement.PersonAgeLessThan60();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
