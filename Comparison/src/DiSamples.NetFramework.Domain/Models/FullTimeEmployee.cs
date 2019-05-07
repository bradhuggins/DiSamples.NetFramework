#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
#endregion

namespace DiSamples.NetFramework.Domain.Models
{
    /// <summary>
    /// Represents a Full-Time Employee
    /// </summary>
    public class FullTimeEmployee : IEmployee
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

        /// <summary>
        /// Gets or sets the annual salary.
        /// </summary>
        /// <value>The annual salary.</value>
        public decimal AnnualSalary
        {
            get;
            set;
        }

        #endregion
        
        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="FullTimeEmployee"/> class.
        /// </summary>
        public FullTimeEmployee()
        {
            this.Id = 0;
            this.DisplayName = string.Empty;
            this.AnnualSalary = 0;
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="FullTimeEmployee"/> class.
        ///// </summary>
        ///// <param name="id">The id.</param>
        ///// <param name="displayName">The display name.</param>
        ///// <param name="annualSalary">The annual salary.</param>
        //public FullTimeEmployee(int id, string displayName, decimal annualSalary)
        //{
        //    this.Id = id;
        //    this.DisplayName = displayName;
        //    this.AnnualSalary = annualSalary;
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
            return this.CalculateBiWeeklyPay(this.AnnualSalary);
        }

        /// <summary>
        /// Calculates the bi weekly pay.
        /// </summary>
        /// <param name="annualSalary">The annual salary.</param>
        /// <returns>decimal value representing the bi-weekly pay amount</returns>
        public decimal CalculateBiWeeklyPay(decimal annualSalary)
        {
            return annualSalary / (24.0M);
        }

        /// <summary>
        /// Displays the type of the employee.
        /// </summary>
        /// <returns>a string with the type of employee</returns>
        public string DisplayEmployeeType()
        {
            return "FTE";
        }

        #endregion


    }

}
