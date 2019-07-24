using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMap.MapServer.Services.Models
{
    public static class LayerHelper
    {
        public static int GetFixedLevel(List<double> resolutions, double xmin, double ymin, double xmax, double ymax, int width, int height)
        {
            if (resolutions == null || resolutions.Count == 0)
            {
                throw new Exception("resolutions不能为空");
            }
            double dx = xmax - xmin;
            double dy = ymax - ymin;
            double resolution = Math.Max(dy / height, dx / width);
            int level = 0;
            for (int i = 0; i < resolutions.Count; i++)
            {
                if (resolution > resolutions[i])
                {
                    if (i == 0)
                    {
                        level = i;
                    }
                    else
                    {
                        level = i - 1;
                    }
                    break;
                }
            }
            return level;
        }
    }
}
