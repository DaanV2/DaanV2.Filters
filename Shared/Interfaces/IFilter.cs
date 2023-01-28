using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for interface: IFilter</summary>
    public interface IFilter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        Result Has(ReadOnlySpan<Byte> Data);
        
        /// <summary>Add the binary data to the filter</summary>
        /// <param name="Data">The binary data to add</param>
        void Add(ReadOnlySpan<Byte> Data);
    }
}
