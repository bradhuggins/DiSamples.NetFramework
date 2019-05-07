#region Using Statements
using DiSamples.NetFramework.Domain.Interfaces;
#endregion

namespace DiSamples.NetFramework.Domain.Models
{
    /// <summary>
    /// Represents a Contract Employee
    /// </summary>
    public class ContractEmployee : IEmployee
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
        /// Gets or sets the hourly rate.
        /// </summary>
        /// <value>The hourly rate.</value>
        public decimal HourlyRate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the hours worked.
        /// </summary>
        /// <value>The hours worked.</value>
        public decimal HoursWorked
        {
            get;
            set;
        }

        #endregion

        #region Ctor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractEmployee"/> class.
        /// </summary>
        public ContractEmployee()
        {
            this.Id = 0;
            this.DisplayName = string.Empty;
            this.HourlyRate = 0;
            this.HoursWorked = 0;
        }

        ///// <summary>
        ///// Initializes a new instance of the <see cref="ContractEmployee"/> class.
        ///// </summary>
        ///// <param name="id">The id.</param>
        ///// <param name="displayName">The display name.</param>
        ///// <param name="hourlyRate">The hourly rate.</param>
        ///// <param name="hoursWorked">The hours worked.</param>
        //public ContractEmployee(int id, string displayName, decimal hourlyRate, decimal hoursWorked)
        //{
        //    this.Id = id;
        //    this.DisplayName = displayName;
        //    this.HourlyRate = hourlyRate;
        //    this.HoursWorked = hoursWorked;
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
            return this.CalculateBiWeeklyPay(this.HourlyRate, this.HoursWorked);
        }

        /// <summary>
        /// Calculates the bi weekly pay.
        /// </summary>
        /// <param name="hourlyRate">The hourly rate.</param>
        /// <param name="hoursWorked">The hours worked.</param>
        /// <returns>decimal value representing the bi-weekly pay amount</returns>
        public decimal CalculateBiWeeklyPay(decimal hourlyRate, decimal hoursWorked)
        {
            return hourlyRate * hoursWorked;
        }

        /// <summary>
        /// Displays the type of the employee.
        /// </summary>
        /// <returns>a string with the type of employee</returns>
        public string DisplayEmployeeType()
        {
            return "Contractor";
        }

        #endregion


    }

}
