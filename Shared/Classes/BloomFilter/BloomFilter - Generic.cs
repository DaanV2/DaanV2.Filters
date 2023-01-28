using System.Security.Cryptography;

namespace DaanV2.Filters {
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TSerializer"></typeparam>
    /// <typeparam name="TItem"></typeparam>
    public partial class BloomFilter<TSerializer, TItem>
        : ObjectFilter<TSerializer, TItem, BloomFilter>
        where TSerializer : IBinarySerializer<TItem> {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Serializer"></param>
        /// <param name="BitAmount"></param>
        /// <param name="Hashcoders"></param>
        public BloomFilter(TSerializer Serializer, Int32 BitAmount, Int32 Hashcoders)
            : base(new BloomFilter(BitAmount, Hashcoders), Serializer) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Serializer"></param>
        /// <param name="Words"></param>
        /// <param name="Hashcoders"></param>
        public BloomFilter(TSerializer Serializer, nuint[] Words, HashAlgorithm[] Hashcoders)
            : base(new BloomFilter(Words, Hashcoders), Serializer) { }
    }
}
