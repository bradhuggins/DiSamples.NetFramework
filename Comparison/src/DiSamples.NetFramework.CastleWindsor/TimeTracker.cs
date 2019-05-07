#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
#endregion

namespace DiSamples.NetFramework.CastleWindsor
{
    //used to demonstrate method injection

    /// <summary>
    /// The Time Tracker class
    /// </summary>
    public class TimeTracker
    {
        #region Members
        private IEmployee _employee = new NullEmployee();

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>The employee.</value>
        public IEmployee Employee
        {
            get { return this._employee; }
            set { this._employee = value; }
        }

        #endregion

        #region Ctor
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeTracker"/> class.
        /// </summary>
        public TimeTracker()
        {
            this.Initialize(new NullEmployee());
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Initialize(IEmployee employee)
        {
            _employee = employee;
        } 

        #endregion
        
    }


}
