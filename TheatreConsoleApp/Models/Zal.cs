using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Zal : Entity
    {
        internal string Name { get; set; }

        internal Theatre Theatre { get; set; }

        internal int RowCount { get; set; }

        internal int ColumnCount { get; set; }

        public override string ToString()
        {
            return $"Zal ID: {Id},Name: {Name},RowCount: {RowCount},ColumnCount: {ColumnCount}\n{Theatre}";
        }
    }
}
