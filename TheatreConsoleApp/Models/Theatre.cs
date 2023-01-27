using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Services;

namespace TheatreConsoleApp.Models
{
    internal class Theatre : Entity
    {
        internal string Name { get; set; }

        internal string Address { get; set; }

        public override string ToString()
        {
            return $"Theatre ID: {Id}, Theatre Name: {Name}, Address: {Address}";
        }
    }
}
