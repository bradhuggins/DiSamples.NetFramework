#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
#endregion

namespace DiSamples.NetFramework.Domain.Models
{
    /// <summary>
    /// Represents a Bogus Employee
    /// </summary>
    public class NullEmployee : IEmployee
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        public string DisplayName
        {
            get;
            set;
        }

        #endregion
        
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="FullTimeEmployee"/> class.
        /// </summary>
        public NullEmployee()
        {
            this.Id = 0;
            this.DisplayName = string.Empty;
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="FullTimeEmployee"/> class.
        ///// </summary>
        ///// <param name="id">The id.</param>
        ///// <param name="displayName">The display name.</param>
        //public NullEmployee(int id, string displayName)
        //{
        //    this.Id = id;
        //    this.DisplayName = displayName;
        //}

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the bi-weekly pay.
        /// </summary>
        /// <returns>
        /// decimal value representing the bi-weekly pay amount
        /// </returns>
        public decimal CalculateBiWeeklyPay()
        {
            return 0.0M;
        }

        /// <summary>
        /// Displays the type of the employee.
        /// </summary>
        /// <returns>a string with the type of employee</returns>
        public string DisplayEmployeeType()
        {
            return "NULL";
        }

        #endregion
    }
}
