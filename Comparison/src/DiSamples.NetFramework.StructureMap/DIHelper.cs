#region Using Statement
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
{
    /// <summary>
    /// Used to help implement the DI Container
    /// </summary>
    public static class DIHelper
    {
        /// <summary>
        /// Gets the container (using native config).
        /// </summary>
        public static Container GetContainer()
        {
            // Create container and register types
            Container container = new Container();      
     
            return container;
        }

        /// <summary>
        /// Gets the container (using fluent config).
        /// </summary>
        public static Container GetFluentContainer()
        {
            // Create container and register types
            Container container = new Container( c =>
            {
                //setup default object
                c.For<IEmployee>().Use<FullTimeEmployee>();

                //register named type for fulltime employee
                c.For<IEmployee>().Add<FullTimeEmployee>().Named("FullTimeEmployee").HasExplicitName();

                //register named type for contract employee
                c.For<IEmployee>().Add<ContractEmployee>().Named("ContractEmployee").HasExplicitName();

                //register for property injection

                //register for method injection
                c.For<TimeTracker>().Use<TimeTracker>()
                .OnCreation((d, o) => o.Initialize(d.GetInstance<IEmployee>()));

            });
            return container;
        }

    }
}
