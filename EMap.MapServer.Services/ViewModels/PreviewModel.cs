using EMap.MapServer.OpenLayers;
using EMap.MapServer.OpenLayers.layer;
using EMap.MapServer.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.ViewModels
{
    public class PreviewModel 
    {
        public BaseLayer[] Layers { get; set; }
        public View View { get; set; }
        public int LayerId { get; set; }

    }
}
