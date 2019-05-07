#region Using Statements
using Autofac;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.Autofac
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IContainer GetContainer()
        {
            // Create container and register types
            var builder = new ContainerBuilder();
            IContainer container = builder.Build();

            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IContainer GetFluentContainer()
        {
            // Create container and register types
            var builder = new ContainerBuilder();

            //setup default object
            builder.RegisterType<FullTimeEmployee>().As<IEmployee>();

            //register named type for fulltime employee
            builder.RegisterType<FullTimeEmployee>().Named<IEmployee>("FullTimeEmployee");

            //register named type for contract employee
            builder.RegisterType<ContractEmployee>().Named<IEmployee>("ContractEmployee");

            builder.RegisterType<PayrollProcessor>().As<PayrollProcessor>();

            //register for property injection
            builder.RegisterType<Authenticator>().As<Authenticator>().PropertiesAutowired();

            //register for method injection
            builder.RegisterType<TimeTracker>().As<TimeTracker>().PropertiesAutowired();

            IContainer container = builder.Build();

            return container;
        }

    }
}
