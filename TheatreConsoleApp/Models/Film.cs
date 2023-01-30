using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core.Services;

namespace TheatreConsoleApp.Models
{

    internal class Film : Entity
    {
        internal string Name { get; set; }

        public override string ToString()
        {
            return $"Film: {Name}";
        }
    }
}
