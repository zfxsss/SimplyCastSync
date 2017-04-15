
namespace SimplyCastSync.DataSource
{
    /// <summary>
    /// 
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IDataSrc<T> GetDs<T>(string dsname);
    }
}
