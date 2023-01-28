using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for interface: IBinarySerializer</summary>
    public interface IBinarySerializer<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        Byte[] Serialize(T Item);        
    }
}
