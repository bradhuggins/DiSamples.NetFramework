#region Using Statements
#endregion

namespace DiSamples.NetFramework.Domain.Interfaces
{
    /// <summary>
    /// Interface defining an Employee object
    /// </summary>
    public interface IEmployee
    {
        #region Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>The display name.</value>
        string DisplayName { get; set; } 

        #endregion

        #region Methods

        /// <summary>
        /// Calculates the bi-weekly pay.
        /// </summary>
        /// <returns>decimal value representing the bi-weekly pay amount</returns>
        decimal CalculateBiWeeklyPay();

        /// <summary>
        /// Displays the type of the employee.
        /// </summary>
        /// <returns>a string with the type of employee</returns>
        string DisplayEmployeeType();

        #endregion

    }
}
