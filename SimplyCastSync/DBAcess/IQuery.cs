
namespace SimplyCastSync.DBAccess
{
    using System.Data;
    public interface IQuery<T>
    {
        /// <summary>
        /// 
        /// </summary>k
        /// <returns></returns>
        T GetData(string querystr);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        int UpdateData(T ds);

    }
}
