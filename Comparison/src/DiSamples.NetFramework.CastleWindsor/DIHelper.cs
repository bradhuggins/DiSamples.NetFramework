#region Using Statements
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    /// <summary>
    ///  Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IWindsorContainer GetContainer()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer(new XmlInterpreter());    
     
            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IWindsorContainer GetFluentContainer()
        {
            // Create container and register types
            IWindsorContainer container = new WindsorContainer();

            //setup default object
            container.Register(
                Component.For<IEmployee>().ImplementedBy<FullTimeEmployee>()
                );

            //register named type for fulltime employee
            container.Register(
                Component.For<IEmployee>().ImplementedBy<FullTimeEmployee>().Named("FullTimeEmployee")
                );

            //register named type for contract employee
            container.Register(
                Component.For<IEmployee>().ImplementedBy<ContractEmployee>().Named("ContractEmployee")
                );

            container.Register(
                Component.For<PayrollProcessor>().Named("PayrollProcessor")
            );

            //register for property injection
            container.Register(
                Component.For<Authenticator>().Named("Authenticator")
            );

            //register for method injection
            container.Register(
                Component.For<TimeTracker>().Named("TimeTracker")
            );

            return container;
        }

    }
}
