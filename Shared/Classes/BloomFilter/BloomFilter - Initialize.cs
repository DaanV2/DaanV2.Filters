using System.Security.Cryptography;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for class: BloomFilter</summary>
    public partial class BloomFilter {
        /// <summary>Creates a new instance of <see cref="BloomFilter"/></summary>
        /// <param name="BitAmount"></param>
        /// <param name="Hashcoders"></param>
        public BloomFilter(Int32 BitAmount, Int32 Hashcoders) :
            this(new nuint[(BitAmount / Constants.BitsNUInt) + 1], new HashAlgorithm[Hashcoders]) { }

        /// <summary>Creates a new instance of <see cref="BloomFilter"/></summary>
        /// <param name="Words"></param>
        /// <param name="Hashcoders"></param>
        public BloomFilter(nuint[] Words, HashAlgorithm[] Hashcoders) {
            this._Lock = new ReaderWriterLock();
            this._Words = Words;
            this._Hashcoders = Hashcoders;
        }
    }
}
