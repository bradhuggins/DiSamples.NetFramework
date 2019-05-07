#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.UnityTests
{
    /// <summary>
    ///This is a test class for WorkerTest and is intended
    ///to contain all WorkerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WorkerTest
    {
        #region Test Methods

        /// <summary>
        ///A test for Worker Constructor
        ///</summary>
        [TestMethod()]
        public void WorkerConstructorTest()
        {
            //Arrange
            Worker target = new Worker();

            //Act

            //Assert
            Assert.IsNotNull(target);
        }
    
        /// <summary>
        ///A test for GetEmployees
        ///</summary>
        [TestMethod()]
        public void GetEmployeesTest()
        {
            //Arrange
            Worker target = new Worker();
            List<IEmployee> results = target.GetEmployees();

            //Act

            //Assert
            Assert.IsNotNull(results);
            Assert.IsTrue(results.Count >= 0);
        }

        /// <summary>
        ///A test for GetPayrollProcessor
        ///</summary>
        [TestMethod()]
        public void GetPayrollProcessorTest()
        {
            //Arrange
            Worker target = new Worker();
            PayrollProcessor actual = target.GetPayrollProcessor();

            //Act

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(FullTimeEmployee), actual.Employee.GetType());
        }

        /// <summary>
        ///A test for GetAuthenticator
        ///</summary>
        [TestMethod()]
        public void GetAuthenticatorTest()
        {
            //Arrange
            Worker target = new Worker();
            Authenticator actual = target.GetAuthenticator();

            //Act

            //Assert
            Assert.AreEqual(typeof(FullTimeEmployee), actual.Employee.GetType());
        } 

        /// <summary>
        ///A test for GetTimeTracker
        ///</summary>
        [TestMethod()]
        public void GetTimeTrackerTest()
        {
            //Arrange
            Worker target = new Worker();
            TimeTracker actual = target.GetTimeTracker();

            //Act

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(FullTimeEmployee), actual.Employee.GetType());
        }

        #endregion

    }
}
