using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for class: HashcodeFactory</summary>
    public static partial class HashcodeFactory {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public static HashAlgorithm[] GetHashcoders(Int32 amount) {
            var Result = new HashAlgorithm[]{
                MD5.Create(),
                SHA1.Create(),
                SHA256.Create(),
                SHA384.Create(),
                SHA512.Create(),
            };


            return Result
        }
    }
}
