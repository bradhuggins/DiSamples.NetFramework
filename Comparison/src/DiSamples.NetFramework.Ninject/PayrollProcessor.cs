#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
using DiSamples.NetFramework.Domain.Models;
using Ninject;
#endregion

namespace DiSamples.NetFramework.Ninject
{
    //used to demonstrate contructor injection

    /// <summary>
    /// The Payroll Processor class
    /// </summary>
    public class PayrollProcessor
    {
        #region Private Variables

        private IEmployee _employee;

        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>The employee.</value>
        public IEmployee Employee
        {
            get
            {
                return this._employee;
            }
            set
            {
                this._employee = value;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollProcessor"/> class.
        /// </summary>
        public PayrollProcessor()
        {
            this._employee = new FullTimeEmployee();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayrollProcessor"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        [Inject]
        public PayrollProcessor([Named("FullTimeEmployee")]IEmployee employee)
        {
            this._employee = employee;
        } 

        #endregion
        
    }
}
