using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpMapServer.Services.Models
{
    public class ServiceRecord:NameRecord
    {
        public string Type { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }
    }
}
