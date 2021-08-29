using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Tables
{
    /// <summary>
    /// A Table to roll on.
    /// </summary>
    public class Table
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid Id { get; set; }

        public string CreatedBy { get; set; }

        /// <summary>
        /// A Header for a Table.  Includes the dice to define the roll (first column) on a table, and column names for the results.
        /// </summary>
        public Header Header { get; set; }

        /// <summary>
        /// Rows for the table.  Includes a result range (first column) and results defined by column names.
        /// </summary>
        public List<Row> Rows { get; set; }
    }
}
