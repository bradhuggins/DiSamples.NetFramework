#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using StructureMap;
#endregion

namespace DiSamples.NetFramework.StructureMap
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
            Container container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = container.GetInstance<IEmployee>();
            return obj;
        }

        /// <summary>
        /// Creates a named instance.
        /// </summary>
        /// <returns>An object that implements the IEmployee interface</returns>
        public static IEmployee CreateInstanceWithName(string name)
        {
            // Create container and register types
            Container container = DIHelper.GetFluentContainer();

            // Retrieve an instance 
            IEmployee obj = container.GetInstance<IEmployee>(name);
            return obj;
        }
        
        #endregion

    }
}
