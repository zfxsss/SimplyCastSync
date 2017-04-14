using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine
{
    public interface IComparer
    {
        void Initialize();
        void Mark();
        void Commit();
    }
}
