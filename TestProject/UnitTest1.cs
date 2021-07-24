using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System.Collections.Generic;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestInitialize]
        public void TestSetup()
        {

            PersonManagement personManagement = new PersonManagement();
            personManagement.AddPerson();

        }
        //Usecase 2 Retrieve Top two Records"
        [TestMethod]  
        public void TestMethodForAgeLessThan60()
        {
            PersonManagement personManagement = new PersonManagement();
            List<string> expected = new List<string> { "Krithick","Dhanush"};
            List<string> actual = personManagement.PersonAgeLessThan60();
            CollectionAssert.AreEqual(expected, actual);
        }
        //Usecase 3 Person Age Between 13 and 18
        [TestMethod]
        public void TestMethodAgeRecordBetween13An18()
        {
            PersonManagement personManagement = new PersonManagement();
            List<string> expected = new List<string> { "Krithick"};
            List<string> actual = personManagement.PersonDataBetweenAge13And18();
            CollectionAssert.AreEqual(expected, actual);
        }
        //Usecase 4 Average age in the list
        [TestMethod]
        public void TestMethodReturnAverageofAge()
        {
            PersonManagement personManagement = new PersonManagement();
            double expected = 31.667;
            double actual = personManagement.AverageAgeRecord();
            Assert.AreEqual(actual, expected);
        }
    }
}
