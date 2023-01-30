using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Theatre : Entity
    {
        internal string Name { get; set; }

        public override string ToString()
        {
            return $"Cinema: {Name} ";
        }
    }
}
