using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonDataManagement;
using System;
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
        //Usecase 5 search specific name
        [TestMethod]
        [DataRow("Krithick", "Found")]
        [DataRow("krish", "Not Found")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        public void TestMethodSearchaValue(string searchValue, string expected)
        {
            PersonManagement personManagement = new PersonManagement();
            try
            {
                string actual = personManagement.SearchingSpecificName(searchValue);
                Assert.AreEqual(actual, expected);
            }
            catch (Exception ex)
            {

                Assert.AreEqual(ex.Message, expected);
            }
        }
        //Usecase 6 Retrieve Record where age greater than 60 andignores data less than 60
        [TestMethod]
        public void TestMethodToSkipData()
        {
            try
            {
                PersonManagement personManagement = new PersonManagement();
                List<string> expected = new List<string>() { "Kiran"};
                List<string> actual = personManagement.SkipRecordLessThan60();
                CollectionAssert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                string expect = "No Record";
                Assert.AreEqual(ex.Message, expect);
            }

        }
        //Usecase 7 Remove an element from list
        [TestMethod]
        public void TestMethodForRemove()
        {

            PersonManagement personManagement = new PersonManagement();
            try
            {
                int expected = 1;
                int actual = personManagement.RemoveSpecificName("Dhanush");
                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                int expect = 0;
                Assert.AreEqual(ex.Message, expect);
            }

        }
    }
}
