using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for interface: IFilter</summary>
    public interface IFilter<T> {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        Result Has(T Item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Item"></param>
        void Add(T Item);
    }
}
