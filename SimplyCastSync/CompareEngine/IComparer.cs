
namespace SimplyCastSync.CompareEngine
{
    /// <summary>
    /// 
    /// </summary>
    public interface IComparer
    {

        /// <summary>
        /// 
        /// </summary>
        void InitializeS(params object[] p);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        void InitializeD(params object[] p);

        /// <summary>
        /// 
        /// </summary>
        void Mark(params object[] p);

        /// <summary>
        /// 
        /// </summary>
        void Commit();
    }
}
