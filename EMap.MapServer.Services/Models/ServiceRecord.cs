using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public class ServiceRecord:NameRecord
    {
        [Display(Name = "类型")]
        public OgcServiceType Type { get; set; }
        [Display(Name = "版本")]
        public string Version { get; set; }
        [Display(Name = "路径")]
        public string Path { get; set; }
    }
}
