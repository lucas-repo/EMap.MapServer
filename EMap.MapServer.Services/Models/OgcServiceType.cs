using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public enum OgcServiceType
    {
        [Display(Name ="wms")]
        Wms,
        Wfs,
        Wcs,
        Wmts
    }
}
