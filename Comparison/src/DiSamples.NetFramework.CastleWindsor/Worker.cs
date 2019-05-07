#region Using Statements
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
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
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<PayrollProcessor>().Named("PayrollProcessor"),
                Component.For<IEmployee>().ImplementedBy<FullTimeEmployee>()
            );

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
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<Authenticator>().Named("Authenticator"),
                Component.For<IEmployee>().ImplementedBy<FullTimeEmployee>()
            );

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("Employee", new FullTimeEmployee());

            //uses the FullTimeEmployee as dependecy
            Authenticator auth = container.Resolve<Authenticator>(properties);
            return auth;
        }

        /// <summary>
        /// Gets the time tracker.
        /// </summary>
        /// <returns>an injected timetracker object</returns>
        public TimeTracker GetTimeTracker()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();
            container.Register(
                Component.For<TimeTracker>().Named("TimeTracker"),
                Component.For<IEmployee>().ImplementedBy<FullTimeEmployee>()
            );

            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("Employee", new FullTimeEmployee());

            //uses the FullTimeEmployee as dependecy
            TimeTracker timetracker = container.Resolve<TimeTracker>(properties);
            return timetracker;
        }
        
        #endregion

    }
}
