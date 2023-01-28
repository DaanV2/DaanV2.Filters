using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    /// <summary>A wrapper around an object serializer and filter to create a filter for objects</summary>
    /// <typeparam name="TSerializer"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    /// <typeparam name="TFilter"></typeparam>
    public partial class ObjectFilter<TSerializer, TItem, TFilter> : IFilter<TItem>, IFilter
        where TFilter : IFilter
        where TSerializer : IBinarySerializer<TItem> { 
        
        /// <inheritdoc/>
        public void Add(ReadOnlySpan<Byte> Data) {
            this._Filter.Add(Data);
        }

        /// <inheritdoc/>
        public void Add(TItem Item) {
            Byte[] Data = this._Serializer.Serialize(Item);
            this.Add(Data);
        }

        /// <inheritdoc/>
        public Result Has(ReadOnlySpan<Byte> Data) {
            return this._Filter.Has(Data);
        }

        /// <inheritdoc/>
        public Result Has(TItem Item) {
            Byte[] Data = this._Serializer.Serialize(Item);
            return this.Has(Data);
        }
    }
}
