using System.Security.Cryptography;

namespace DaanV2.Filters {
    public partial class BloomFilter {
        /// <summary>Each word stores a set of bits</summary>
        private nuint[] _Words;

        /// <summary></summary>
        private HashAlgorithm[] _Hashcoders;
    }
}
