using Bogus;

namespace BogusActionFilter.Interfaces
{
    /// <summary>
    /// Interface used by BogusAutoFilter to get rules for generating the entity when its a return type on the applied controller
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFakedEntity<T> where T : class
    {
        /// <summary>
        /// Returns a Faker<T> instance of the main entity that the interface is applied to so rules can be set on an entity level
        /// </summary>
        /// <returns>Faker<typeparamref name="T"/></returns>
        public Faker<T> GetFaker();
    }
}
