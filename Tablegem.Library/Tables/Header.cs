using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablegem.Library.Tables
{
    /// <summary>
    /// A Header for a Table.  Includes the dice to define the roll (first column) on a table, and column names for the results.
    /// </summary>
    public class Header
    {
        /// <summary>
        /// Defines the dice to be rolled on a table.
        /// </summary>
        public DiceRoll DiceRoll { get; set; }

        /// <summary>
        /// List of column names for a table.
        /// </summary>
        public List<ColumnName> ColumnNames { get; set; }
    }
}
