
namespace SimplyCastSync.CompareEngine
{
    public interface IComparer
    {
        void Initialize();
        void Mark();
        void Commit();
    }
}
