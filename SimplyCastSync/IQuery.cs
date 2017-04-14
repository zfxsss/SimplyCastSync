using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync
{
    using System.Data;
    public interface IQuery
    {
        DataSet GetDataSet();
    }
}
