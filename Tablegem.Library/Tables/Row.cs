using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Tables
{
    /// <summary>
    /// A Row for a table.  Includes a result range (first column) and results defined by column names.
    /// </summary>
    public class Row
    {
        /// <summary>
        /// Result range for a dice roll.  Can be a range or single number.  ex.: 4-6, 5
        /// </summary>
        public ResultRange ResultRange { get; set; }

        /// <summary>
        /// List of results for a table defined by column names.
        /// </summary>
        public List<Result> Results { get; set; }
    }
}
