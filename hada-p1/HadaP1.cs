using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// This class contains methods to convert from seconds to minutes and viceversa.
    /// </summary>
    class HadaP1
    {
        /// <summary>
        /// This method converts from seconds to minutes.
        /// </summary>
        /// <param name="s">The number of seconds that will be converted to minutes.</param>
        /// <returns>The number of minutes equivalent to s seconds.</returns>
        public static double Seconds2Minutes(double s)
        {
            if (s == 0) return 0;
            return s / 60;
        }

        /// <summary>
        /// This method converts from minutes to seconds.
        /// </summary>
        /// <param name="m">The number of minutes that will be converted to seconds.</param>
        /// <returns>The number of seconds equivalent to m minutes.</returns>
        public static double Minutes2Seconds(double m)
        {
            if (m == 0) return 0;
            return m * 60;
        }
    }
}
