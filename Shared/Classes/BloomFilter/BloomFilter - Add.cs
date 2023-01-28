using System.Runtime.CompilerServices;

namespace DaanV2.Filters {
    public partial class BloomFilter {
        /// <inheritdoc/>
        public void Add(ReadOnlySpan<Byte> Data) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private void SetBit(Int32 index) {
            //Get index of the word and the index of the bit to set
            (Int32 wordIndex, Int32 bitIndex) = Math.DivRem(index, Constants.BitsNUInt);

            //Retrieve word
            nuint word = this._Words[wordIndex];
            //Set bit
            word |= ((nuint)1 << bitIndex);
            // Return word
            this._Words[wordIndex] = word;
        }
    }
}
