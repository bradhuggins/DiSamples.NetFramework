#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Ninject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.NinjectTests
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

            //Act
            List<IEmployee> results = target.GetEmployees();

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

            //Act
            PayrollProcessor actual = target.GetPayrollProcessor();

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

            //Act
            Authenticator actual = target.GetAuthenticator();

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

            //Act
            TimeTracker actual = target.GetTimeTracker();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreSame(typeof(FullTimeEmployee), actual.Employee.GetType());
        }

        #endregion

    }
}
