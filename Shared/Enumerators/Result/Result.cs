using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2.Filters {
    ///DOLATER <summary>add description for enumerator: Result</summary>
    public enum Result {
        Absent = 0,
        PossiblyAbsent = 1,
        Present = 2,
        PossiblyPresent = 3,
    }

    public static class ResultExtension {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static Boolean IsPresent(this Result Result) {
            return Result is Result.Present or Result.PossiblyPresent;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public static Boolean IsAbsent(this Result Result) {
            return Result is Result.Absent or Result.PossiblyAbsent;
        }
    }
}
