using System.Runtime.CompilerServices;

namespace DaanV2.Filters {
    public partial class BloomFilter {
        /// <inheritdoc/>
        public Result Has(ReadOnlySpan<Byte> Data) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private Boolean GetBit(Int32 index) {
            //Get index of the word and the index of the bit to set
            (Int32 wordIndex, Int32 bitIndex) = Math.DivRem(index, Constants.BitsNUInt);

            //Retrieve word
            ref nuint word = ref this._Words[wordIndex];
            //Get bit
            nuint result = word & ((nuint)1 << bitIndex);
            return result != 0;
        }
    }
}
