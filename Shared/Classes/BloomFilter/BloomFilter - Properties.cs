using System.Numerics;

namespace DaanV2.Filters {
    public partial class BloomFilter {
        /// <summary></summary>
        public Int32 Capacity => this._Words.Length * Constants.BitsNUInt;

        /// <summary></summary>
        public Int32 Count {
            get {
                Int32 Count = 0;

                for (Int32 I = 0; I < this._Words.Length; I++) {
                    nuint Word = this._Words[I];
                    Count += BitOperations.PopCount(Word);
                }

                return Count;
            }
        }
    }
}
