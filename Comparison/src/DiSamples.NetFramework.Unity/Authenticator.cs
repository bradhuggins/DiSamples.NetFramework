#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using Unity;
#endregion

namespace DiSamples.NetFramework.Unity
{
    //used to demonstrate property setter injection

    /// <summary>
    /// Authenticator class 
    /// </summary>
    public class Authenticator
    {
        #region Members
        private IEmployee _employee;
        
        #endregion

        #region Properties
                
        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>The employee.</value>
        [Dependency]
        public IEmployee Employee
        {
            get { return this._employee; }
            set { this._employee = value; }
        } 

        #endregion
        
    }
}
