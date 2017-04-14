using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyCastSync.CompareEngine
{
    /// <summary>
    /// 
    /// </summary>
    public class JsonDataComparer : IComparer
    {
        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeInsertedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeDeletedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeUpdatedRds_Src { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeInsertedRds_Dest { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeDeletedRds_Dest { get; private set; } = new List<long>();

        /// <summary>
        /// 
        /// </summary>
        public List<long> ToBeUpdatedRds_Dest { get; private set; } = new List<long>();


        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Mark()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Commit()
        {

        }
    }
}
