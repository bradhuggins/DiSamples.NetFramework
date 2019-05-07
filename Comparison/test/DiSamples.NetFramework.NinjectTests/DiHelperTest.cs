#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using DiSamples.NetFramework.Ninject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;
#endregion

namespace DiSamples.NetFramework.NinjectTests
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
        //    IEmployee actual = container.GetInstance<IEmployee>();

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
        //    IEmployee actual = container.GetInstance<IEmployee>("ContractEmployee");

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
            IEmployee actual = container.Get<IEmployee>();

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
            IEmployee actual = container.Get<IEmployee>("ContractEmployee");

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.GetType(), actual.GetType());
        }

        #endregion

    }
}
