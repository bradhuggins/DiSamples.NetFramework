#region Using Statements
using System.Collections.Generic;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    /// <summary>
    /// Worker class
    /// </summary>
    public class Worker
    {
        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        public Worker()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Does the work.
        /// </summary>
        /// <returns>A collection of IEmployees</returns>
        public List<IEmployee> GetEmployees()
        {
            List<IEmployee> employees = new List<IEmployee>();

            IEmployee employee1 = Factory.CreateInstance();
            employee1.Id = 123;
            employee1.DisplayName = "Joe Employee";
            employees.Add(employee1);

            IEmployee employee2 = Factory.CreateInstance();
            employee2.Id = 456;
            employee2.DisplayName = "Marge Manager";
            employees.Add(employee2);

            IEmployee employee3 = Factory.CreateInstanceWithName("ContractEmployee");
            employee3.Id = 789;
            employee3.DisplayName = "Bob Contractor";
            employees.Add(employee3);

            return employees;
        }

        /// <summary>
        /// Sample of Constructor Injection with Unity
        /// </summary>
        /// <returns>Payroll processor</returns>
        public PayrollProcessor GetPayrollProcessor()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            //uses the FullTimeEmployee to process
            PayrollProcessor processorFTE = container.Resolve<PayrollProcessor>();

            return processorFTE;
        }

        /// <summary>
        /// Injects the authenticator.
        /// </summary>
        /// <returns>an injected authenticator object</returns>
        public Authenticator GetAuthenticator()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            //uses the FullTimeEmployee as dependecy
            Authenticator auth = container.Resolve<Authenticator>();
            return auth;
        }

        /// <summary>
        /// Gets the time tracker.
        /// </summary>
        /// <returns>an injected timetracker object</returns>
        public TimeTracker GetTimeTracker()
        {
            // Create container and register types
            IUnityContainer container = DIHelper.GetFluentContainer();

            //uses the FullTimeEmployee as dependecy
            TimeTracker timetracker = container.Resolve<TimeTracker>();
            return timetracker;
        }
        
        #endregion
        
    }
}
