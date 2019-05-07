#region Using Statements
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    /// <summary>
    /// Factory pattern class - Automatic Factories in Unity 2
    /// </summary>
    public static class Factory
    {
        #region Methods

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <returns>An object that implements the IEmployee interface</returns>
        public static IEmployee CreateInstance()
        {
            // Create container and register types
            IWindsorContainer container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = container.Resolve<IEmployee>();
            return obj;
        }

        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IEmployee interface</returns>
        public static IEmployee CreateInstanceWithName(string name)
        {
            // Create container and register types
            IWindsorContainer container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = container.Resolve<IEmployee>(name);
            return obj;
        }
        
        #endregion

    }
}
