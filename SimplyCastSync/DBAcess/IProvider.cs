
namespace SimplyCastSync.DBAccess
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
        IQuery<T> GetQuery<T>(string queryname, string connstr);
    }
}
