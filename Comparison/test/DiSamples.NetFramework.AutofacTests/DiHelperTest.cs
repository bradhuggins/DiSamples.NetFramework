﻿#region Using Statements
using Autofac;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endregion

namespace DiSamples.NetFramework.AutofacTests
{
    /// <summary>
    ///This is a test class for DiHelper and is intended
    ///to contain all DiHelper Unit Tests
    ///</summary>
    [TestClass()]
    public class DiHelperTest
    {
        #region Test Methods

        //[TestMethod()]
        //public void GetContainerTest()
        //{
        //    //Arrange
        //    FullTimeEmployee expected = new FullTimeEmployee();
        //    var container = DIHelper.GetContainer();

        //    //Act
        //    IEmployee actual = container.Resolve<IEmployee>();

        //    //Assert
        //    Assert.IsNotNull(actual);
        //    Assert.AreEqual(expected.GetType(), actual.GetType());
        //}

        //[TestMethod()]
        //public void GetContainerNamedTest()
        //{
        //    //Arrange
        //    ContractEmployee expected = new ContractEmployee();
        //    var container = DIHelper.GetContainer();

        //    //Act
        //    IEmployee actual = container.Resolve<IEmployee>("ContractEmployee");

        //    //Assert
        //    Assert.IsNotNull(actual);
        //    Assert.AreEqual(expected.GetType(), actual.GetType());
        //}

        [TestMethod()]
        public void GetFluentContainerTest()
        {
            //Arrange
            FullTimeEmployee expected = new FullTimeEmployee();
            var container = DIHelper.GetFluentContainer();

            //Act
            IEmployee actual = container.Resolve<IEmployee>();

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        [TestMethod()]
        public void GetFluentContainerNamedTest()
        {
            //Arrange
            ContractEmployee expected = new ContractEmployee();
            var container = DIHelper.GetFluentContainer();

            //Act
            IEmployee actual = container.ResolveNamed<IEmployee>("ContractEmployee");

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        #endregion

    }
}
