using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    ///DOLATER <summary>Add description for class: Constants</summary>
    internal static partial class Constants {
        /// <summary> The amount of bytes a <see cref="nuint"/> uses</summary>
        public static Int32 BytesNUInt = UIntPtr.Size;
        /// <summary> The amount of bits a  <see cref="nuint"/> uses</summary>
        public static Int32 BitsNUInt = BytesNUInt * 8; 
    }
}
