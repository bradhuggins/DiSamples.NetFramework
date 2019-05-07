#region Using Statement
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static IKernel GetContainer()
        {
            // Create container and register types
            IKernel container = new StandardKernel();      
     
            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static IKernel GetFluentContainer()
        {
            // Create container and register types
            IKernel container = new StandardKernel();

            //setup default object
           container.Bind<IEmployee>().To<FullTimeEmployee>();

            //register named type for fulltime employee
            container.Bind<IEmployee>().To<FullTimeEmployee>().Named("FullTimeEmployee");

            //register named type for contract employee
            container.Bind<IEmployee>().To<ContractEmployee>().Named("ContractEmployee");

            //register for property injection

            //register for method injection

            return container;
        }

    }
}
