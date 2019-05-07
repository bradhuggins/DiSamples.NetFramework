#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.UnityTests
{
    /// <summary>
    ///This is a test class for FactoryTest and is intended
    ///to contain all FactoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FactoryTest
    {
        #region Test Methods

        /// <summary>
        ///A test for CreateInstance
        ///</summary>
        [TestMethod()]
        public void CreateInstanceTest()
        {
            //Arrange
            FullTimeEmployee expected = new FullTimeEmployee();
            IEmployee actual;

            //Act
            actual = Factory.CreateInstance();

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        /// <summary>
        ///A test for CreateInstanceWithName
        ///</summary>
        [TestMethod()]
        public void CreateInstanceWithNameTest()
        {
            //Arrange
            ContractEmployee expected = new ContractEmployee();
            IEmployee actual;

            //Act
            actual = Factory.CreateInstanceWithName("ContractEmployee");

            //Assert
            Assert.AreEqual(expected.GetType(), actual.GetType());
        } 

        #endregion

    }
}
