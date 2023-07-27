namespace BogusActionFilter.Models
{
    /// <summary>
    /// Configuration class for turning on the action filter and other configuration settings
    /// </summary>
    public class BogusActionFilterConfiguration
    {
        /// <summary>
        /// Tells the filter to replace response data from the controllers with data generated in Faker
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// When the return type is an ennumerable or list this determins the default number of records to return
        /// </summary>
        public int RecordReturnCount { get; set; }
    }
}
