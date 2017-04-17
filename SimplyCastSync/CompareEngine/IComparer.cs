
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
        void Initialize();

        /// <summary>
        /// 
        /// </summary>
        void Mark();

        /// <summary>
        /// 
        /// </summary>
        void Commit();
    }
}
