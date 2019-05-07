#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
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
            IKernel kernel = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = kernel.Get<IEmployee>();
            return obj;
        }


        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IEmployee interface</returns>
        public static IEmployee CreateInstanceWithName(string name)
        {
            // Create container and register types
            IKernel kernel = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = kernel.Get<IEmployee>(name);
            return obj;
        }
        
        #endregion

    }
}
